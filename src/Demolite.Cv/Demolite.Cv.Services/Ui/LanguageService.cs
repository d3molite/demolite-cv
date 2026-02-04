using Demolite.Cv.Common.Enum;
using Demolite.Cv.Interfaces.Services;

namespace Demolite.Cv.Services.Ui;

public class LanguageService : ILanguageService
{
	public event EventHandler? LanguageChanged;

	public DisplayLanguage Language { get; internal set; }

	public void SetLanguage(DisplayLanguage language)
	{
		Language = language;
		LanguageChanged?.Invoke(this, EventArgs.Empty);
	}
}