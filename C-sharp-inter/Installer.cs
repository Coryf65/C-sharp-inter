namespace C_sharp_inter;

internal class Installer
{
	private ConsoleLogger _logger;

	public Installer(ConsoleLogger logger)
	{
		_logger = logger;
	}

	public void Install()
	{
		_logger.LogInfo("Installing the app now . . . ");
	}
}