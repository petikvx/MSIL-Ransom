namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;

internal class FixedPointPreCompInfo : PreCompInfo
{
	protected ECPoint m_offset;

	protected ECLookupTable m_lookupTable;

	protected int m_width = -1;

	public virtual ECLookupTable LookupTable
	{
		get
		{
			return m_lookupTable;
		}
		set
		{
			m_lookupTable = value;
		}
	}

	public virtual ECPoint Offset
	{
		get
		{
			return m_offset;
		}
		set
		{
			m_offset = value;
		}
	}

	public virtual int Width
	{
		get
		{
			return m_width;
		}
		set
		{
			m_width = value;
		}
	}
}
