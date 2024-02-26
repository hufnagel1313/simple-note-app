using Microsoft.EntityFrameworkCore;
using SimpleNotesApp.API.Extensions;
using SimpleNotesApp.Application;
using SimpleNotesApp.Infra;
using SimpleNotesApp.Infra.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePersistence(builder.Configuration);
builder.Services.ConfigureApplication();

builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
await dataContext?.Database.MigrateAsync()!;

app.UseSwagger();
app.UseSwaggerUI();
app.UseErrorHandler();
app.UseCors();
app.MapControllers();
app.Run();