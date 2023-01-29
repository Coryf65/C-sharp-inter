namespace C_sharp_inter;

public class AccessModifiers
{	
	// Fields are private, and we can use getters and setter or properties
	private DateTime _birthdate;
	
	public AccessModifiers()
	{
		NotesPrint();
	}

	public void SetBirthdate(DateTime birthdate)
	{
		_birthdate = birthdate;
	}

	public DateTime GetBirthdate()
	{
		return _birthdate;
	}

	private void NotesPrint()
	{
		Console.WriteLine("We have 6 Access Modifiers in C#");

		Console.WriteLine("This is a way to control access to a class or it's members. Meant for saftey to not created bugs");

		Console.WriteLine("Public -");
		Console.WriteLine("The type or member can be accessed by any other code in the same assembly or another assembly that references it." +
			" The accessibility level of public members of a type is controlled by the accessibility level of the type itself.\n");

		Console.WriteLine("Private -");
		Console.WriteLine("The type or member can be accessed only by code in the same class or struct.\n");

		Console.WriteLine("Protected -");
		Console.WriteLine("The type or member can be accessed only by code in the same class, or in a class that is derived from that class.\n");

		Console.WriteLine("Internal -");
		Console.WriteLine("The type or member can be accessed by any code in the same assembly, but not from another assembly." +
			" In other words, internal types or members can be accessed from code that is part of the same compilation.\n");

		Console.WriteLine("Protected Internal -");
		Console.WriteLine("The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.\n");

		Console.WriteLine("Protected Private -");
		Console.WriteLine("The type or member can be accessed by types derived from the class that are declared within its containing assembly.\n");
	}
}