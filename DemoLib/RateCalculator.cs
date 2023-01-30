namespace DemoLib;

internal class RateCalculator
{
	// When using an implementation detail we don't want others places to be dependant on it.
	public int CalculateRating()
	{
		Random rng = new Random();

		return rng.Next(100);
	}
}
