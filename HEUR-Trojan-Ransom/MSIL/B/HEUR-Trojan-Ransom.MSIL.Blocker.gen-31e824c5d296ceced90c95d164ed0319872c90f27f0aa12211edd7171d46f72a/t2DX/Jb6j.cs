using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Ag4q;
using Bf85;
using Fn62;
using Fs1r;
using Wa50;
using Wg56;
using Zx69;
using b5CJ;

namespace t2DX;

public class Jb6j : DbContext
{
	public virtual DbSet<Dc8p> bridge { get; set; }

	public virtual DbSet<o3K1> bridgehistory { get; set; }

	public virtual DbSet<m9EW> bridgenote { get; set; }

	public virtual DbSet<Mi89> bridgenotehistory { get; set; }

	public virtual DbSet<Rw1j> inspection { get; set; }

	public virtual DbSet<k0ZR> inspectionexcel { get; set; }

	public virtual DbSet<f6XZ> inspectionhistory { get; set; }

	public virtual DbSet<m3TX> bridgemanagementview { get; set; }

	public Jb6j()
		: base("name=bridgemanagementEntities")
	{
	}

	protected override void w0RX(DbModelBuilder d1R3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new UnintentionalCodeFirstException();
	}
}
