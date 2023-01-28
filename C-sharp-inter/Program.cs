// See https://aka.ms/new-console-template for more information
using C_sharp_inter;

Utilities.PrintTitle();

Utilities.NextChapter("Loops");

Loops loops = new();

Utilities.NextChapter("Objects");

Person person = new()
{
	Name = "John"
};

var other = person.Parse("Tony");

person.Introduce("Cory");

Console.WriteLine(other);

Utilities.NextChapter("Constructors");

Constructors constructors = new();

Utilities.ResetConsole();