using System.Drawing;

namespace C_sharp_inter;

public static class Utilities
{
	public static void PrintTitle()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(" ----------------------------- ");
		Console.WriteLine(" ---- Csharp Intermediate ---- ");
		Console.WriteLine(" ----------------------------- ");
		ResetConsole();
	}

	public static void NextChapter()
	{
		int chapterCount = 0;

		chapterCount++;

		Console.ForegroundColor = GetRandomColor().ToString();
		Console.WriteLine(" ---- Csharp Intermediate ---- ");
		ResetConsole();

	}

	private static void ResetConsole()
	{
		Console.ForegroundColor = ConsoleColor.White;
	}

	private static int GetRandomColor()
	{	
		Random random = new();

		return random.Next(16);
	} 
}
