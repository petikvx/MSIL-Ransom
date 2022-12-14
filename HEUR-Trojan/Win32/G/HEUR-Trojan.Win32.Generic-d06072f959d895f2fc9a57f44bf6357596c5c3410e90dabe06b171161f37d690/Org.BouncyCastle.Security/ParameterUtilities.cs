using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Nsri;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security;

public sealed class ParameterUtilities
{
	private static readonly IDictionary algorithms;

	private static readonly IDictionary basicIVSizes;

	private ParameterUtilities()
	{
	}

	static ParameterUtilities()
	{
		algorithms = Platform.CreateHashtable();
		basicIVSizes = Platform.CreateHashtable();
		AddAlgorithm("AES", "AESWRAP");
		AddAlgorithm("AES128", "2.16.840.1.101.3.4.2", NistObjectIdentifiers.IdAes128Cbc, NistObjectIdentifiers.IdAes128Ccm, NistObjectIdentifiers.IdAes128Cfb, NistObjectIdentifiers.IdAes128Ecb, NistObjectIdentifiers.IdAes128Gcm, NistObjectIdentifiers.IdAes128Ofb, NistObjectIdentifiers.IdAes128Wrap);
		AddAlgorithm("AES192", "2.16.840.1.101.3.4.22", NistObjectIdentifiers.IdAes192Cbc, NistObjectIdentifiers.IdAes192Ccm, NistObjectIdentifiers.IdAes192Cfb, NistObjectIdentifiers.IdAes192Ecb, NistObjectIdentifiers.IdAes192Gcm, NistObjectIdentifiers.IdAes192Ofb, NistObjectIdentifiers.IdAes192Wrap);
		AddAlgorithm("AES256", "2.16.840.1.101.3.4.42", NistObjectIdentifiers.IdAes256Cbc, NistObjectIdentifiers.IdAes256Ccm, NistObjectIdentifiers.IdAes256Cfb, NistObjectIdentifiers.IdAes256Ecb, NistObjectIdentifiers.IdAes256Gcm, NistObjectIdentifiers.IdAes256Ofb, NistObjectIdentifiers.IdAes256Wrap);
		AddAlgorithm("ARIA");
		AddAlgorithm("ARIA128", NsriObjectIdentifiers.id_aria128_cbc, NsriObjectIdentifiers.id_aria128_ccm, NsriObjectIdentifiers.id_aria128_cfb, NsriObjectIdentifiers.id_aria128_ctr, NsriObjectIdentifiers.id_aria128_ecb, NsriObjectIdentifiers.id_aria128_gcm, NsriObjectIdentifiers.id_aria128_ocb2, NsriObjectIdentifiers.id_aria128_ofb);
		AddAlgorithm("ARIA192", NsriObjectIdentifiers.id_aria192_cbc, NsriObjectIdentifiers.id_aria192_ccm, NsriObjectIdentifiers.id_aria192_cfb, NsriObjectIdentifiers.id_aria192_ctr, NsriObjectIdentifiers.id_aria192_ecb, NsriObjectIdentifiers.id_aria192_gcm, NsriObjectIdentifiers.id_aria192_ocb2, NsriObjectIdentifiers.id_aria192_ofb);
		AddAlgorithm("ARIA256", NsriObjectIdentifiers.id_aria256_cbc, NsriObjectIdentifiers.id_aria256_ccm, NsriObjectIdentifiers.id_aria256_cfb, NsriObjectIdentifiers.id_aria256_ctr, NsriObjectIdentifiers.id_aria256_ecb, NsriObjectIdentifiers.id_aria256_gcm, NsriObjectIdentifiers.id_aria256_ocb2, NsriObjectIdentifiers.id_aria256_ofb);
		AddAlgorithm("BLOWFISH", "1.3.6.1.4.1.3029.1.2");
		AddAlgorithm("CAMELLIA", "CAMELLIAWRAP");
		AddAlgorithm("CAMELLIA128", NttObjectIdentifiers.IdCamellia128Cbc, NttObjectIdentifiers.IdCamellia128Wrap);
		AddAlgorithm("CAMELLIA192", NttObjectIdentifiers.IdCamellia192Cbc, NttObjectIdentifiers.IdCamellia192Wrap);
		AddAlgorithm("CAMELLIA256", NttObjectIdentifiers.IdCamellia256Cbc, NttObjectIdentifiers.IdCamellia256Wrap);
		AddAlgorithm("CAST5", "1.2.840.113533.7.66.10");
		AddAlgorithm("CAST6");
		AddAlgorithm("CHACHA");
		AddAlgorithm("CHACHA7539", "CHACHA20", "CHACHA20-POLY1305", PkcsObjectIdentifiers.IdAlgAeadChaCha20Poly1305);
		AddAlgorithm("DES", OiwObjectIdentifiers.DesCbc, OiwObjectIdentifiers.DesCfb, OiwObjectIdentifiers.DesEcb, OiwObjectIdentifiers.DesOfb);
		AddAlgorithm("DESEDE", "DESEDEWRAP", "TDEA", OiwObjectIdentifiers.DesEde, PkcsObjectIdentifiers.IdAlgCms3DesWrap);
		AddAlgorithm("DESEDE3", PkcsObjectIdentifiers.DesEde3Cbc);
		AddAlgorithm("GOST28147", "GOST", "GOST-28147", CryptoProObjectIdentifiers.GostR28147Cbc);
		AddAlgorithm("HC128");
		AddAlgorithm("HC256");
		AddAlgorithm("IDEA", "1.3.6.1.4.1.188.7.1.1.2");
		AddAlgorithm("NOEKEON");
		AddAlgorithm("RC2", PkcsObjectIdentifiers.RC2Cbc, PkcsObjectIdentifiers.IdAlgCmsRC2Wrap);
		AddAlgorithm("RC4", "ARC4", "1.2.840.113549.3.4");
		AddAlgorithm("RC5", "RC5-32");
		AddAlgorithm("RC5-64");
		AddAlgorithm("RC6");
		AddAlgorithm("RIJNDAEL");
		AddAlgorithm("SALSA20");
		AddAlgorithm("SEED", KisaObjectIdentifiers.IdNpkiAppCmsSeedWrap, KisaObjectIdentifiers.IdSeedCbc);
		AddAlgorithm("SERPENT");
		AddAlgorithm("SKIPJACK");
		AddAlgorithm("SM4");
		AddAlgorithm("TEA");
		AddAlgorithm("THREEFISH-256");
		AddAlgorithm("THREEFISH-512");
		AddAlgorithm("THREEFISH-1024");
		AddAlgorithm("TNEPRES");
		AddAlgorithm("TWOFISH");
		AddAlgorithm("VMPC");
		AddAlgorithm("VMPC-KSA3");
		AddAlgorithm("XTEA");
		AddBasicIVSizeEntries(8, "BLOWFISH", "CHACHA", "DES", "DESEDE", "DESEDE3", "SALSA20");
		AddBasicIVSizeEntries(12, "CHACHA7539");
		AddBasicIVSizeEntries(16, "AES", "AES128", "AES192", "AES256", "ARIA", "ARIA128", "ARIA192", "ARIA256", "CAMELLIA", "CAMELLIA128", "CAMELLIA192", "CAMELLIA256", "NOEKEON", "SEED", "SM4");
	}

