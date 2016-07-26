using System.Collections.Generic;
using ProjetoLavi.Dominio.Entities.Cliente;

namespace ProjetoLavi.Dominio.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        // metodos especializados
        IEnumerable<Cliente> GetByName(string nomeCliente);
    }
}
