using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using e7Q0;
using g2M;
using i5W;
using j1P;
using m2L;
using o2YN;
using q8Z;
using s5Y;

namespace r7C;

public class Jm9 : DbContext
{
	public virtual DbSet<Dq6g> bridge { get; set; }

	public virtual DbSet<Sw37> bridgehistory { get; set; }

	public virtual DbSet<Fm6> bridgenote { get; set; }

	public virtual DbSet<Qm5> bridgenotehistory { get; set; }

	public virtual DbSet<a3M> inspection { get; set; }

	public virtual DbSet<Gt0> inspectionexcel { get; set; }

	public virtual DbSet<Hg7> inspectionhistory { get; set; }

	public virtual DbSet<Hb9> bridgemanagementview { get; set; }

	public Jm9()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void t9W(DbModelBuilder Td3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
