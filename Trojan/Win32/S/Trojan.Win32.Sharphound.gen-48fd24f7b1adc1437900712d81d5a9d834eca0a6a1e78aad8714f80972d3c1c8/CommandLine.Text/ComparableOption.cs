namespace CommandLine.Text;

public struct ComparableOption
{
	public bool Required;

	public bool IsOption;

	public bool IsValue;

	public string LongName;

	public string ShortName;

	public int Index;
}
