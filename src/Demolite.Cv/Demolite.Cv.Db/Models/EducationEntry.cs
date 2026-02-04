using System.ComponentModel.DataAnnotations;
using Demolite.Cv.Interfaces.Models;

namespace Demolite.Cv.Db.Models;

public class EducationEntry : AbstractCvEntry, IEducationEntry
{
	[MaxLength(128)]
	public string SchoolName { get; set; } = string.Empty;
	
	[MaxLength(128)]
	public string Grade { get; set; } = string.Empty;
}