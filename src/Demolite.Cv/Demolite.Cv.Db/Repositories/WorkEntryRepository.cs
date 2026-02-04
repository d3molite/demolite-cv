using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class WorkEntryRepository(IDbContextFactory<CvDbContext> dbContextFactory) : AbstractRepository<WorkEntry>(dbContextFactory);