using Demolite.Cv.Db.Models;
using Demolite.Cv.Interfaces.Models;
using Demolite.Cv.Interfaces.Repositories;
using Demolite.Cv.Interfaces.Services;

namespace Demolite.Cv.Services.Db;

public class CvEntryService(IDbRepository<WorkEntry> workEntryRepository) : ICvEntryService
{
	public async Task<ICvEntry[]> GetCvEntries()
	{
		return await workEntryRepository.GetAll();
	}
}