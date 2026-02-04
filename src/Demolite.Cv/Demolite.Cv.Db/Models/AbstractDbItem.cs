using System.ComponentModel.DataAnnotations.Schema;

namespace Demolite.Cv.Db.Models;

public class AbstractDbItem
{
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
}