namespace C_sharp_inter;

public class MailService
{
	internal void Send(Mail mail)
	{
		Console.WriteLine($"Sent email to {mail.EmailAddress}");
	}
}