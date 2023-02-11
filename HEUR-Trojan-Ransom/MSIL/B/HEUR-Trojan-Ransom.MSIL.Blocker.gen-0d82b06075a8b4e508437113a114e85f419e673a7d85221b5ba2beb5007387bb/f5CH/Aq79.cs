using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Bm6;
using Mc91;
using Pg1;
using Py40;
using a6Z2;
using f0XF;
using k9Z;
using z8WL;

namespace f5CH;

public class Aq79 : DbContext
{
	public virtual DbSet<Km71> bridge { get; set; }

	public virtual DbSet<r2H1> bridgehistory { get; set; }

	public virtual DbSet<Rj53> bridgenote { get; set; }

	public virtual DbSet<Do7z> bridgenotehistory { get; set; }

	public virtual DbSet<Hs8> inspection { get; set; }

	public virtual DbSet<m3A> inspectionexcel { get; set; }

	public virtual DbSet<b2T> inspectionhistory { get; set; }

	public virtual DbSet<De24> bridgemanagementview { get; set; }

	public Aq79()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Gw68(DbModelBuilder f2Y6)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
