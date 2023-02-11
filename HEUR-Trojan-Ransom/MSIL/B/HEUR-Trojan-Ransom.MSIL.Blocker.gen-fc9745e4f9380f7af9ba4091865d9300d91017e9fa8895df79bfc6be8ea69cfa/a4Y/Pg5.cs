using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Gg7;
using Gq49;
using Kt8a;
using Pc93;
using Sx4;
using Zq6;
using r0Z7;
using s6HP;

namespace a4Y;

public class Pg5 : DbContext
{
	public virtual DbSet<Gf59> bridge { get; set; }

	public virtual DbSet<a4A> bridgehistory { get; set; }

	public virtual DbSet<e4L> bridgenote { get; set; }

	public virtual DbSet<b3P> bridgenotehistory { get; set; }

	public virtual DbSet<c2XF> inspection { get; set; }

	public virtual DbSet<p8CL> inspectionexcel { get; set; }

	public virtual DbSet<Dj2o> inspectionhistory { get; set; }

	public virtual DbSet<Ns8f> bridgemanagementview { get; set; }

	public Pg5()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Yr7(DbModelBuilder Zw1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
