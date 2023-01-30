namespace C_sharp_inter;

internal class Vehicle
{
	private string _registrationNumber = string.Empty;

	public Vehicle()
	{
		Console.WriteLine("Vehicle is being built...");
	}

	public Vehicle(string registrationNumber)
	{
		_registrationNumber = registrationNumber;
		Console.WriteLine($"Vehicle class, Set Registration Number to: '{_registrationNumber}'");
	}
}