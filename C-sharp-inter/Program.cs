// See https://aka.ms/new-console-template for more information
using C_sharp_inter;

Utilities.PrintTitle();

Utilities.NextChapter("Loops");

Loops loops = new();

Utilities.NextChapter("Objects");

Person person = new(new DateTime(1988, 1, 25))
{
	Name = "James"
};

var other = person.Parse("Tony");

person.Introduce("Cory");

Console.WriteLine(other);

Utilities.NextChapter("Constructors");

Constructors constructors = new();

Utilities.NextChapter("Object Initializers");

Console.WriteLine("Use object initializers like so...\n");
Console.WriteLine("Object o = new()" 
	+ "\n{" 
	+ "\n o.Name = 'billy'" 
	+ "\n};");

Utilities.NextChapter("Methods");

Methods methods = new();

Utilities.NextChapter("Fields");

Fields fields = new();

Utilities.NextChapter("Access Modifiers");

AccessModifiers accessModifiers = new();

Utilities.NextChapter("Properties");

Properties properties = new();

Utilities.NextChapter("Indexers");

Indexers indexers = new();


Utilities.ResetConsole();