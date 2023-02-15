using System;
using System.Collections.Generic;

namespace CommandLine;

public static class ParserResultExtensions
{
	public static ParserResult<T> WithParsed<T>(this ParserResult<T> result, Action<T> action)
	{
		if (result is Parsed<T> parsed)
		{
			action(parsed.Value);
		}
		return result;
	}

	public static ParserResult<object> WithParsed<T>(this ParserResult<object> result, Action<T> action)
	{
		if (result is Parsed<object> parsed && parsed.Value is T)
		{
			action((T)parsed.Value);
		}
		return result;
	}

	public static ParserResult<T> WithNotParsed<T>(this ParserResult<T> result, Action<IEnumerable<Error>> action)
	{
		if (result is NotParsed<T> notParsed)
		{
			action(notParsed.Errors);
		}
		return result;
	}

	public static TResult MapResult<TSource, TResult>(this ParserResult<TSource> result, Func<TSource, TResult> parsedFunc, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<TSource> parsed)
		{
			return parsedFunc(parsed.Value);
		}
		return notParsedFunc(((NotParsed<TSource>)result).Errors);
	}

	public static TResult MapResult<T1, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			if (parsed.Value is T11)
			{
				return parsedFunc11((T11)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			if (parsed.Value is T11)
			{
				return parsedFunc11((T11)parsed.Value);
			}
			if (parsed.Value is T12)
			{
				return parsedFunc12((T12)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			if (parsed.Value is T11)
			{
				return parsedFunc11((T11)parsed.Value);
			}
			if (parsed.Value is T12)
			{
				return parsedFunc12((T12)parsed.Value);
			}
			if (parsed.Value is T13)
			{
				return parsedFunc13((T13)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<T14, TResult> parsedFunc14, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			if (parsed.Value is T11)
			{
				return parsedFunc11((T11)parsed.Value);
			}
			if (parsed.Value is T12)
			{
				return parsedFunc12((T12)parsed.Value);
			}
			if (parsed.Value is T13)
			{
				return parsedFunc13((T13)parsed.Value);
			}
			if (parsed.Value is T14)
			{
				return parsedFunc14((T14)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<T14, TResult> parsedFunc14, Func<T15, TResult> parsedFunc15, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			if (parsed.Value is T11)
			{
				return parsedFunc11((T11)parsed.Value);
			}
			if (parsed.Value is T12)
			{
				return parsedFunc12((T12)parsed.Value);
			}
			if (parsed.Value is T13)
			{
				return parsedFunc13((T13)parsed.Value);
			}
			if (parsed.Value is T14)
			{
				return parsedFunc14((T14)parsed.Value);
			}
			if (parsed.Value is T15)
			{
				return parsedFunc15((T15)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}

	public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<T14, TResult> parsedFunc14, Func<T15, TResult> parsedFunc15, Func<T16, TResult> parsedFunc16, Func<IEnumerable<Error>, TResult> notParsedFunc)
	{
		if (result is Parsed<object> parsed)
		{
			if (parsed.Value is T1)
			{
				return parsedFunc1((T1)parsed.Value);
			}
			if (parsed.Value is T2)
			{
				return parsedFunc2((T2)parsed.Value);
			}
			if (parsed.Value is T3)
			{
				return parsedFunc3((T3)parsed.Value);
			}
			if (parsed.Value is T4)
			{
				return parsedFunc4((T4)parsed.Value);
			}
			if (parsed.Value is T5)
			{
				return parsedFunc5((T5)parsed.Value);
			}
			if (parsed.Value is T6)
			{
				return parsedFunc6((T6)parsed.Value);
			}
			if (parsed.Value is T7)
			{
				return parsedFunc7((T7)parsed.Value);
			}
			if (parsed.Value is T8)
			{
				return parsedFunc8((T8)parsed.Value);
			}
			if (parsed.Value is T9)
			{
				return parsedFunc9((T9)parsed.Value);
			}
			if (parsed.Value is T10)
			{
				return parsedFunc10((T10)parsed.Value);
			}
			if (parsed.Value is T11)
			{
				return parsedFunc11((T11)parsed.Value);
			}
			if (parsed.Value is T12)
			{
				return parsedFunc12((T12)parsed.Value);
			}
			if (parsed.Value is T13)
			{
				return parsedFunc13((T13)parsed.Value);
			}
			if (parsed.Value is T14)
			{
				return parsedFunc14((T14)parsed.Value);
			}
			if (parsed.Value is T15)
			{
				return parsedFunc15((T15)parsed.Value);
			}
			if (parsed.Value is T16)
			{
				return parsedFunc16((T16)parsed.Value);
			}
			throw new InvalidOperationException();
		}
		return notParsedFunc(((NotParsed<object>)result).Errors);
	}
}
