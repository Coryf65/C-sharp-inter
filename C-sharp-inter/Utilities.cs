namespace C_sharp_inter;

public static class Utilities
{
	public static int chapterCount = 1;

	public static void PrintTitle()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(" ----------------------------- ");
		Console.WriteLine(" ---- Csharp Intermediate ---- ");
		Console.WriteLine(" ----------------------------- ");
		ResetConsole();
	}

	public static void NextChapter(string title)
	{
		Console.ForegroundColor = (ConsoleColor)GetRandomColor();
		Console.WriteLine($"\n---- [{chapterCount}]  {title} ----\n");
		chapterCount++;
	}

	public static void ResetConsole()
	{
		Console.ForegroundColor = ConsoleColor.White;
	}

	private static int GetRandomColor()
	{
		Random random = new();
		// 1 -> 15
		int currentColorCode = random.Next(15) + 1; // skip black == 0

		return currentColorCode;
	}
}
