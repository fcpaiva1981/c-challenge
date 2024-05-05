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
        base.OnModelCreating(modelBuilder);
    }
}
