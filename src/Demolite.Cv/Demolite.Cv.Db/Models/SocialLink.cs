using System.ComponentModel.DataAnnotations;

namespace Demolite.Cv.Db.Models;

public class SocialLink : AbstractDbItem
{
	[MaxLength(128)]
	public string Link { get; set; } = string.Empty;
	
	[MaxLength(128)]
	public string Title { get; set; } = string.Empty;
	
	[MaxLength(128)]
	public string GlyphName { get; set; } = string.Empty;
}