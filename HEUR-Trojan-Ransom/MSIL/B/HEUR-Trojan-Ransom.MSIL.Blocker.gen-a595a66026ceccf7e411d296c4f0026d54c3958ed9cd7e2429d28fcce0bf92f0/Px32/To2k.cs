using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Cw1p;
using Ft0n;
using Te4;
using Tf26;
using b4C;
using f7L3;
using g1S;
using x0S5;

namespace Px32;

public class To2k : DbContext
{
	public virtual DbSet<La60> bridge { get; set; }

	public virtual DbSet<Fp89> bridgehistory { get; set; }

	public virtual DbSet<Hm95> bridgenote { get; set; }

	public virtual DbSet<St6f> bridgenotehistory { get; set; }

	public virtual DbSet<Dg6> inspection { get; set; }

	public virtual DbSet<Py1> inspectionexcel { get; set; }

	public virtual DbSet<Ti0> inspectionhistory { get; set; }

	public virtual DbSet<x6A0> bridgemanagementview { get; set; }

	public To2k()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void c1AC(DbModelBuilder w0C3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
