namespace System.Data.SQLite;

public struct CollationSequence
{
	public string Name;

	public CollationTypeEnum Type;

	public CollationEncodingEnum Encoding;

	internal SQLiteFunction _func;

	public int Compare(string s1, string s2)
	{
		return _func._base.ContextCollateCompare(Encoding, _func._context, s1, s2);
	}

	public int Compare(char[] c1, char[] c2)
	{
		return _func._base.ContextCollateCompare(Encoding, _func._context, c1, c2);
	}
}
