namespace C_sharp_inter;

internal class Installer
{
	private Logger _logger;

	public Installer(Logger logger)
	{
		_logger = logger;
	}

	public void Install()
	{
		_logger.Log("Installing the app now . . . ");
	}
}