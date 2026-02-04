using System.ComponentModel.DataAnnotations;
using Demolite.Cv.Interfaces.Models;

namespace Demolite.Cv.Db.Models;

public class WorkEntry : AbstractCvEntry, IWorkEntry
{
	[MaxLength(128)]
	public string Location { get; set; } = string.Empty;

	[MaxLength(128)]
	public string CompanyName { get; set; } = string.Empty;
}