namespace C_sharp_inter;

public class MailNotificationChannel : INotificationChannel
{
	public void Send(string message)
	{
		Console.WriteLine($"Sending email : {message}");
	}
}