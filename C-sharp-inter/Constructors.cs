using DemoLib;

namespace C_sharp_inter;

internal class Constructors
{
	public Constructors()
	{
		// running on init
		Customer customer = new("Jonna", 30);

		customer.PrintCustomer();
	}
}