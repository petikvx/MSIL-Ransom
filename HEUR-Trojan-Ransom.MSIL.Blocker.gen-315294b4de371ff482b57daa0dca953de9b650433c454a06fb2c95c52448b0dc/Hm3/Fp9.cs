using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Dk56;
using Jp4;
using Po7;
using a5A1;
using c7AC;
using d0Q4;
using k7R;
using q5S;

namespace Hm3;

public class Fp9 : DbContext
{
	public virtual DbSet<Zo4> bridge { get; set; }

	public virtual DbSet<i6N> bridgehistory { get; set; }

	public virtual DbSet<w6A> bridgenote { get; set; }

	public virtual DbSet<Wg31> bridgenotehistory { get; set; }

	public virtual DbSet<x6NK> inspection { get; set; }

	public virtual DbSet<r0QH> inspectionexcel { get; set; }

	public virtual DbSet<Cy12> inspectionhistory { get; set; }

	public virtual DbSet<a9D> bridgemanagementview { get; set; }

	public Fp9()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void Cz1(DbModelBuilder w9S)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
