// See https://aka.ms/new-console-template for more information
using C_sharp_inter;
using DemoLib;
using System.Diagnostics;

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

Utilities.NextChapter("Class Coupling");

Coupling coupling = new();

Utilities.NextChapter("Inheritence");

Text text = new();

text.Copy();
text.Duplicate();
text.AddHyperlink("someplace.com");

Utilities.NextChapter("Composition");

DBMigrator migrator = new(new Logger());

var logger = new Logger();
var installer = new Installer(logger);

migrator.Migrate();
installer.Install();

Utilities.NextChapter("Black Box Metaphor");

Customer customer = new();

Console.WriteLine("'DemoLib.RateCalculator' class we cannot access due to the access modifiers");
Console.WriteLine("These are marked as internal which allows us to be less coupled");

Utilities.ResetConsole();