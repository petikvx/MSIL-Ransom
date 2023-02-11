using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Ke7q;
using Tn9;
using Xw5;
using g0R6;
using i9BG;
using m0Z;
using m4E;
using t2Q;

namespace m0BW;

public class i6C1 : DbContext
{
	public virtual DbSet<c7P9> bridge { get; set; }

	public virtual DbSet<Po43> bridgehistory { get; set; }

	public virtual DbSet<t8X> bridgenote { get; set; }

	public virtual DbSet<x4D> bridgenotehistory { get; set; }

	public virtual DbSet<n2K> inspection { get; set; }

	public virtual DbSet<Gb6> inspectionexcel { get; set; }

	public virtual DbSet<Zr7> inspectionhistory { get; set; }

	public virtual DbSet<Hn20> bridgemanagementview { get; set; }

	public i6C1()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Wz3r(DbModelBuilder m4H8)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
