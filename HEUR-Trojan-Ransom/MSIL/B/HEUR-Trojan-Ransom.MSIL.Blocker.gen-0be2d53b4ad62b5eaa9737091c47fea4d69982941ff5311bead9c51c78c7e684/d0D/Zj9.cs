using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Db9i;
using Tc1;
using Ty7;
using Wy9;
using b9M;
using r1PZ;
using t3D;
using z1A;

namespace d0D;

public class Zj9 : DbContext
{
	public virtual DbSet<p5N> bridge { get; set; }

	public virtual DbSet<Ke5> bridgehistory { get; set; }

	public virtual DbSet<Po6j> bridgenote { get; set; }

	public virtual DbSet<Fp48> bridgenotehistory { get; set; }

	public virtual DbSet<w2W> inspection { get; set; }

	public virtual DbSet<m2F> inspectionexcel { get; set; }

	public virtual DbSet<k5C> inspectionhistory { get; set; }

	public virtual DbSet<k1L> bridgemanagementview { get; set; }

	public Zj9()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Gz9(DbModelBuilder Pe9)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
