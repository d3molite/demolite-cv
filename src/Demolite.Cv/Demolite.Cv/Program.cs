using Demolite.Cv.Components;
using Demolite.Cv.Startup;
using Demolite.Cv.Ui.Components.Layout;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InjectDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);

	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode().AddAdditionalAssemblies(typeof(MainLayout).Assembly);

await app.MigrateDatabaseAsync();
await app.RunAsync();