using System;
using System.Collections.Generic;

namespace RailwaySharp.ErrorHandling;

internal sealed class Ok<TSuccess, TMessage> : Result<TSuccess, TMessage>
{
	private readonly Tuple<TSuccess, IEnumerable<TMessage>> value;

	public TSuccess Success => value.Item1;

	public IEnumerable<TMessage> Messages => value.Item2;

	public Ok(TSuccess success, IEnumerable<TMessage> messages)
		: base(ResultType.Ok)
	{
		value = Tuple.Create(success, messages);
	}
}
