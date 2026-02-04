using System.ComponentModel.DataAnnotations;

namespace Demolite.Cv.Db.Models;

public class Profile : AbstractDbItem
{
	[MaxLength(255)]
	public string Name { get; set; } = string.Empty;

	[MaxLength(255)]
	public string Address { get; set; } = string.Empty;

	[MaxLength(64)]
	public string Phone { get; set; } = string.Empty;

	[MaxLength(128)]
	public string Mail { get; set; } = string.Empty;
}