using System;

namespace Tf26;

public class Hm95
{
	public int id { get; set; }

	public DateTime recorddate { get; set; }

	public string recordprogram { get; set; }

	public string recorduserid { get; set; }

	public bool recordvalid { get; set; }

	public string repair { get; set; }

	public int? nextinspection { get; set; }

	public string inspectionway { get; set; }

	public string memo { get; set; }
}