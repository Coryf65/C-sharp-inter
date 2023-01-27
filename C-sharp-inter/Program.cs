// See https://aka.ms/new-console-template for more information
using C_sharp_inter;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ----------------------------- ");
Console.WriteLine(" ---- Csharp Intermediate ---- ");
Console.WriteLine(" ----------------------------- ");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("\n~~ Practice 1 ~~\n");

Person person = new()
{
	Name = "John"
};

var other = person.Parse("Tony");

person.Introduce("Cory");

Console.WriteLine(other);
