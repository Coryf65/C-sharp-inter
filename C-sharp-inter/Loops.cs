namespace C_sharp_inter;

internal class Loops
{
	public Loops()
	{		
		Console.WriteLine("For");
		Console.WriteLine("When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:");

		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine(i);
		}

		Console.WriteLine("While");
		Console.WriteLine("The while loop loops through a block of code as long as a specified condition is True:");

		int a = 0;

		while (a < 5)
		{
			Console.WriteLine(a);
			a++;
		}


		Console.WriteLine("Do While");
		Console.WriteLine("The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.");

		int b = 0;
		do
		{
			Console.WriteLine(b);
			b++;
		}
		while (b < 5);


		Console.WriteLine("For Each");
		Console.WriteLine("There is also a foreach loop, which is used exclusively to loop through elements in an array:");

		string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
		foreach (string i in cars)
		{
			Console.WriteLine(i);
		}

	}
}