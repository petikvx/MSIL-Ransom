using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Fo9n;
using Gg2;
using Ho4;
using Jt82;
using c6C;
using d7Y;
using t0N;
using x3Z;

namespace Xb3;

public class j8K : DbContext
{
	public virtual DbSet<z1B6> bridge { get; set; }

	public virtual DbSet<Pj8f> bridgehistory { get; set; }

	public virtual DbSet<Ec4> bridgenote { get; set; }

	public virtual DbSet<Xw2> bridgenotehistory { get; set; }

	public virtual DbSet<Za5> inspection { get; set; }

	public virtual DbSet<y3C> inspectionexcel { get; set; }

	public virtual DbSet<r3Y> inspectionhistory { get; set; }

	public virtual DbSet<Jw6> bridgemanagementview { get; set; }

	public j8K()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Li5(DbModelBuilder y2L)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
