namespace C_sharp_inter;

public class Methods
{
	public Methods()
	{
		// Signatures
		Console.WriteLine("__ Signatures __");
		Console.WriteLine("The signature is the 'Name', 'Number' and 'Types' of the parameters");

		// Overloading
		Console.WriteLine("\n__ Overloading __");
		Console.WriteLine("void Move(int x, int y) and overloading with void Move(int x, int y, int speed)");

		// Params
		Console.WriteLine("\n__ Params __");
		Console.WriteLine("Example of 'params' adding an array of (1, 10, 50, 100, 25)");
		int answer = Add(new int[] { 1, 10, 50, 100, 25 });
		Console.WriteLine($"total: '{answer}'");
		Console.WriteLine("or just passing in (1, 10, 50, 100, 25)");
		answer = Add(1, 10, 50, 100, 25 );
		Console.WriteLine($"total: '{answer}'");

		// Ref
		Console.WriteLine("\n__ Ref __");
		var a = 1;
		Console.WriteLine($"value of a '{a}'");
		RefDemo(a);
		Console.WriteLine("running the function the a is out of scope");
		Console.WriteLine($"value of a '{a}'");

		Console.WriteLine($"now using the ref we are changing that a value'");
		RefDemo2(ref a);
		Console.WriteLine($"value of a '{a}'");

		// Out
		Console.WriteLine("\n__ Out __");
		int number;
		OutDemo(out number);
		Console.WriteLine($"Passing in a and getting the out {number}, should use a return type instead.");
	}

	/// Signature of Methods
	// The Name
	// The Number and Type of parameters
	public void Move(int x, int y)
	{

	}

	/// Method Overloading
	// Having a method with the same name but different signatures
	public void Move(int x, int y, int speed)
	{

	}

	// Params modifier
	// we could have an array as the param or use
	// We could add as many param as we want using ...
	public int Add(params int[] numbers)
	{
		int total = 0;

		foreach (int num in numbers)
		{
			total += num;
		}

		return total;
	}

	// Ref modifier
	// an example of using 'ref' try to avoid using it
	public void RefDemo(int a)
	{
		// out of scope will not modify
		a += 2;
	}

	// BUT if we add ref
	public void RefDemo2(ref int a)
	{
		a += 2;
	}

	// Out modifier
	void OutDemo(out int result)
	{
		result = 100;
	}
}