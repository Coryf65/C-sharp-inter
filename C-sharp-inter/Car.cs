namespace C_sharp_inter;

internal class Car : Vehicle
{
	public Car(string registrationNumber) : base(registrationNumber: registrationNumber)
	{
		Console.WriteLine("Car, is being setup ...Reg Number : '{0}'", registrationNumber);
	}
}
