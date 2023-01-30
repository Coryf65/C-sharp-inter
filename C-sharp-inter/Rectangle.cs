namespace C_sharp_inter;

internal class Rectangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Drew a rectangle overriding the base Draw() method");
	}
}