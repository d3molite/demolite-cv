using Demolite.Cv.Interfaces.Models;

namespace Demolite.Cv.Interfaces.Services;

public interface ICvEntryService
{
	public Task<ICvEntry[]> GetCvEntries();
}