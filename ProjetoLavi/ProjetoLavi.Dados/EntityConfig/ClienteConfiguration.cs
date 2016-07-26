using System.Data.Entity.ModelConfiguration;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.ValueObjects;

namespace ProjetoLavi.Dados.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(Cliente.NomeMaxLength);
            Property(c => c.Email.Endereco)
                .HasMaxLength(Email.EnderecoMaxLength)
                .IsRequired();
            Property(c => c.Cnpj.CodCnpj)
                .IsRequired();
        }
    }
}
