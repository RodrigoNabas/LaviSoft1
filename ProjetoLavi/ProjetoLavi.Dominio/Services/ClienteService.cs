using System.Collections.Generic;
using System.Linq;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.Interfaces.Repositories;
using ProjetoLavi.Dominio.Interfaces.Services;

namespace ProjetoLavi.Dominio.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetByName(string nomeCliente)
        {
            return _clienteRepository.GetAll().Where(x => x.Nome.Contains(nomeCliente));
        }
    }
}
