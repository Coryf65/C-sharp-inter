namespace DemoLib;

/// <summary>
/// Example of using a constructor with a Customer
/// </summary>
public class Customer
{
	public string Name;
	public int Age;
	public List<Order> Orders;

	public Customer()
	{
		Orders = new List<Order>();
		Promote();
	}

	public Customer(string name) : this()
	{
		Name = name;
	}

	// Overloading the Constructor
	// Allows us to have options
	public Customer(string name, int age) : this(name)
	{
		Age = age;
	}

	public void PrintCustomer()
	{
		Console.WriteLine($"Customer, Name: '{Name}' Age: '{Age}'");
	}

	public void Promote()
	{
		var calculator = new RateCalculator();
		var rating = calculator.CalculateRating();

		if (rating <= 50)
			Console.WriteLine("Tier 1");
		else
			Console.WriteLine("Tier 2");
	}	
}