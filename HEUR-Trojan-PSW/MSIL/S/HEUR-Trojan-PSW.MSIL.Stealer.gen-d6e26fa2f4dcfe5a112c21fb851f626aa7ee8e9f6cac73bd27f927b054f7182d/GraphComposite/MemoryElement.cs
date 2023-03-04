namespace GraphComposite;

public class MemoryElement
{
	public string Name;

	public string type;

	public int Base;

	public int size;

	public MemoryElement(string n, string t, int b, int s)
	{
		Name = n;
		type = t;
		Base = b;
		size = s;
	}
}
