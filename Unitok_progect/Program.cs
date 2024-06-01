using Microsoft.AspNetCore.Identity;
using System.Reflection;
using Unitok_progect.Persistence.Contexts;
using Unitok.Application.Features.Users.Commands.PostUserRegister;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Unitok.Application.Interfaces.Repositories;
using Unitok.Persistence.Repositories;
using Unitok_progect.Domain.Entities;
using MediatR;
using Unitok_progect.Application.Extensions;
using Unitok.Application.Features.Users.Commands.PostUserLogin;
using Unitok_progect.Domain.Common.Interfaces;
using Unitok_progect.Domain.Common;
using Unitok.Persistence.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitectureDemo.Application.Interfaces;
using Unitok_progect.Infrastructure.Services;
using Unitok.Application.Interfaces;
using Unitok.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();

builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddApplicationLayer();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

builder.Services.Configure<IdentityOptions>(options =>
{
	options.Password.RequireDigit = true;
	options.Password.RequireLowercase = true;
	options.Password.RequireUppercase = true;
	options.Password.RequireNonAlphanumeric = false;
    options.SignIn.RequireConfirmedEmail = true;
});

/*builder.Services.AddIdentity<User, IdentityRole<int>>()   //ok
    .AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();*/

builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options => options.LoginPath = "/Login");
builder.Services.AddAuthorization();


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())); //ok
builder.Services.AddTransient<IMediator, Mediator>()
			    .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>();  //ok

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/AccessDenied";
});

//builder.Services.AddScoped<IGenericRepository<UserInfo>, GenericRepository<UserInfo>>();
builder.Services.AddTransient<IRequestHandler<UserRegisterCommand, RegisterResult>, UserRegisterCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UserLoginCommand, bool>, UserLoginCommandHandler>();
builder.Services.AddScoped<SignInManager<UserMain>>();
builder.Services.AddScoped<UserManager<UserMain>>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


/*builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));*/

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
