using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.Interfaces;
using ProjetoLavi.Dominio.Interfaces.Repositories;

namespace ProjetoLavi.Dados.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        // Repositorio especializado
    }
}
