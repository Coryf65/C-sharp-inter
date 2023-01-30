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

Utilities.NextChapter("Inheritence");

Car car = new("12355888");

Console.WriteLine("Note: the base class constructor will be built first");

Utilities.NextChapter("Upcasting / Downcasting");

// We can convert the presentation into a text object
// Both are references to the same object in memory

Console.WriteLine("We can convert the presentation into a text object");
Text text1 = new();
PresentationObject presObj = text1;

Console.WriteLine("Setting the width to 200, from text");
text1.Width = 200;
Console.WriteLine("setting the Width to 100, from presObj");
presObj.Width = 100;

Console.WriteLine("Width: '{0}'", text.Width);

Utilities.NextChapter("Boxing and Unboxing");

Console.WriteLine("The process of converting a value type instance to an object reference.\r\n");

Utilities.NextChapter("Method Overriding");

// Can be a Shape Object or a Derived Class
List<Shape> shapes = new()
{
	new Circle { Width = 100, Height = 100 },
	new Rectangle { Width = 100, Height = 100 }
};

Canvas canvas = new();
canvas.DrawShapes(shapes);

Utilities.ResetConsole();