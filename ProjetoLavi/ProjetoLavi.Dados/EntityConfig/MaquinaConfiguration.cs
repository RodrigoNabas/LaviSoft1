using ProjetoLavi.Dominio.Entities.Maquinas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Dados.EntityConfig
{
    public class MaquinaConfiguration : EntityTypeConfiguration<Maquina>
    {
        public MaquinaConfiguration()
        {
            HasKey(m => m.MaquinaId);

            Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(Maquina.NomeMaxLength);

            Property(m => m.Descricao)
                .IsRequired()
                .HasMaxLength(Maquina.DescricaoMaxLength);

            Property(m => m.Capacidade)
                .IsRequired();
        }
        
    }
}
