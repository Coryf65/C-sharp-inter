namespace C_sharp_inter;

public class SmsNotificationChannel : INotificationChannel
{
	public void Send(string message)
	{
		Console.WriteLine($"Sending sms : {message}");
	}
}