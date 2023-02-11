using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Le7;
using Mt27;
using Ss0b;
using Yn1g;
using Yq8;
using a2W;
using c7HW;
using k4CE;

namespace As4;

public class Lk0 : DbContext
{
	public virtual DbSet<Fp0s> bridge { get; set; }

	public virtual DbSet<Zb98> bridgehistory { get; set; }

	public virtual DbSet<s8R> bridgenote { get; set; }

	public virtual DbSet<Cm1> bridgenotehistory { get; set; }

	public virtual DbSet<c2A4> inspection { get; set; }

	public virtual DbSet<w7CK> inspectionexcel { get; set; }

	public virtual DbSet<z3SW> inspectionhistory { get; set; }

	public virtual DbSet<i5M> bridgemanagementview { get; set; }

	public Lk0()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void f3P(DbModelBuilder y2N)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
