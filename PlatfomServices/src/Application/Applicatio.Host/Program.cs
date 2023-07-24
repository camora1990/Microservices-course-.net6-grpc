using Commons.Utils.MapperExtensions;
using DrivenAdapter.Sql.SqlExtensions;
using Domain.UseCase.UseCaseExtensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Services

builder.Services.AddMapperServices();
builder.Services.AddDatabaseServices(builder.Configuration.GetConnectionString("PlatformServices"));
builder.Services.AddServicesUseCase();
builder.Services.AddRepositoriesServices();

#endregion Services

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