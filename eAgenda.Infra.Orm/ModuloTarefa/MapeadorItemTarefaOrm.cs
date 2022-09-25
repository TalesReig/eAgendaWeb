using eAgenda.Dominio.ModuloTarefa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eAgenda.Infra.Orm.ModuloTarefa
{
    public class MapeadorItemTarefaOrm : IEntityTypeConfiguration<ItemTarefa>
    {
        public void Configure(EntityTypeBuilder<ItemTarefa> builder)
        {
            builder.ToTable("TBItemTarefa");

            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Titulo).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.Concluido);

            builder.HasOne(x => x.Tarefa)
                .WithMany().OnDelete(DeleteBehavior.Cascade);
        }
    }
}