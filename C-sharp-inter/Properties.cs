using C_sharp_inter;

internal class Properties
{
	public Properties()
	{
		Console.WriteLine("It's best to use auto props like so: \n  public DateTime BirthDate { get; set; }");
		Console.WriteLine("You could manually do the implementation yourself: \n  public DateTime BirthDate { get { return _birthdate; } set { _birthdate = value; } }");
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