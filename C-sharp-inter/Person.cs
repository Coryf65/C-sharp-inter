using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