	private static void AddAlgorithm(string canonicalName, params object[] aliases)
	{
		algorithms[canonicalName] = canonicalName;
		foreach (object obj in aliases)
		{
			algorithms[obj.ToString()] = canonicalName;
		}
	}

	private static void AddBasicIVSizeEntries(int size, params string[] algorithms)
	{
		foreach (string key in algorithms)
		{
			basicIVSizes.Add(key, size);
		}
	}

	public static string GetCanonicalAlgorithmName(string algorithm)
	{
		return (string)algorithms[Platform.ToUpperInvariant(algorithm)];
	}

	public static KeyParameter CreateKeyParameter(DerObjectIdentifier algOid, byte[] keyBytes)
	{
		return CreateKeyParameter(algOid.Id, keyBytes, 0, keyBytes.Length);
	}

	public static KeyParameter CreateKeyParameter(string algorithm, byte[] keyBytes)
	{
		return CreateKeyParameter(algorithm, keyBytes, 0, keyBytes.Length);
	}

	public static KeyParameter CreateKeyParameter(DerObjectIdentifier algOid, byte[] keyBytes, int offset, int length)
	{
		return CreateKeyParameter(algOid.Id, keyBytes, offset, length);
	}

	public static KeyParameter CreateKeyParameter(string algorithm, byte[] keyBytes, int offset, int length)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		string canonicalAlgorithmName = GetCanonicalAlgorithmName(algorithm);
		if (canonicalAlgorithmName == null)
		{
			throw new SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
		}
		switch (canonicalAlgorithmName)
		{
		case "DES":
			return new DesParameters(keyBytes, offset, length);
		case "RC2":
			return new RC2Parameters(keyBytes, offset, length);
		default:
			return new KeyParameter(keyBytes, offset, length);
		case "DESEDE":
		case "DESEDE3":
			return new DesEdeParameters(keyBytes, offset, length);
		}
	}

	public static ICipherParameters GetCipherParameters(DerObjectIdentifier algOid, ICipherParameters key, Asn1Object asn1Params)
	{
		return GetCipherParameters(algOid.Id, key, asn1Params);
	}

	public static ICipherParameters GetCipherParameters(string algorithm, ICipherParameters key, Asn1Object asn1Params)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		string canonicalAlgorithmName = GetCanonicalAlgorithmName(algorithm);
		if (canonicalAlgorithmName == null)
		{
			throw new SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
		}
		byte[] array = null;
		try
		{
			if (FindBasicIVSize(canonicalAlgorithmName) == -1)
			{
				switch (canonicalAlgorithmName)
				{
				default:
					goto end_IL_0030;
				case "CAST5":
					array = Cast5CbcParameters.GetInstance(asn1Params).GetIV();
					goto end_IL_0030;
				case "IDEA":
					array = IdeaCbcPar.GetInstance(asn1Params).GetIV();
					goto end_IL_0030;
				case "RC2":
					array = RC2CbcParameter.GetInstance(asn1Params).GetIV();
					goto end_IL_0030;
				case "RIJNDAEL":
				case "SKIPJACK":
				case "TWOFISH":
					break;
				}
			}
			array = ((Asn1OctetString)asn1Params).GetOctets();
			end_IL_0030:;
		}
		catch (Exception innerException)
		{
			throw new ArgumentException("Could not process ASN.1 parameters", innerException);
		}
		if (array == null)
		{
			throw new SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
		}
		return new ParametersWithIV(key, array);
	}

	public static Asn1Encodable GenerateParameters(DerObjectIdentifier algID, SecureRandom random)
	{
		return GenerateParameters(algID.Id, random);
	}

	public static Asn1Encodable GenerateParameters(string algorithm, SecureRandom random)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		string canonicalAlgorithmName = GetCanonicalAlgorithmName(algorithm);
		if (canonicalAlgorithmName == null)
		{
			throw new SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
		}
		int num = FindBasicIVSize(canonicalAlgorithmName);
		if (num != -1)
		{
			return CreateIVOctetString(random, num);
		}
		return canonicalAlgorithmName switch
		{
			"CAST5" => new Cast5CbcParameters(CreateIV(random, 8), 128), 
			"IDEA" => new IdeaCbcPar(CreateIV(random, 8)), 
			"RC2" => new RC2CbcParameter(CreateIV(random, 8)), 
			_ => throw new SecurityUtilityException("Algorithm " + algorithm + " not recognised."), 
		};
	}

	public static ICipherParameters WithRandom(ICipherParameters cp, SecureRandom random)
	{
		if (random != null)
		{
			cp = new ParametersWithRandom(cp, random);
		}
		return cp;
	}

	private static Asn1OctetString CreateIVOctetString(SecureRandom random, int ivLength)
	{
		return new DerOctetString(CreateIV(random, ivLength));
	}

	private static byte[] CreateIV(SecureRandom random, int ivLength)
	{
		return SecureRandom.GetNextBytes(random, ivLength);
	}

	private static int FindBasicIVSize(string canonicalName)
	{
		if (!basicIVSizes.Contains(canonicalName))
		{
			return -1;
		}
		return (int)basicIVSizes[canonicalName];
	}
}
