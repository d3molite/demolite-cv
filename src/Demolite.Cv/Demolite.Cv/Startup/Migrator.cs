using Demolite.Cv.Db;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Startup;

public static class Migrator
{
	public static async Task MigrateDatabaseAsync(this WebApplication app)
	{
		var factory = app.Services.GetRequiredService<IDbContextFactory<CvDbContext>>();
		var db = await factory.CreateDbContextAsync();

		await db.Database.MigrateAsync();
	}
}