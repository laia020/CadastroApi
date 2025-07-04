using Cadastro.Infrastructure.CrossCutting.Bootstrap;
using Cadastro.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

NativeBootstrap.serviceLocation(builder.Services);

// Connection string adaptável: local + Docker
string connection = configuration.GetConnectionString("BaseIdentity") ?? "";
var envConnection = Environment.GetEnvironmentVariable("CONNECTION_STRING");
if (!string.IsNullOrEmpty(envConnection))
{
    connection = envConnection;
}

builder.Services.AddDbContext<CadastroContext>(options =>
{
    options.UseSqlite(connection);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<CadastroContext>();
    db.Database.Migrate(); // Cria e aplica migrations
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
