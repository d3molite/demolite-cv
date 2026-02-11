using Demolite.Cv.Interfaces.Models;

namespace Demolite.Cv.Db.Models;

public class HobbyEntry : AbstractDbItem, IHobbyEntry
{
	public string Title { get; set; } = string.Empty;
	
	public string TitleEn {get; set;} = string.Empty;

	public string Description { get; set; } = string.Empty;
	
	public string DescriptionEn { get; set; } = string.Empty;
}