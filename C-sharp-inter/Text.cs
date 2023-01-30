using C_sharp_inter;

public class Text : PresentationObject
{
	public int FontSize { get; set; }
	public string FontName { get; set; }

	public void AddHyperlink(string url)
	{
		Console.WriteLine($"Added url of '{url}'");
	}
}