namespace C_sharp_inter;

public class VideoEncoder
{
	private readonly ILogger _logger;
	private readonly MailService _mailService;

	public VideoEncoder(ILogger logger)
	{
		_logger = logger;
		_mailService = new MailService();
	}

	public void Encode(Video video)
	{
		_logger.LogInfo($"Encoding video : {video}");

		_mailService.Send(new Mail());
	}
}