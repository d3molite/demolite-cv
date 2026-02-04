using Demolite.Cv.Db.Models;
using Demolite.Cv.Interfaces.Models;
using Demolite.Cv.Interfaces.Repositories;
using Demolite.Cv.Interfaces.Services;

namespace Demolite.Cv.Services.Db;

public class CvEntryService(
	IDbRepository<WorkEntry> workEntryRepository,
	IDbRepository<EducationEntry> educationEntryRepository
) : ICvEntryService
{
	public async Task<ICvEntry[]> GetCvEntries()
	{
		var workEntries = await workEntryRepository.GetAll();
		var educationEntries = await educationEntryRepository.GetAll();

		return workEntries.Concat<ICvEntry>(educationEntries).OrderByDescending(x => x.StartDate).ToArray();
	}
}