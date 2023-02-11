using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Hs0;
using Nz4;
using Tt40;
using Yw7;
using k7H;
using n5G;
using o4C;
using t8FL;

namespace Gb2;

public class r6X : DbContext
{
	public virtual DbSet<x1Y3> bridge { get; set; }

	public virtual DbSet<k9W0> bridgehistory { get; set; }

	public virtual DbSet<f9N> bridgenote { get; set; }

	public virtual DbSet<Sg9> bridgenotehistory { get; set; }

	public virtual DbSet<o7Q> inspection { get; set; }

	public virtual DbSet<Yr0> inspectionexcel { get; set; }

	public virtual DbSet<Rn7> inspectionhistory { get; set; }

	public virtual DbSet<w1D> bridgemanagementview { get; set; }

	public r6X()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void s4P(DbModelBuilder Hz5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
