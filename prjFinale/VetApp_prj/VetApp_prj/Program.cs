using Microsoft.AspNetCore.Mvc.Razor;
using VetApp_prj.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(opt => opt.ResourcesPath = "Resources"); //Resources folder

// Add services to the container.
builder.Services.AddRazorPages().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.AddDbContext<VetBddContext>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.Configure<RequestLocalizationOptions>(opt =>
{
    var supportedCultures = new[] { "en-US", "fr" };
    opt.SetDefaultCulture(supportedCultures[0])
        .AddSupportedCultures(supportedCultures)
        .AddSupportedUICultures(supportedCultures);
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
builder.Services.AddDistributedMemoryCache();

builder.Services.AddDistributedMemoryCache();



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();






app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();