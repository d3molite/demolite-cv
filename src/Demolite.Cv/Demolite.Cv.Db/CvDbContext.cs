using Demolite.Cv.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Demolite.Cv.Db;

public class CvDbContext(DbContextOptions<CvDbContext> options) : DbContext(options)
{
	public DbSet<WorkEntry> WorkEntries { get; set; } = null!;

	public DbSet<EducationEntry> EducationEntries { get; set; } = null!;

	public DbSet<SocialLink> SocialLinks { get; set; } = null!;

	public DbSet<Profile> Profiles { get; set; } = null!;

	public DbSet<SkillEntry> SkillEntries { get; set; } = null!;

	public DbSet<ProjectEntry> ProjectEntries { get; set; } = null!;
}