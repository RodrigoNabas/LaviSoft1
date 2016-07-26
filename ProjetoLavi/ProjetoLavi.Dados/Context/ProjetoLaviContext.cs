using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using ProjetoLavi.Dados.EntityConfig;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Dominio.Entities.Processo;
using ProjetoLavi.Dominio.Entities.Receitas;
using ProjetoLavi.Dominio.ValueObjects;
using ProjetoLavi.Dominio.Entities.Fornecedor;

namespace ProjetoLavi.Dados.Context
{
    public class ProjetoLaviContext : DbContext
    {
        public ProjetoLaviContext(): base("ConexaoLavi")
        {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<ReceitaItem> ReceitaItens { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new MaquinaConfiguration());
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
