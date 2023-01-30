namespace C_sharp_inter;

internal class Shape
{
	public int Width { get; set; }
	public int Height { get; set; }
	public int X { get; set; }
	public int Y { get; set; }

	public void Draw()
	{
		Console.WriteLine("Shape drawn on screen.");
	}
}
