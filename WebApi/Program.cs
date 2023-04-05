using AutoMapper;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using WebApi.Domain.Data;
using WebApi.Infrastructure.Interfaces;
using WebApi.Infrastructure.Repositories.Dapper;
using WebApi.Interfaces;
using WebApi.Service.MapperProfile;
using WebApi.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Simple Injector

var container = new Container();
container.Options.DefaultLifestyle = Lifestyle.Scoped;
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

builder.Services.AddSimpleInjector(container, options =>
{
    options.AddAspNetCore().AddControllerActivation();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MapperProfile>();
});


//DAPPER 
container.Register<DbContext>();
container.Register<IAdminRepository, AdminRepository>();
container.Register<IAdminService, AdminService>();
container.Register<IUserRepository, UserRepository>();
container.Register<IUserService, UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
