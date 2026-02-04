using Demolite.Cv.Interfaces.Models;
using Demolite.Cv.Interfaces.Services;
using Microsoft.AspNetCore.Components;

namespace Demolite.Cv.Ui.Components.Pages;

public partial class Index
{
	[Inject]
	public ICvEntryService CvEntryService { get; set; } = null!;

	private ICvEntry[] CvEntries { get; set; } = [];

	protected override async Task OnInitializedAsync()
	{
		CvEntries = await CvEntryService.GetCvEntries();
	}
}