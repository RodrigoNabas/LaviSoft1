using ProjetoLavi.Dominio.Entities.Fornecedor;
using ProjetoLavi.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Dados.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
         public FornecedorConfiguration()
        {
            HasKey(c => c.FornecedorId);

            Property(c => c.Nome)
                .IsRequired();

            Property(c => c.Cnpj.CodCnpj)
                .IsRequired();

            Property(c => c.Estado)
                .IsRequired();

        }
    }
}
