namespace C_sharp_inter;

public class PresentationObject
{
	public int Width { get; set; }
	public int Height { get; set; }

	public void Copy()
	{
		Console.WriteLine("Object was copied to the clipboard");
	}

	public void Duplicate()
	{
		Console.WriteLine("object was duplicated");
	}
}