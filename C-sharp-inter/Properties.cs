using C_sharp_inter;

internal class Properties
{
	public Properties()
	{
		Console.WriteLine("It's best to use auto props like so: \n  public DateTime BirthDate { get; set; }");
		Console.WriteLine("Yu could manually do the implementation yourself: \n  public DateTime BirthDate { get { return _birthdate; } set { _birthdate = value; } }");

		Console.WriteLine("\n");
		Person jonna = new(new DateTime(1991, 1, 1));
		// jonna.BirthDate = new DateTime(1991, 1, 1); // Now we cannot set the birthdate outside the init

		Console.WriteLine($"Jonnas age: '{jonna.Age}' by only setting birthdate using '{jonna.BirthDate.ToString("d")}'");
	}
}

public class User
{
	// hiding a field in encapsulation
	private DateTime _birthdate;

	// the way to use this, an auto implemented Property
	public DateTime BirthDate { get; set; }

	// a way to manually set with a property
	public DateTime BirthDate2 { get { return _birthdate; } set { _birthdate = value; } }
}