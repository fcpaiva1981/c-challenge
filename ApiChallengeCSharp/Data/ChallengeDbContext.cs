using ApiChallengeCSharp.Data.Map;
using ApiChallengeCSharp.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiChallengeCSharp.Data;

public class ChallengeDbContext : DbContext
{
    public ChallengeDbContext(DbContextOptions<ChallengeDbContext> options) : base(options)
    { }

    public DbSet<UsuarioModel> Usuarios { get; set; }
    public DbSet<PermissaoModel> Permissaos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioMap());
        modelBuilder.ApplyConfiguration(new PermissaoMap());
        base.OnModelCreating(modelBuilder);
    }
}
