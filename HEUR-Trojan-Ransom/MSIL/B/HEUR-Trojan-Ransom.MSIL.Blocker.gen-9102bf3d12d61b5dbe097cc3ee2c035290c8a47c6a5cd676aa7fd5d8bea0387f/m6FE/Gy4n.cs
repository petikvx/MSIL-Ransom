using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Dx12;
using Gd15;
using Hs9o;
using So08;
using g3Q7;
using i1DE;
using j1ET;
using x4Q7;

namespace m6FE;

public class Gy4n : DbContext
{
	public virtual DbSet<s1X8> bridge { get; set; }

	public virtual DbSet<k4L8> bridgehistory { get; set; }

	public virtual DbSet<Sw50> bridgenote { get; set; }

	public virtual DbSet<Wb97> bridgenotehistory { get; set; }

	public virtual DbSet<Me2k> inspection { get; set; }

	public virtual DbSet<c1BQ> inspectionexcel { get; set; }

	public virtual DbSet<Cm0d> inspectionhistory { get; set; }

	public virtual DbSet<i0ZB> bridgemanagementview { get; set; }

	public Gy4n()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Jc6n(DbModelBuilder s8T4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
