using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SAITMCalculator;

public class calculation
{
	private double double_0;

	private double double_1;

	private double double_2;

	private double double_3;

	public calculation()
	{
		Class8.BpPkGHSz2q2OL();
		base._002Ector();
	}

	public object calculate(object first_value, object second_value, object symbol)
	{
		if (Operators.ConditionalCompareObjectEqual(symbol, (object)1, false))
		{
			double_2 = Conversion.Val(RuntimeHelpers.GetObjectValue(first_value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(second_value));
		}
		else if (Operators.ConditionalCompareObjectEqual(symbol, (object)2, false))
		{
			double_2 = Conversion.Val(RuntimeHelpers.GetObjectValue(first_value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(second_value));
		}
		else if (Operators.ConditionalCompareObjectEqual(symbol, (object)3, false))
		{
			double_2 = Conversion.Val(RuntimeHelpers.GetObjectValue(first_value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(second_value));
		}
		else if (Operators.ConditionalCompareObjectEqual(symbol, (object)4, false))
		{
			double_2 = Conversion.Val(RuntimeHelpers.GetObjectValue(first_value)) / Conversion.Val(RuntimeHelpers.GetObjectValue(second_value));
		}
		return double_2;
	}
}
