using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Be0c;
using By8p;
using Hq2;
using Nj3;
using d1Z;
using e9X;
using n3A;
using n8Z7;

namespace b8CW;

public class y7E1 : DbContext
{
	public virtual DbSet<a1C6> bridge { get; set; }

	public virtual DbSet<d8H3> bridgehistory { get; set; }

	public virtual DbSet<Ez7> bridgenote { get; set; }

	public virtual DbSet<Ez3> bridgenotehistory { get; set; }

	public virtual DbSet<d0J> inspection { get; set; }

	public virtual DbSet<Rd6> inspectionexcel { get; set; }

	public virtual DbSet<Fa0> inspectionhistory { get; set; }

	public virtual DbSet<b6J1> bridgemanagementview { get; set; }

	public y7E1()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Zi4k(DbModelBuilder Az91)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
