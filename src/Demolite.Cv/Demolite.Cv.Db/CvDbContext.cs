using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db;

public class CvDbContext(DbContextOptions<CvDbContext> options) : DbContext(options)
{
	public DbSet<WorkEntry> WorkEntries { get; set; } = null!;

	public DbSet<EducationEntry> EducationEntries { get; set; } = null!;
}