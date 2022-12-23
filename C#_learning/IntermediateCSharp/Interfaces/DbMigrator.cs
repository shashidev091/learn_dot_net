using System;
namespace Interfaces
{
	public class DbMigrator
	{
		// Dependency Injection
		private readonly ILogger _logger;

		public DbMigrator(ILogger logger)
		{
			_logger = logger;
		}

		public void Migrate()
		{
			this._logger.LogInfo("Migration started at {0}" + DateTime.Now);

			this._logger.LogInfo("Migration finished at {0}" + DateTime.Now);
		}

	}
}

