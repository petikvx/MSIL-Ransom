using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Ga2e;
using Kx0e;
using Mm7y;
using Pa3y;
using Wx2z;
using g0N;
using k3L2;
using m9N;

namespace f7C4;

public class Fr2b : DbContext
{
	public virtual DbSet<Ls5> bridge { get; set; }

	public virtual DbSet<w5S> bridgehistory { get; set; }

	public virtual DbSet<p3W9> bridgenote { get; set; }

	public virtual DbSet<a4D8> bridgenotehistory { get; set; }

	public virtual DbSet<Ea63> inspection { get; set; }

	public virtual DbSet<y2P0> inspectionexcel { get; set; }

	public virtual DbSet<s9YN> inspectionhistory { get; set; }

	public virtual DbSet<Fj82> bridgemanagementview { get; set; }

	public Fr2b()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void k8B0(DbModelBuilder r4D9)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
