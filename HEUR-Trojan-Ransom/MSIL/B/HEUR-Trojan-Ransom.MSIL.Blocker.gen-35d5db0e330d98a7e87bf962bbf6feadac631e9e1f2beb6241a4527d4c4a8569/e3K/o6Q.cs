using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Ad32;
using Hb29;
using Mf2c;
using Rp6o;
using f3D;
using m6G;
using m9JK;
using r3E;

namespace e3K;

public class o6Q : DbContext
{
	public virtual DbSet<m9A> bridge { get; set; }

	public virtual DbSet<Eg1> bridgehistory { get; set; }

	public virtual DbSet<Dp5d> bridgenote { get; set; }

	public virtual DbSet<Rg1c> bridgenotehistory { get; set; }

	public virtual DbSet<Jp1y> inspection { get; set; }

	public virtual DbSet<m1CE> inspectionexcel { get; set; }

	public virtual DbSet<Bj1y> inspectionhistory { get; set; }

	public virtual DbSet<Ci4> bridgemanagementview { get; set; }

	public o6Q()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Yo2(DbModelBuilder b1H)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
