using System.ComponentModel.DataAnnotations;

namespace Demolite.Cv.Db.Models;

public class ProjectEntry : AbstractCvEntry
{
	[MaxLength(128)]
	public string? CompanyName { get; set; }

	[MaxLength(256)]
	public string Skills { get; set; } = string.Empty;
}