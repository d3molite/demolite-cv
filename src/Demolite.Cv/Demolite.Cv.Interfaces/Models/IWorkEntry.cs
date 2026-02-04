namespace Demolite.Cv.Interfaces.Models;

public interface IWorkEntry : ICvEntry
{
	public string Location { get; set; }
	
	public string CompanyName { get; set; }
}