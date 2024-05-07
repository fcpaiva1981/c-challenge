using ApiChallengeCSharp.Data;
using ApiChallengeCSharp.Repository.Interfaces;
using ApiChallengeCSharp.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionStringMysql = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ChallengeDbContext>(options => {
    options.UseMySql(connectionStringMysql, ServerVersion.AutoDetect(connectionStringMysql));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IPermissaoRepository, PermissaoRepository>();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
