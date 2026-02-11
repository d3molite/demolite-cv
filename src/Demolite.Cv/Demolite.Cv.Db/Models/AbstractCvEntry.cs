using Demolite.Cv.Interfaces;
using Demolite.Cv.Interfaces.Models;

namespace Demolite.Cv.Db.Models;

public class AbstractCvEntry : AbstractDbItem, ICvEntry
{
	public DateOnly StartDate { get; set; }

	public DateOnly? EndDate { get; set; }

	public string Title { get; set; } = string.Empty;
	
	public string TitleEn {get; set;} = string.Empty;

	public string Description { get; set; } = string.Empty;
	
	public string DescriptionEn { get; set; } = string.Empty;

	public string DescriptionShort { get; set; } = string.Empty;

	public string DescriptionShortEn { get; set; } = string.Empty;
}