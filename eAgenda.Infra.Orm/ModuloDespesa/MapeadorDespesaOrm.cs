using eAgenda.Dominio.ModuloDespesa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eAgenda.Infra.Orm.ModuloDespesa
{
    public class MapeadorDespesaOrm : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.ToTable("TBDespesa");
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Descricao).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.FormaPagamento).HasConversion<int>().IsRequired();

            builder.HasMany(x => x.Categorias)
                .WithMany(x => x.Despesas)
                .UsingEntity(x =>
                    x.ToTable("TBDespesa_TBCategoria")
                );
        }
    }
}
