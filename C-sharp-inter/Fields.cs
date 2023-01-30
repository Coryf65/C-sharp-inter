using DemoLib;

namespace C_sharp_inter;

/// <summary>
/// Notes on fields
/// </summary>
public class Fields
{
	// a variable declared at the class level
	List<string> strings = new();

	// 
}

public class Consumer
{
	public int Id;
	public string Name;
	public List<Order> Orders = new List<Order>(); // could init here

	public Consumer()
	{
		// or init here
	}

	public void Promote()
	{
		// ...

	}
}