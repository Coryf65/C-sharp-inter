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
}
