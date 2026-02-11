using Demolite.Cv.Db.Models;
using Demolite.Cv.Interfaces.Models;
using Demolite.Cv.Interfaces.Repositories;
using Demolite.Cv.Interfaces.Services;
using Microsoft.AspNetCore.Components;

namespace Demolite.Cv.Ui.Components.Pages;

public partial class Index
{
	[Inject]
	public ICvEntryService CvEntryService { get; set; } = null!;

	[Inject]
	public IDbRepository<SkillEntry> SkillEntryRepository { get; set; } = null!;

	[Inject]
	public IDbRepository<ProjectEntry> ProjectEntryRepository { get; set; } = null!;

	private ICvEntry[] CvEntries { get; set; } = [];

	private ISkillEntry[] SkillEntries { get; set; } = [];

	private ProjectEntry[] ProjectEntries { get; set; } = [];

	protected override async Task OnInitializedAsync()
	{
		CvEntries = await CvEntryService.GetCvEntries();
		SkillEntries = await SkillEntryRepository.GetAll();
		ProjectEntries = (await ProjectEntryRepository.GetAll()).OrderByDescending(x => x.StartDate).ToArray();
	}
}