using Demolite.Cv.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class AbstractRepository<T>(IDbContextFactory<CvDbContext> dbContextFactory) : IDbRepository<T>
	where T : class
{
	private async Task<CvDbContext> GetDbContext()
		=> await dbContextFactory.CreateDbContextAsync();

	public async Task<T[]> GetAll()
	{
		await using var dbContext = await GetDbContext();
		return await dbContext.Set<T>().ToArrayAsync();
	}
}