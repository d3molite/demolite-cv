using Demolite.Cv.Common.Enum;

namespace Demolite.Cv.Interfaces.Services;

public interface ILanguageService
{
	public event EventHandler? LanguageChanged;
	
	public DisplayLanguage Language { get; }
	
	public void SetLanguage(DisplayLanguage language);
}