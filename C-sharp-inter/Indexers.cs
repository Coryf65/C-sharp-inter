using C_sharp_inter;
using System.Web;

public class Indexers
{
	public Indexers()
	{
		Console.WriteLine("Indexers are a way to access elements in a class that represents a list of values.");

		Console.WriteLine("like accessing a certain position in an array or List<>\n");
		Console.WriteLine("var array = new int[5]; \n array[2] = 55;");
		Console.WriteLine("var list = new List<int>(); \n list[0] = 1;");

		// some more Examples
		// Not using the real HTTPCOOKIE just a demo example
		var cookie = new HttpCookie();
		cookie.Expire = DateTime.Today.AddDays(5);

		cookie["name"] = "one";
		Console.WriteLine($"setting using indexer, Cookie['name'] : {cookie["name"]}");
		
		cookie.SetItem("name", "two");
		Console.WriteLine($"setting using method, Cookie['name'] : {cookie["name"]}");

		var name = cookie["name"];
		var name2 = cookie.GetItem("name");
	}
}

public class HttpCookie
{
	
	public DateTime Expire { get; set; }
	// Hashtable, index for lists dictionary for keys
	private readonly Dictionary<string, string> _dictionary;

	public HttpCookie()
	{
		_dictionary = new Dictionary<string, string>();
	}
	
	// indexers do not have names hence 'this'
	public string this[string key]
	{
		get { return _dictionary[key]; }
		set { _dictionary[key] = value; }
	}

	public void SetItem(string name, string value)
	{
		this[name] = value;
	}

	public string GetItem(string name)
	{
		return this[name];
	}
}