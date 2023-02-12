Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.IO.Compression
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace Costura
	' Token: 0x02000076 RID: 118
	<CompilerGenerated()>
	Friend Module AssemblyLoader
		' Token: 0x06000211 RID: 529 RVA: 0x00002B6F File Offset: 0x00000D6F
		Private Function CultureToString(culture As CultureInfo) As String
			If culture Is Nothing Then
				Return ""
			End If
			Return culture.Name
		End Function

		' Token: 0x06000212 RID: 530 RVA: 0x00012280 File Offset: 0x00010480
		Private Function ReadExistingAssembly(name As AssemblyName) As Assembly
			For Each assembly As Assembly In AppDomain.CurrentDomain.GetAssemblies()
				Dim name2 As AssemblyName = assembly.GetName()
				If String.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) AndAlso String.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase) Then
					Return assembly
				End If
			Next
			Return Nothing
		End Function

		' Token: 0x06000213 RID: 531 RVA: 0x000122E8 File Offset: 0x000104E8
		Private Sub CopyTo(source As Stream, destination As Stream)
			Dim array As Byte() = New Byte(81919) {}
			While True
				Dim num As Integer = source.Read(array, 0, array.Length)
				Dim num2 As Integer = num
				If num = 0 Then
					Exit For
				End If
				destination.Write(array, 0, num2)
			End While
		End Sub

		' Token: 0x06000214 RID: 532 RVA: 0x0001231C File Offset: 0x0001051C
		Private Function LoadStream(fullName As String) As Stream
			Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
			If fullName.EndsWith(".compressed") Then
				Dim stream As Stream
				Using manifestResourceStream As Stream = executingAssembly.GetManifestResourceStream(fullName)
					Using deflateStream As DeflateStream = New DeflateStream(manifestResourceStream, CompressionMode.Decompress)
						Dim memoryStream As MemoryStream = New MemoryStream()
						AssemblyLoader.CopyTo(deflateStream, memoryStream)
						memoryStream.Position = 0L
						stream = memoryStream
					End Using
				End Using
				Return stream
			End If
			Return executingAssembly.GetManifestResourceStream(fullName)
		End Function

		' Token: 0x06000215 RID: 533 RVA: 0x000123A8 File Offset: 0x000105A8
		Private Function LoadStream(resourceNames As Dictionary(Of String, String), name As String) As Stream
			Dim text As String
			If resourceNames.TryGetValue(name, text) Then
				Return AssemblyLoader.LoadStream(text)
			End If
			Return Nothing
		End Function

		' Token: 0x06000216 RID: 534 RVA: 0x000123C8 File Offset: 0x000105C8
		Private Function ReadStream(stream As Stream) As Byte()
			Dim array As Byte() = New Byte(stream.Length - 1) {}
			stream.Read(array, 0, array.Length)
			Return array
		End Function

		' Token: 0x06000217 RID: 535 RVA: 0x000123F0 File Offset: 0x000105F0
		Private Function ReadFromEmbeddedResources(assemblyNames As Dictionary(Of String, String), symbolNames As Dictionary(Of String, String), requestedAssemblyName As AssemblyName) As Assembly
			Dim text As String = requestedAssemblyName.Name.ToLowerInvariant()
			If requestedAssemblyName.CultureInfo IsNot Nothing AndAlso Not String.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name) Then
				text = requestedAssemblyName.CultureInfo.Name + "." + text
			End If
			Dim array As Byte()
			Using stream As Stream = AssemblyLoader.LoadStream(assemblyNames, text)
				If stream Is Nothing Then
					Return Nothing
				End If
				array = AssemblyLoader.ReadStream(stream)
			End Using
			Using stream2 As Stream = AssemblyLoader.LoadStream(symbolNames, text)
				If stream2 IsNot Nothing Then
					Dim array2 As Byte() = AssemblyLoader.ReadStream(stream2)
					Return Assembly.Load(array, array2)
				End If
			End Using
			Return Assembly.Load(array)
		End Function

		' Token: 0x06000218 RID: 536 RVA: 0x000124B0 File Offset: 0x000106B0
		Public Function ResolveAssembly(sender As Object, e As ResolveEventArgs) As Assembly
			Dim obj As Object = AssemblyLoader.nullCacheLock
			SyncLock obj
				If AssemblyLoader.nullCache.ContainsKey(e.Name) Then
					Return Nothing
				End If
			End SyncLock
			Dim assemblyName As AssemblyName = New AssemblyName(e.Name)
			Dim assembly As Assembly = AssemblyLoader.ReadExistingAssembly(assemblyName)
			If assembly IsNot Nothing Then
				Return assembly
			End If
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName)
			If assembly Is Nothing Then
				obj = AssemblyLoader.nullCacheLock
				SyncLock obj
					AssemblyLoader.nullCache(e.Name) = True
				End SyncLock
				If(assemblyName.Flags And AssemblyNameFlags.Retargetable) <> AssemblyNameFlags.None Then
					assembly = Assembly.Load(assemblyName)
				End If
			End If
			Return assembly
		End Function

		' Token: 0x06000219 RID: 537 RVA: 0x00012590 File Offset: 0x00010790
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			AssemblyLoader.assemblyNames.Add("ionic.zip", "costura.ionic.zip.dll.compressed")
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed")
			AssemblyLoader.assemblyNames.Add("skinsoft.visualstyler", "costura.skinsoft.visualstyler.dll.compressed")
			AssemblyLoader.assemblyNames.Add("system.management.automation", "costura.system.management.automation.dll.compressed")
		End Sub

		' Token: 0x0600021A RID: 538 RVA: 0x00002B80 File Offset: 0x00000D80
		Public Sub Attach()
			If Interlocked.Exchange(AssemblyLoader.isAttached, 1) = 1 Then
				Return
			End If
			AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf AssemblyLoader.ResolveAssembly
		End Sub

		' Token: 0x040001CA RID: 458
		Private nullCacheLock As Object = New Object()

		' Token: 0x040001CB RID: 459
		Private nullCache As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)()

		' Token: 0x040001CC RID: 460
		Private assemblyNames As Dictionary(Of String, String) = New Dictionary(Of String, String)()

		' Token: 0x040001CD RID: 461
		Private symbolNames As Dictionary(Of String, String) = New Dictionary(Of String, String)()

		' Token: 0x040001CE RID: 462
		Private isAttached As Integer
	End Module
End Namespace
