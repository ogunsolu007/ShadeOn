using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShadeOn.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<AppDataContext>(options => options.
UseSqlServer(builder.Configuration.GetConnectionString("Default")));

//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDataContext>();

//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDataContext>();

//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDataContext>();


builder.Services.AddIdentity<AppUser, IdentityRole>()
.AddDefaultTokenProviders()
 .AddDefaultUI()
 .AddEntityFrameworkStores<AppDataContext>();

builder.Services.AddAuthentication().AddMicrosoftAccount(microsoftOptions =>
{
    microsoftOptions.ClientId = builder.Configuration["Authentication:Microsoft:ClientId"];
    microsoftOptions.ClientSecret = builder.Configuration["Authentication:Microsoft:ClientSecret"];
});

builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = "1336744393848112";
    options.AppSecret = "e15d79c3dbb5142f958387844f1dfb95";
});

builder.Services.AddAuthorization();

builder.Services.AddRazorPages(o=> { o.Conventions.AuthorizeFolder("/Admin"); });

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

app.MapRazorPages();

app.Run();
