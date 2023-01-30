namespace C_sharp_inter;

internal class DBMigrator
{
	private readonly Logger _logger;

	public DBMigrator(Logger logger)
	{
		_logger = logger;
	}

	public void Migrate()
	{
		_logger.Log("We are migrating the DBs . . . . .");		
	}
}
