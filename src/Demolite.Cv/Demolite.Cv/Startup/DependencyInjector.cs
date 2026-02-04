using Demolite.Cv.Db;
using Demolite.Cv.Db.Models;
using Demolite.Cv.Db.Repositories;
using Demolite.Cv.Interfaces.Repositories;
using Demolite.Cv.Interfaces.Services;
using Demolite.Cv.Services.Db;
using Demolite.Cv.Services.Ui;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

namespace Demolite.Cv.Startup;

public static class DependencyInjector
{
	public static void InjectDependencies(this IServiceCollection services)
	{
		services.InjectBlazor();
		services.InjectDbContext();
		services.InjectRepositories();
		services.InjectServices();
	}

	private static void InjectBlazor(this IServiceCollection services)
	{
		services.AddRazorComponents().AddInteractiveServerComponents();
		services.AddMudServices();
	}

	private static void InjectDbContext(this IServiceCollection services)
		=> services.AddDbContextFactory<CvDbContext>(options => options.UseSqlite("Data Source=./db/app.db"));

	private static void InjectRepositories(this IServiceCollection services)
	{
		services.AddScoped<IDbRepository<Profile>, ProfileRepository>();
		services.AddScoped<IDbRepository<SocialLink>, SocialLinkRepository>();
		services.AddScoped<IDbRepository<WorkEntry>, WorkEntryRepository>();
		services.AddScoped<IDbRepository<EducationEntry>, EducationEntryRepository>();
	}

	private static void InjectServices(this IServiceCollection services)
	{
		services.AddScoped<ILanguageService, LanguageService>();

		services.AddScoped<ICvEntryService, CvEntryService>();
	}
}