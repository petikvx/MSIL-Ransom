Imports System
Imports System.Runtime.InteropServices

Namespace Main.Tools
	' Token: 0x0200004F RID: 79
	Public Module VaultCli
		' Token: 0x060001B5 RID: 437
		Public Declare Function VaultOpenVault Lib "vaultcli.dll" (ByRef vaultGuid As Guid, offset As UInteger, ByRef vaultHandle As IntPtr) As Integer

		' Token: 0x060001B6 RID: 438
		Public Declare Function VaultCloseVault Lib "vaultcli.dll" (ByRef vaultHandle As IntPtr) As Integer

		' Token: 0x060001B7 RID: 439
		Public Declare Function VaultFree Lib "vaultcli.dll" (ByRef vaultHandle As IntPtr) As Integer

		' Token: 0x060001B8 RID: 440
		Public Declare Function VaultEnumerateVaults Lib "vaultcli.dll" (offset As Integer, ByRef vaultCount As Integer, ByRef vaultGuid As IntPtr) As Integer

		' Token: 0x060001B9 RID: 441
		Public Declare Function VaultEnumerateItems Lib "vaultcli.dll" (vaultHandle As IntPtr, chunkSize As Integer, ByRef vaultItemCount As Integer, ByRef vaultItem As IntPtr) As Integer

		' Token: 0x060001BA RID: 442
		Public Declare Function VaultGetItem Lib "vaultcli.dll" (vaultHandle As IntPtr, ByRef schemaId As Guid, pResourceElement As IntPtr, pIdentityElement As IntPtr, pPackageSid As IntPtr, zero As IntPtr, arg6 As Integer, ByRef passwordVaultPtr As IntPtr) As Integer

		' Token: 0x060001BB RID: 443
		Public Declare Function VaultGetItem_1 Lib "vaultcli.dll" Alias "VaultGetItem" (vaultHandle As IntPtr, ByRef schemaId As Guid, pResourceElement As IntPtr, pIdentityElement As IntPtr, zero As IntPtr, arg5 As Integer, ByRef passwordVaultPtr As IntPtr) As Integer

		' Token: 0x02000050 RID: 80
		Public Enum VAULT_ELEMENT_TYPE
			' Token: 0x04000159 RID: 345
			Undefined = -1
			' Token: 0x0400015A RID: 346
			[Boolean]
			' Token: 0x0400015B RID: 347
			[Short]
			' Token: 0x0400015C RID: 348
			UnsignedShort
			' Token: 0x0400015D RID: 349
			Int
			' Token: 0x0400015E RID: 350
			UnsignedInt
			' Token: 0x0400015F RID: 351
			[Double]
			' Token: 0x04000160 RID: 352
			Guid
			' Token: 0x04000161 RID: 353
			[String]
			' Token: 0x04000162 RID: 354
			ByteArray
			' Token: 0x04000163 RID: 355
			TimeStamp
			' Token: 0x04000164 RID: 356
			ProtectedArray
			' Token: 0x04000165 RID: 357
			Attribute
			' Token: 0x04000166 RID: 358
			Sid
			' Token: 0x04000167 RID: 359
			Last
		End Enum

		' Token: 0x02000051 RID: 81
		Public Enum VAULT_SCHEMA_ELEMENT_ID
			' Token: 0x04000169 RID: 361
			Illegal
			' Token: 0x0400016A RID: 362
			Resource
			' Token: 0x0400016B RID: 363
			Identity
			' Token: 0x0400016C RID: 364
			Authenticator
			' Token: 0x0400016D RID: 365
			Tag
			' Token: 0x0400016E RID: 366
			PackageSid
			' Token: 0x0400016F RID: 367
			AppStart = 100
			' Token: 0x04000170 RID: 368
			AppEnd = 10000
		End Enum

		' Token: 0x02000052 RID: 82
		Public Structure VAULT_ITEM_WIN8
			' Token: 0x04000171 RID: 369
			Public SchemaId As Guid

			' Token: 0x04000172 RID: 370
			Public pszCredentialFriendlyName As IntPtr

			' Token: 0x04000173 RID: 371
			Public pResourceElement As IntPtr

			' Token: 0x04000174 RID: 372
			Public pIdentityElement As IntPtr

			' Token: 0x04000175 RID: 373
			Public pAuthenticatorElement As IntPtr

			' Token: 0x04000176 RID: 374
			Public pPackageSid As IntPtr

			' Token: 0x04000177 RID: 375
			Public LastModified As ULong

			' Token: 0x04000178 RID: 376
			Public dwFlags As UInteger

			' Token: 0x04000179 RID: 377
			Public dwPropertiesCount As UInteger

			' Token: 0x0400017A RID: 378
			Public pPropertyElements As IntPtr
		End Structure

		' Token: 0x02000053 RID: 83
		Public Structure VAULT_ITEM_WIN7
			' Token: 0x0400017B RID: 379
			Public SchemaId As Guid

			' Token: 0x0400017C RID: 380
			Public pszCredentialFriendlyName As IntPtr

			' Token: 0x0400017D RID: 381
			Public pResourceElement As IntPtr

			' Token: 0x0400017E RID: 382
			Public pIdentityElement As IntPtr

			' Token: 0x0400017F RID: 383
			Public pAuthenticatorElement As IntPtr

			' Token: 0x04000180 RID: 384
			Public LastModified As ULong

			' Token: 0x04000181 RID: 385
			Public dwFlags As UInteger

			' Token: 0x04000182 RID: 386
			Public dwPropertiesCount As UInteger

			' Token: 0x04000183 RID: 387
			Public pPropertyElements As IntPtr
		End Structure

		' Token: 0x02000054 RID: 84
		<StructLayout(LayoutKind.Explicit)>
		Public Structure VAULT_ITEM_ELEMENT
			' Token: 0x04000184 RID: 388
			<FieldOffset(0)>
			Public SchemaElementId As VaultCli.VAULT_SCHEMA_ELEMENT_ID

			' Token: 0x04000185 RID: 389
			<FieldOffset(8)>
			Public Type As VaultCli.VAULT_ELEMENT_TYPE
		End Structure
	End Module
End Namespace
