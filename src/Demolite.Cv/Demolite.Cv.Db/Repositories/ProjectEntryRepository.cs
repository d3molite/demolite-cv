using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class ProjectEntryRepository(IDbContextFactory<CvDbContext> dbContextFactory) : AbstractRepository<ProjectEntry>(dbContextFactory);