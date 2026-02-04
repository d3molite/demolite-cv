using System.ComponentModel.DataAnnotations;
using Demolite.Cv.Interfaces.Models;

namespace Demolite.Cv.Db.Models;

public class SkillEntry : AbstractDbItem, ISkillEntry
{
	[MaxLength(64)]
	public string Title { get; set; } = string.Empty;
	
	[MaxLength(64)]
	public string TitleEn { get; set; } = string.Empty;
	
	[MaxLength(512)]
	public string Skills { get; set; } = string.Empty;
	
	[MaxLength(512)]
	public string SkillsEn { get; set; } = string.Empty;
}