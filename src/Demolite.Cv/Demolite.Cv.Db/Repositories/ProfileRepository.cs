using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class ProfileRepository(IDbContextFactory<CvDbContext> dbContextFactory) : AbstractRepository<Profile>(dbContextFactory);