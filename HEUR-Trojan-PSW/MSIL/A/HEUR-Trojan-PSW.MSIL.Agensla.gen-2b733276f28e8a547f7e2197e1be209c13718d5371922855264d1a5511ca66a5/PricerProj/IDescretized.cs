namespace PricerProj;

public interface IDescretized
{
	double mean { get; set; }

	double sigma { get; set; }

	double deltaT { get; set; }

	double NextPrice(double currentPrice, double randomMove);
}
