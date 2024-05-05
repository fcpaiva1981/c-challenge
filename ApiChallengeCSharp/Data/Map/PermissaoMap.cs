using ApiChallengeCSharp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiChallengeCSharp.Data.Map;

public class PermissaoMap : IEntityTypeConfiguration<PermissaoModel>
{
    public void Configure(EntityTypeBuilder<PermissaoModel> builder)
    {
        builder.HasKey("Id");
        builder.Property(x => x.Descricao).IsRequired().HasMaxLength(255);

        builder.HasOne(x => x.Usuario);
    }
}
