using SimpleInjector;
using SimpleInjector.Lifestyles;
using WebApi.Domain.Data;

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


//DAPPER 
container.Register<DbContext>();

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
