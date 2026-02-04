namespace Demolite.Cv.Interfaces.Models;

public interface IEducationEntry : ICvEntry
{
	public string SchoolName { get; set; }
	
	public string Grade { get; set; }
}