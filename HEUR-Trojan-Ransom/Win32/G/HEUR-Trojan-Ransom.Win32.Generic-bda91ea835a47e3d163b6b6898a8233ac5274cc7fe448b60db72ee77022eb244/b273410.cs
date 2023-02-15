using System;

internal struct b273410<T> : Interface2
{
	private readonly T gparam_0;

	public b273410(T gparam_1)
	{
		gparam_0 = gparam_1;
	}

	public object imethod_0()
	{
		return gparam_0;
	}

	public Type imethod_1()
	{
		return typeof(T);
	}

	public Interface2 a2e6a035()
	{
		return new global::b273410<T>(gparam_0);
	}
}
