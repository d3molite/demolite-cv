namespace Demolite.Cv.Interfaces.Models;

public interface ICvEntry
{
	public DateOnly StartDate { get; set; }
	
	public DateOnly? EndDate { get; set; }
	
	public string Title { get; set; }
	
	public string TitleEn { get; set; }
	
	public string Description { get; set; }
	
	public string DescriptionEn { get; set; }
}