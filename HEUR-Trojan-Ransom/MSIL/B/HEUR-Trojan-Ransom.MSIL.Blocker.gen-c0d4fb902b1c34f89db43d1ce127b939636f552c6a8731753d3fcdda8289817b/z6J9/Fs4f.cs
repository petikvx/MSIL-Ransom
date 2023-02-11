using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Ci45;
using Cj5;
using Dz84;
using d4FE;
using m0DS;
using m3T1;
using o8LN;
using x1G6;

namespace z6J9;

public class Fs4f : DbContext
{
	public virtual DbSet<Ad27> bridge { get; set; }

	public virtual DbSet<y0H> bridgehistory { get; set; }

	public virtual DbSet<y6XJ> bridgenote { get; set; }

	public virtual DbSet<Ea6y> bridgenotehistory { get; set; }

	public virtual DbSet<q6E7> inspection { get; set; }

	public virtual DbSet<k3BG> inspectionexcel { get; set; }

	public virtual DbSet<Py5x> inspectionhistory { get; set; }

	public virtual DbSet<m0JY> bridgemanagementview { get; set; }

	public Fs4f()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void q0PD(DbModelBuilder k1LG)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
