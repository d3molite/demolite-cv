using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class HobbyEntryRepository(IDbContextFactory<CvDbContext> dbContextFactory)
	: AbstractRepository<HobbyEntry>(dbContextFactory);