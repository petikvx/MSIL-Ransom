Imports System
Imports System.Net

Namespace Main.Tools
	' Token: 0x02000035 RID: 53
	Public Class MachineScanResult
		' Token: 0x0600012E RID: 302 RVA: 0x0000277D File Offset: 0x0000097D
		Public Sub New(ipAddress As String)
			Me.IpAddress = ipAddress
		End Sub

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x0600012F RID: 303 RVA: 0x0000279E File Offset: 0x0000099E
		Public ReadOnly Property IpAddress As String

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000130 RID: 304 RVA: 0x000027A6 File Offset: 0x000009A6
		' (set) Token: 0x06000131 RID: 305 RVA: 0x000027AE File Offset: 0x000009AE
		Public Property scanningStatus As MachineScanResult.ScanningStatus

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000132 RID: 306 RVA: 0x000027B7 File Offset: 0x000009B7
		' (set) Token: 0x06000133 RID: 307 RVA: 0x000027BF File Offset: 0x000009BF
		Public Property vulnerabilityStatus As MachineScanResult.VulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_RESPONSE_FROM_HOST

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000134 RID: 308 RVA: 0x000027C8 File Offset: 0x000009C8
		' (set) Token: 0x06000135 RID: 309 RVA: 0x000027D0 File Offset: 0x000009D0
		Public Property hostname As String = MachineScanResult.DEFAULT_HOST_NAME

		' Token: 0x06000136 RID: 310 RVA: 0x000027D9 File Offset: 0x000009D9
		Public Sub UpdateScanningStatus()
			Me.scanningStatus = MachineScanResult.ScanningStatus.Scanning
		End Sub

		' Token: 0x06000137 RID: 311 RVA: 0x0000B4A4 File Offset: 0x000096A4
		Public Function GetHostName() As String
			Dim text As String
			If Not Me.hostname.Equals(MachineScanResult.DEFAULT_HOST_NAME) Then
				text = Me.hostname
			Else
				Try
					If Configuration.IS_DEBUG Then
						Return "HOST " + New Random().[Next](256)
					End If
					Dim hostEntry As IPHostEntry = Dns.GetHostEntry(Me.IpAddress)
					If hostEntry IsNot Nothing Then
						Me.hostname = hostEntry.HostName
						Return Me.hostname
					End If
				Catch ex As Exception
				End Try
				text = MachineScanResult.DEFAULT_HOST_NAME
			End If
			Return text
		End Function

		' Token: 0x06000138 RID: 312 RVA: 0x0000B53C File Offset: 0x0000973C
		Public Sub UpdateFinishedResult(vulnerabilityStatus As MachineScanResult.VulnerabilityStatus)
			Me.vulnerabilityStatus = vulnerabilityStatus
			Me.scanningStatus = MachineScanResult.ScanningStatus.Done
			If Me.IsLiveMachine() Then
				Me.hostname = Me.GetHostName()
			End If
		End Sub

		' Token: 0x06000139 RID: 313 RVA: 0x0000B56C File Offset: 0x0000976C
		Public Function IsVulnerable() As Boolean
			Return Me.vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.YES
		End Function

		' Token: 0x0600013A RID: 314 RVA: 0x0000B584 File Offset: 0x00009784
		Public Function IsSmb1Enabled() As Boolean
			Return Me.vulnerabilityStatus <> MachineScanResult.VulnerabilityStatus.NO_RESPONSE_FROM_HOST AndAlso Me.vulnerabilityStatus <> MachineScanResult.VulnerabilityStatus.NO_SMB1_DISABLED
		End Function

		' Token: 0x0600013B RID: 315 RVA: 0x0000B5B4 File Offset: 0x000097B4
		Public Function IsLiveMachine() As Boolean
			Return Me.vulnerabilityStatus <> MachineScanResult.VulnerabilityStatus.NO_RESPONSE_FROM_HOST
		End Function

		' Token: 0x0600013C RID: 316 RVA: 0x0000B5D0 File Offset: 0x000097D0
		Public Function VulnerabilityStatusToString() As String
			Dim text As String
			If Me.scanningStatus <> MachineScanResult.ScanningStatus.Done Then
				text = ""
			ElseIf Me.vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_RESPONSE_FROM_HOST Then
				text = "NO RESPONSE"
			ElseIf Me.vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_SMB1_ENABLED Then
				text = "NO (SMBv1 enabled)"
			ElseIf Me.vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_SMB1_DISABLED Then
				text = "NO"
			Else
				text = Me.vulnerabilityStatus.ToString()
			End If
			Return text
		End Function

		' Token: 0x040000E0 RID: 224
		Private Shared DEFAULT_HOST_NAME As String = ""

		' Token: 0x02000036 RID: 54
		Public Enum ScanningStatus
			' Token: 0x040000E6 RID: 230
			Queued
			' Token: 0x040000E7 RID: 231
			Scanning
			' Token: 0x040000E8 RID: 232
			Done
		End Enum

		' Token: 0x02000037 RID: 55
		Public Enum VulnerabilityStatus
			' Token: 0x040000EA RID: 234
			UNKNOWN
			' Token: 0x040000EB RID: 235
			YES
			' Token: 0x040000EC RID: 236
			NO_SMB1_DISABLED
			' Token: 0x040000ED RID: 237
			NO_SMB1_ENABLED
			' Token: 0x040000EE RID: 238
			NO_RESPONSE_FROM_HOST
		End Enum
	End Class
End Namespace
