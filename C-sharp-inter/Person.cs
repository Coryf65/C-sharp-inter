namespace C_sharp_inter;

public class Person
{
	public string Name;

	public void Introduce(string to)
	{
		Console.WriteLine($"Hello {to}, I am {Name}");
	}

	public Person Parse(string text)
	{
		Person person = new()
		{
			Name = text
		};

		return person;
	}
}