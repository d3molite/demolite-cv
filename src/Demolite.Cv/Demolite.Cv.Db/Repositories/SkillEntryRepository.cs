using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class SkillEntryRepository(IDbContextFactory<CvDbContext> dbContextFactory) : AbstractRepository<SkillEntry>(dbContextFactory);