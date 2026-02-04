using Demolite.Cv.Components;
using Demolite.Cv.Db;
using Demolite.Cv.Startup;
using Demolite.Cv.Ui.Components.Layout;
using Microsoft.EntityFrameworkCore;

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
else
{
	app.UseHttpsRedirection();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode().AddAdditionalAssemblies(typeof(MainLayout).Assembly);

var factory = app.Services.GetRequiredService<IDbContextFactory<CvDbContext>>();
var db = await factory.CreateDbContextAsync();

await db.Database.MigrateAsync();

await app.RunAsync();