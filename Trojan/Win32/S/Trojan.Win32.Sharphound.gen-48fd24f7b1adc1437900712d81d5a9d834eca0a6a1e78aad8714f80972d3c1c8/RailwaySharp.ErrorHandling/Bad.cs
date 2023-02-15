using System.Collections.Generic;

namespace RailwaySharp.ErrorHandling;

internal sealed class Bad<TSuccess, TMessage> : Result<TSuccess, TMessage>
{
	private readonly IEnumerable<TMessage> messages;

	public IEnumerable<TMessage> Messages => messages;

	public Bad(IEnumerable<TMessage> messages)
		: base(ResultType.Bad)
	{
		this.messages = messages;
	}
}
