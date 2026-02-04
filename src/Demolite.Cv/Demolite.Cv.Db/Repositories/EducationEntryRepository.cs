using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class EducationEntryRepository(IDbContextFactory<CvDbContext> dbContextFactory)
	: AbstractRepository<EducationEntry>(dbContextFactory);