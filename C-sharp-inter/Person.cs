namespace C_sharp_inter;

public class Person
{
	public string Name;
	public DateTime BirthDate { get; private set; } // setting the prop only in the ctor not changed after

	public Person(DateTime birthdate)
	{
		BirthDate = birthdate;
	}

	public int Age
	{
		get
		{
			var timespan = DateTime.Today - BirthDate;
			var years = timespan.Days / 365;
			return years;
		}
	}

	public void Introduce(string to)
	{
		Console.WriteLine($"Hello {to}, I am {Name}");
	}

	public Person Parse(string text)
	{
		Person person = new(new DateTime(1988, 1, 25))
		{
			Name = text
		};

		return person;
	}
}