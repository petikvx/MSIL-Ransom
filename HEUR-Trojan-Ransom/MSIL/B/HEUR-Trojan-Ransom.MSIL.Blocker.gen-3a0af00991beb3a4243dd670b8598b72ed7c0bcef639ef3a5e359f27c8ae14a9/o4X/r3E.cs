using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Bo0;
using Ea5;
using Pn27;
using Xm80;
using d0C;
using n4RH;
using p8CM;
using x8M2;

namespace o4X;

public class r3E : DbContext
{
	public virtual DbSet<p1W4> bridge { get; set; }

	public virtual DbSet<f5H> bridgehistory { get; set; }

	public virtual DbSet<b2FM> bridgenote { get; set; }

	public virtual DbSet<j7BJ> bridgenotehistory { get; set; }

	public virtual DbSet<Hb5> inspection { get; set; }

	public virtual DbSet<Xw53> inspectionexcel { get; set; }

	public virtual DbSet<m9LW> inspectionhistory { get; set; }

	public virtual DbSet<Fc7> bridgemanagementview { get; set; }

	public r3E()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void y9D(DbModelBuilder St5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
