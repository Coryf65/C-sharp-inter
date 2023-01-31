namespace C_sharp_inter;

public class VideoEncoder
{
	private readonly ILogger _logger;
	private readonly IList<INotificationChannel> _notificationChannels;

	public VideoEncoder(ILogger logger)
	{
		_logger = logger;
		_notificationChannels = new List<INotificationChannel>();
	}

	public void Encode(Video video)
	{
		_logger.LogInfo($"Encoding video : {video}");

		foreach (var channel in _notificationChannels)
		{
			channel.Send(new Message("Message data").Data);
		}
	}

	/// <summary>
	/// Add a Notification into the available Notify List to be sent out.
	/// </summary>
	/// <param name="notification">Notifiction Type</param>
	public void RegisterNotificationChannel(INotificationChannel notification)
	{
		_notificationChannels.Add(notification);
	}
}