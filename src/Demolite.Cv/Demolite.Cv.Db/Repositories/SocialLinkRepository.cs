using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db.Repositories;

public class SocialLinkRepository(IDbContextFactory<CvDbContext> dbContextFactory) : AbstractRepository<SocialLink>(dbContextFactory);