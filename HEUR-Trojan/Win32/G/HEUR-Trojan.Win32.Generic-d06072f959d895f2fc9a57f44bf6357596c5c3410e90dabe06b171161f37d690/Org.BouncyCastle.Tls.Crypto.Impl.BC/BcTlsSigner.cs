using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public abstract class BcTlsSigner : TlsSigner
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly AsymmetricKeyParameter m_privateKey;

	protected BcTlsSigner(BcTlsCrypto crypto, AsymmetricKeyParameter privateKey)
	{
		if (crypto == null)
		{
			throw new ArgumentNullException("crypto");
		}
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (!privateKey.IsPrivate)
		{
			throw new ArgumentException("must be private", "privateKey");
		}
		m_crypto = crypto;
		m_privateKey = privateKey;
	}

	public abstract byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash);

	public virtual TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm)
	{
		return null;
	}
}
