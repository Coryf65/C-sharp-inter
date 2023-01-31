namespace C_sharp_inter;

/// <summary>
/// An example of the relationship not actual details
/// </summary>
public class ConsoleLogger : ILogger
{
	public void LogError(string message)
	{
		var previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("[Info] : {0}", message);
		Console.ForegroundColor = previousColor;
	}

	public void LogInfo(string message)
	{
		Console.WriteLine("[Info] : {0}", message);
	}
}