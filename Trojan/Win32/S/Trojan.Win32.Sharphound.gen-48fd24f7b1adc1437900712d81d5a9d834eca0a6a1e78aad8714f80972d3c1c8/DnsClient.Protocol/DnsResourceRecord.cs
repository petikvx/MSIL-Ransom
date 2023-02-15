using System;

namespace DnsClient.Protocol;

public abstract class DnsResourceRecord : ResourceRecordInfo
{
	public DnsResourceRecord(ResourceRecordInfo info)
	{
		object obj;
		if (info == null)
		{
			obj = null;
		}
		else
		{
			obj = info.DomainName;
			if (obj != null)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				ResourceRecordType recordType = info.RecordType;
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				QueryClass recordClass = info.RecordClass;
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				int initialTimeToLive = info.InitialTimeToLive;
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				base._002Ector((DnsString)obj, recordType, recordClass, initialTimeToLive, info.RawDataLength);
				return;
			}
		}
		throw new ArgumentNullException("info");
	}

	public override string ToString()
	{
		return ToString();
	}

	public virtual string ToString(int offset = 0)
	{
		return string.Format("{0," + offset + "}{1} \t{2} \t{3} \t{4}", base.DomainName, base.TimeToLive, base.RecordClass, base.RecordType, RecordToString());
	}

	private protected abstract string RecordToString();
}
