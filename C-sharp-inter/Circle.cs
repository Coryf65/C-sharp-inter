namespace C_sharp_inter;

/// <summary>
/// Everything about Circles are in this one class
/// </summary>
internal class Circle : Shape
{
	public override void Draw()
	{
		// using the base method if wanted
		//base.Draw();

		Console.WriteLine("Circle Method! overriding the base class");
	}
}