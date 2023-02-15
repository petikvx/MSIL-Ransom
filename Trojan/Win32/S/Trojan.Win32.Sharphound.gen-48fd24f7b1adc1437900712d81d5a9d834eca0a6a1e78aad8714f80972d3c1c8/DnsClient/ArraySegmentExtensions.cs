using System;

namespace DnsClient;

internal static class ArraySegmentExtensions
{
	public static ArraySegment<T> SubArray<T>(this ArraySegment<T> array, int startIndex, int length)
	{
		return new ArraySegment<T>(array.Array, array.Offset + startIndex, length);
	}

	public static ArraySegment<T> SubArrayFromOriginal<T>(this ArraySegment<T> array, int startIndex)
	{
		return new ArraySegment<T>(array.Array, startIndex, array.Array!.Length - startIndex);
	}
}
