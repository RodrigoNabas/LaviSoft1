using System.Collections.Generic;
using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.Interfaces.Services;

namespace ProjetoLavi.Aplicacao
{
    public class ClienteAppService : AppServiceBase<Cliente>,IClienteAppService
    {
        private readonly IClienteService _clienteService;
        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> GetByName(string nomeCliente)
        {
            return _clienteService.GetByName(nomeCliente);
        }
    }
}
