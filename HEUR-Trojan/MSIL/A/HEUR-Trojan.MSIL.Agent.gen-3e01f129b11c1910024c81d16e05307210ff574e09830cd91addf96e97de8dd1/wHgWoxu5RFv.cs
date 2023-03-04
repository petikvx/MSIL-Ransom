using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;

internal class wHgWoxu5RFv
{
	private static byte[] LineSeparator => Encoding.ASCII.GetBytes(Environment.NewLine);

	public static string B0d5hYM0Qa_b(string message, string key)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		new TaskSchedulerException();
		new MissingMemberException();
		new StackFrame();
		new RIPEMD160Managed();
		new RSAOAEPKeyExchangeDeformatter();
		new MissingFieldException();
		new AggregateException();
		new MutexSecurity();
		new OperationCanceledException();
		new TimeZoneNotFoundException();
		MemoryStream inputStream = new MemoryStream(Encoding.ASCII.GetBytes(message));
		new UTF7Encoding();
		new ThaiBuddhistCalendar();
		new ApplicationDirectoryMembershipCondition();
		new HostProtectionException();
		MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(key));
		try
		{
			string text = B0d5hYM0Qa_b(inputStream, PgpUtilities.GetDecoderStream((Stream)memoryStream));
			if (text.EndsWith(Environment.NewLine))
			{
				text = text.Remove(text.LastIndexOf(Environment.NewLine));
			}
			return text;
		}
		catch (Exception)
		{
			return "247nX1P9";
		}
	}

	public static string B0d5hYM0Qa_b(Stream inputStream, Stream keyIn)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		new SynchronizationContext();
		new CryptographicUnexpectedOperationException();
		ArmoredInputStream val = new ArmoredInputStream(inputStream);
		new AccessViolationException();
		new DataMisalignedException();
		MemoryStream memoryStream = new MemoryStream();
		new PolicyException();
		new ThaiBuddhistCalendar();
		MemoryStream memoryStream2 = new MemoryStream();
		new TrustManagerContext();
		new InvalidTimeZoneException();
		new ChineseLunisolarCalendar();
		int num = wUx0E_(memoryStream2, (Stream)(object)val);
		byte[] lineSeparator = LineSeparator;
		if (num != -1 && val.IsClearText())
		{
			new HMACSHA256();
			new HMACRIPEMD160();
			byte[] array = memoryStream2.ToArray();
			new UnauthorizedAccessException();
			new ThreadStateException();
			new EncoderFallbackException();
			new UTF32Encoding();
			new ArgumentException();
			new EncoderExceptionFallback();
			new CaseInsensitiveComparer();
			new GacInstalled();
			new EncoderExceptionFallbackBuffer();
			memoryStream.Write(array, 0, Al11A1(array));
			new InsufficientMemoryException();
			new RijndaelManaged();
			memoryStream.Write(lineSeparator, 0, lineSeparator.Length);
			while (num != -1 && val.IsClearText())
			{
				new CancellationTokenSource();
				new TaiwanLunisolarCalendar();
				num = wUx0E_(memoryStream2, num, (Stream)(object)val);
				new PolicyException();
				new VerificationException();
				new OutOfMemoryException();
				new ThreadInterruptedException();
				new AppDomainManager();
				new SHA1Managed();
				new KoreanCalendar();
				array = memoryStream2.ToArray();
				new DSASignatureFormatter();
				new HebrewCalendar();
				memoryStream.Write(array, 0, Al11A1(array));
				memoryStream.Write(lineSeparator, 0, lineSeparator.Length);
			}
		}
		else if (num != -1)
		{
			new TargetException();
			new RankException();
			byte[] array2 = memoryStream2.ToArray();
			new Hashtable();
			new RSAOAEPKeyExchangeDeformatter();
			new ThaiBuddhistCalendar();
			memoryStream.Write(array2, 0, Al11A1(array2));
			memoryStream.Write(lineSeparator, 0, lineSeparator.Length);
		}
		new RSAOAEPKeyExchangeFormatter();
		new SynchronizationLockException();
		memoryStream.Flush();
		new SHA512Managed();
		new KeyNotFoundException();
		new EncoderExceptionFallback();
		new DllNotFoundException();
		PgpPublicKeyRingBundle val2 = new PgpPublicKeyRingBundle(keyIn);
		new RSAPKCS1SignatureDeformatter();
		new FileNotFoundException();
		PgpObjectFactory val3 = new PgpObjectFactory((Stream)(object)val);
		new SHA512Managed();
		new ReaderWriterLock();
		PgpSignatureList val4 = (PgpSignatureList)val3.NextPgpObject();
		new FieldAccessException();
		new SignatureDescription();
		PgpSignature val5 = val4.get_Item(0);
		PgpPublicKey publicKey = val2.GetPublicKey(val5.get_KeyId());
		if (publicKey == null)
		{
			throw new Exception("Can't verify the message signature.");
		}
		new UTF32Encoding();
		new TargetException();
		new SymLanguageVendor();
		new EncoderReplacementFallback();
		new IOException();
		new ApplicationTrust();
		val5.InitVerify(publicKey);
		new NullReferenceException();
		new DuplicateWaitObjectException();
		new NumberFormatInfo();
		new CancellationTokenSource();
		new Exception();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		new NotSupportedException();
		new FormatException();
		new ThreadInterruptedException();
		new TimeZoneNotFoundException();
		new EncoderExceptionFallbackBuffer();
		new DecoderFallbackException();
		new InvalidTimeZoneException();
		new SynchronizationContext();
		new MissingManifestResourceException();
		StreamReader streamReader = new StreamReader(memoryStream);
		new RSAPKCS1KeyExchangeFormatter();
		new SignatureDescription();
		new Overlapped();
		new HMACSHA1();
		new HMACSHA256();
		new DateTimeFormatInfo();
		new CancellationTokenSource();
		new ArrayTypeMismatchException();
		new Queue();
		new EntryPointNotFoundException();
		new ArgumentOutOfRangeException();
		new HMACSHA384();
		new JulianCalendar();
		new TrustManagerContext();
		new Evidence();
		new SecureString();
		new RSAOAEPKeyExchangeDeformatter();
		new ApplicationDirectoryMembershipCondition();
		new ApplicationException();
		new CspParameters();
		new EndOfStreamException();
		new GregorianCalendar();
		new GacMembershipCondition();
		new SHA1Managed();
		new DecoderExceptionFallbackBuffer();
		new TrustManagerContext();
		new AccessViolationException();
		new DriveNotFoundException();
		new SortedList();
		string result = streamReader.ReadToEnd();
		new GacMembershipCondition();
		new SymLanguageVendor();
		new RSAOAEPKeyExchangeDeformatter();
		new UnicodeEncoding();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		new KoreanCalendar();
		new TimeZoneNotFoundException();
		new OutOfMemoryException();
		new ASCIIEncoding();
		new SymDocumentType();
		new AllMembershipCondition();
		new WaitHandleCannotBeOpenedException();
		new ASCIIEncoding();
		new Version();
		new RSAPKCS1KeyExchangeFormatter();
		Stream stream = memoryStream;
		new StringWriter();
		new EncoderReplacementFallback();
		new Hashtable();
		num = wUx0E_(memoryStream2, stream);
		UWo5CZ1jNLi(val5, memoryStream2.ToArray());
		if (num != -1)
		{
			do
			{
				new CspParameters();
				new GacInstalled();
				new GregorianCalendar();
				new IdentityReferenceCollection();
				new HMACSHA512();
				new AppDomainUnloadedException();
				new DecoderReplacementFallback();
				new InvalidProgramException();
				new HostExecutionContextManager();
				new IdentityReferenceCollection();
				new StackFrame();
				new CaseInsensitiveComparer();
				new CancellationTokenSource();
				new Mutex();
				num = wUx0E_(memoryStream2, num, stream);
				new InsufficientExecutionStackException();
				new TrustManagerContext();
				new HMACSHA512();
				val5.Update((byte)13);
				new DivideByZeroException();
				new ThreadInterruptedException();
				val5.Update((byte)10);
				UWo5CZ1jNLi(val5, memoryStream2.ToArray());
			}
			while (num != -1);
		}
		stream.Close();
		if (!val5.Verify())
		{
			throw new Exception("Can't verify the message signature.");
		}
		return result;
	}

	private static int wUx0E_(MemoryStream bOut, Stream fIn)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		new GacIdentityPermission();
		new AllMembershipCondition();
		new MissingMethodException();
		new AssemblyName();
		bOut.SetLength(0L);
		new HebrewCalendar();
		new DSASignatureDeformatter();
		new ExecutionEngineException();
		new ArrayTypeMismatchException();
		new DSASignatureDeformatter();
		int result = -1;
		new EncoderReplacementFallback();
		new MissingFieldException();
		int num;
		while ((num = fIn.ReadByte()) >= 0)
		{
			bOut.WriteByte((byte)num);
			if (num == 13 || num == 10)
			{
				new Exception();
				new TimeZoneNotFoundException();
				result = bng5bRoZXqP(bOut, num, fIn);
				break;
			}
		}
		return result;
	}

	private static int bng5bRoZXqP(MemoryStream bOut, int lastCh, Stream fIn)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		int num = fIn.ReadByte();
		if (lastCh == 13 && num == 10)
		{
			new MissingFieldException();
			new InvalidTimeZoneException();
			new DSASignatureDeformatter();
			new InsufficientExecutionStackException();
			new AssemblyNameProxy();
			new MissingManifestResourceException();
			new GacMembershipCondition();
			new Exception();
			new StackFrame();
			new AppDomainUnloadedException();
			new TypeLoadException();
			new DriveNotFoundException();
			new SynchronizationLockException();
			new FieldAccessException();
			new CryptographicUnexpectedOperationException();
			new IdentityNotMappedException();
			new TimeoutException();
			new NumberFormatInfo();
			new JapaneseCalendar();
			new ApplicationDirectoryMembershipCondition();
			new ThaiBuddhistCalendar();
			new SymLanguageVendor();
			new CryptoKeySecurity();
			new ThreadStateException();
			new StackOverflowException();
			new LockRecursionException();
			new IOException();
			new RSAPKCS1KeyExchangeDeformatter();
			new DecoderFallbackException();
			new StackFrame();
			new UmAlQuraCalendar();
			new MemberAccessException();
			new ArgumentException();
			new SymLanguageVendor();
			new SHA256Managed();
			new Hashtable();
			new SymDocumentType();
			new RSAOAEPKeyExchangeDeformatter();
			bOut.WriteByte((byte)num);
			num = fIn.ReadByte();
		}
		return num;
	}

	private static void UWo5CZ1jNLi(PgpSignature sig, byte[] y7uMfxcGJvYVP)
	{
		int num = wo20qHJH(y7uMfxcGJvYVP);
		if (num > 0)
		{
			sig.Update(y7uMfxcGJvYVP, 0, num);
		}
	}

	private static int Al11A1(byte[] y7uMfxcGJvYVP)
	{
		new CryptographicException();
		new EncoderFallbackException();
		int num = y7uMfxcGJvYVP.Length - 1;
		while (num >= 0 && a_hRf2FOPCy(y7uMfxcGJvYVP[num]))
		{
			num--;
		}
		return num + 1;
	}

	private static bool snSiUteuEjzim2(byte b)
	{
		if (b != 13)
		{
			return b == 10;
		}
		return true;
	}

	private static int wo20qHJH(byte[] y7uMfxcGJvYVP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		new SynchronizationContext();
		new AllMembershipCondition();
		int num = y7uMfxcGJvYVP.Length - 1;
		while (num >= 0 && a_hRf2FOPCy(y7uMfxcGJvYVP[num]))
		{
			num--;
		}
		return num + 1;
	}

	private static bool a_hRf2FOPCy(byte b)
	{
		if (!snSiUteuEjzim2(b) && b != 9)
		{
			return b == 32;
		}
		return true;
	}

	private static int wUx0E_(MemoryStream bOut, int BTQt9scyRbH, Stream fIn)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		new NotImplementedException();
		new ArgumentOutOfRangeException();
		new ApplicationTrust();
		new MissingSatelliteAssemblyException();
		new Mutex();
		new SymLanguageType();
		new SymDocumentType();
		new object();
		new X509Certificate();
		bOut.SetLength(0L);
		new StringBuilder();
		new CaseInsensitiveComparer();
		int num = BTQt9scyRbH;
		do
		{
			bOut.WriteByte((byte)num);
			if (num == 13 || num == 10)
			{
				new TaskFactory();
				new DirectorySecurity();
				new AssemblyNameProxy();
				new UTF8Encoding();
				BTQt9scyRbH = bng5bRoZXqP(bOut, num, fIn);
				break;
			}
		}
		while ((num = fIn.ReadByte()) >= 0);
		if (num < 0)
		{
			BTQt9scyRbH = -1;
		}
		return BTQt9scyRbH;
	}
}
