using AntaresSystemWeb.Areas.Identity.Data;
using AntaresSystemWeb.Data;
using AntaresSystemWeb.Data.Context;
using AntaresSystemWeb.Data.Dependencies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DbAntaresIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'DbAntaresIdentityContextConnection' not found.");

builder.Services.AddDbContext<DbAntaresIdentityContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<AntaresDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbAntaresContextConnection")));

builder.Services.AddDefaultIdentity<AntaresSystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DbAntaresIdentityContext>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDependencies(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseAuthentication(); ;

app.Run();