using Persistence;
using Microsoft.EntityFrameworkCore;
using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync(); //migrate the db
    await Seed.SeedData(context); //migrate the seeded data
}
catch (Exception ex)
{

	var logger  = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}


app.Run();
