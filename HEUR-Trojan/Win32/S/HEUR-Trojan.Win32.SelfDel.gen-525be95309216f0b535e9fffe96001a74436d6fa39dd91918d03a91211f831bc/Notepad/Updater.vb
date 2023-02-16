Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports vHack_Loader.My

Namespace vHack_Loader
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class Updater
		Inherits Form

		' Token: 0x06000156 RID: 342 RVA: 0x0000927C File Offset: 0x0000747C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Downloader_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Updater_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x06000159 RID: 345 RVA: 0x00009613 File Offset: 0x00007813
		' (set) Token: 0x0600015A RID: 346 RVA: 0x0000961C File Offset: 0x0000781C
		Friend Overridable Property ExcisionTheme1 As ExcisionTheme
			<CompilerGenerated()>
			Get
				Return Me._ExcisionTheme1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ExcisionTheme)
				Dim eventHandler As EventHandler = AddressOf Me.ExcisionTheme1_Click
				Dim excisionTheme As ExcisionTheme = Me._ExcisionTheme1
				If excisionTheme IsNot Nothing Then
					RemoveHandler excisionTheme.Click, eventHandler
				End If
				Me._ExcisionTheme1 = value
				excisionTheme = Me._ExcisionTheme1
				If excisionTheme IsNot Nothing Then
					AddHandler excisionTheme.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x0600015B RID: 347 RVA: 0x0000965F File Offset: 0x0000785F
		' (set) Token: 0x0600015C RID: 348 RVA: 0x00009668 File Offset: 0x00007868
		Friend Overridable Property BackgroundWorker1 As BackgroundWorker
			<CompilerGenerated()>
			Get
				Return Me._BackgroundWorker1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BackgroundWorker)
				Dim doWorkEventHandler As DoWorkEventHandler = AddressOf Me.BackgroundWorker1_DoWork
				Dim progressChangedEventHandler As ProgressChangedEventHandler = AddressOf Me.BackgroundWorker1_ProgressChanged
				Dim runWorkerCompletedEventHandler As RunWorkerCompletedEventHandler = AddressOf Me.BackgroundWorker1_RunWorkerCompleted
				Dim backgroundWorker As BackgroundWorker = Me._BackgroundWorker1
				If backgroundWorker IsNot Nothing Then
					RemoveHandler backgroundWorker.DoWork, doWorkEventHandler
					RemoveHandler backgroundWorker.ProgressChanged, progressChangedEventHandler
					RemoveHandler backgroundWorker.RunWorkerCompleted, runWorkerCompletedEventHandler
				End If
				Me._BackgroundWorker1 = value
				backgroundWorker = Me._BackgroundWorker1
				If backgroundWorker IsNot Nothing Then
					AddHandler backgroundWorker.DoWork, doWorkEventHandler
					AddHandler backgroundWorker.ProgressChanged, progressChangedEventHandler
					AddHandler backgroundWorker.RunWorkerCompleted, runWorkerCompletedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x0600015D RID: 349 RVA: 0x000096E1 File Offset: 0x000078E1
		' (set) Token: 0x0600015E RID: 350 RVA: 0x000096E9 File Offset: 0x000078E9
		Friend Overridable Property Label1 As Label

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x0600015F RID: 351 RVA: 0x000096F2 File Offset: 0x000078F2
		' (set) Token: 0x06000160 RID: 352 RVA: 0x000096FA File Offset: 0x000078FA
		Friend Overridable Property ExcisionProgressBar1 As ExcisionProgressBar

		' Token: 0x06000161 RID: 353 RVA: 0x00009703 File Offset: 0x00007903
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Downloader_FormClosing(sender As Object, e As FormClosingEventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x06000162 RID: 354 RVA: 0x0000970C File Offset: 0x0000790C
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Updater_Load(sender As Object, e As EventArgs)
			Dim text As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim i As Integer = 0
			Me.Text = ""
			Dim random As Random = New Random()
			While i <= 18
				Dim text2 As String = Conversions.ToString(random.[Next](0, text.Length))
				Me.Text += Conversions.ToString(text(Conversions.ToInteger(text2)))
				i += 1
			End While
			MyProject.Forms.Main.Dispose()
			Using saveFileDialog As SaveFileDialog = New SaveFileDialog()
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					Me.FName = saveFileDialog.FileName
					Me.Label1.Text = Me.FName
					If Me.DownloadLink.Contains("<!") Then
						Me.DownloadLink = Me.DownloadLink.Replace("<!", "")
					End If
					Me.BackgroundWorker1.RunWorkerAsync()
				Else
					Interaction.MsgBox("Please visit site for download new loader", MsgBoxStyle.Exclamation, "Download")
					ProjectData.EndApp()
				End If
			End Using
		End Sub

		' Token: 0x06000163 RID: 355 RVA: 0x00009828 File Offset: 0x00007A28
		Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)
			Dim downloadLink As String = Me.DownloadLink
			Dim fname As String = Me.FName
			Dim httpWebResponse As HttpWebResponse = CType(CType(WebRequest.Create(New Uri(downloadLink)), HttpWebRequest).GetResponse(), HttpWebResponse)
			httpWebResponse.Close()
			Dim contentLength As Long = httpWebResponse.ContentLength
			Dim num As Long = 0L
			Using webClient As WebClient = New WebClient()
				Using stream As Stream = webClient.OpenRead(New Uri(downloadLink))
					Using stream2 As Stream = New FileStream(fname, FileMode.Create, FileAccess.Write, FileShare.None)
						Dim num2 As Integer = 0
						Dim array As Byte() = New Byte(CInt((contentLength - 1L)) + 1 - 1) {}
						While Updater.InlineAssignHelper(Of Integer)(num2, stream.Read(array, 0, array.Length)) > 0
							stream2.Write(array, 0, num2)
							num += CLng(num2)
							Dim num3 As Double = CDbl(num)
							Dim num4 As Double = CDbl(array.Length)
							Dim num5 As Integer = CInt(Math.Round(Math.Truncate(num3 / num4 * 100.0)))
							Me.BackgroundWorker1.ReportProgress(num5)
						End While
						stream2.Close()
					End Using
					stream.Close()
				End Using
			End Using
		End Sub

		' Token: 0x06000164 RID: 356 RVA: 0x00009958 File Offset: 0x00007B58
		Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
			Me.ExcisionProgressBar1.Value = e.ProgressPercentage
		End Sub

		' Token: 0x06000165 RID: 357 RVA: 0x0000996B File Offset: 0x00007B6B
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
			Interaction.MsgBox("File download to : " + Me.FName, MsgBoxStyle.Information, "Finished")
			ProjectData.EndApp()
		End Sub

		' Token: 0x06000166 RID: 358 RVA: 0x0000998F File Offset: 0x00007B8F
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		' Token: 0x06000167 RID: 359 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub ExcisionTheme1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000094 RID: 148
		Private FName As String

		' Token: 0x04000095 RID: 149
		Public DownloadLink As String
	End Class
End Namespace
