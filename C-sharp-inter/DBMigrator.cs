namespace C_sharp_inter;

internal class DBMigrator
{
	private readonly ILogger _logger;

	// Dependency Injection
	public DBMigrator(ILogger logger)
	{
		_logger = logger;
	}

	public void Migrate()
	{
		_logger.LogInfo($"Started Migration : {DateTime.Now}");

		_logger.LogInfo("We are migrating the DBs . . . . .");	
		Thread.Sleep(1 * 1000);

		_logger.LogError("Some data corrupted");
		_logger.LogInfo($"Migration Completed : {DateTime.Now}");
	}
}