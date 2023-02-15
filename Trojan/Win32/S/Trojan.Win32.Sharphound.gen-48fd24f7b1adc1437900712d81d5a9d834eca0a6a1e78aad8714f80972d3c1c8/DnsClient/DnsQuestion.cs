using System;

namespace DnsClient;

public class DnsQuestion
{
	public DnsString QueryName { get; }

	public QueryClass QuestionClass { get; }

	public QueryType QuestionType { get; }

	public DnsQuestion(string query, QueryType questionType, QueryClass questionClass)
		: this(DnsString.Parse(query), questionType, questionClass)
	{
	}

	public DnsQuestion(DnsString query, QueryType questionType, QueryClass questionClass)
	{
		QueryName = query ?? throw new ArgumentNullException("query");
		QuestionType = questionType;
		QuestionClass = questionClass;
	}

	public override string ToString()
	{
		return ToString(0);
	}

	public string ToString(int offset = -32)
	{
		return string.Format("{0," + offset + "} \t{1} \t{2}", QueryName.Original, QuestionClass, QuestionType);
	}
}
