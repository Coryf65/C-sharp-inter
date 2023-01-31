namespace C_sharp_inter;

internal class Canvas
{
	// If we added Triangles as a new shape we would not need to change this method
	public void DrawShapes(List<Shape> shapes)
	{
		// example of Polymorphism (Many Forms) we can create new shapes and has 0 impact on thos class
		foreach (var shape in shapes)
		{
			shape.Draw();
		}
	}
}