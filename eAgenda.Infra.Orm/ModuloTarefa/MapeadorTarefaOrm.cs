using eAgenda.Dominio.ModuloTarefa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eAgenda.Infra.Orm.ModuloTarefa
{
    public class MapeadorTarefaOrm : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TBTarefa");
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Titulo).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.Prioridade).HasConversion<int>();
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataConclusao).IsRequired(required: false);
            builder.Property(x => x.PercentualConcluido);

            builder.HasMany(x => x.Itens)
                .WithOne(x => x.Tarefa)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
