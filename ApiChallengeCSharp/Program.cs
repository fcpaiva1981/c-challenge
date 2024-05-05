using ApiChallengeCSharp.Data;
using ApiChallengeCSharp.Repository.Interfaces;
using ApiChallengeCSharp.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionStringMysql = builder.Configuration.GetConnectionString("ConnectionMySQL");
builder.Services.AddDbContext<ChallengeDbContext>(options => options.UseMySql(connectionStringMysql, 
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.0-Mysql")));


builder.Services.AddScoped<IUsuarioRepository,UsuarioRepository>();
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
