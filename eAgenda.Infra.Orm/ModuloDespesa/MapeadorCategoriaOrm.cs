using eAgenda.Dominio.ModuloDespesa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eAgenda.Infra.Orm.ModuloDespesa
{
    public class MapeadorCategoriaOrm : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("TBCategoria");
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Titulo).HasColumnType("varchar(200)").IsRequired();

            //builder.HasOne(x => x.Usuario)
            //  .WithMany()
            //  .IsRequired()
            //  .HasForeignKey(x => x.UsuarioId)
            //  .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Despesas);
        }
    }
}
