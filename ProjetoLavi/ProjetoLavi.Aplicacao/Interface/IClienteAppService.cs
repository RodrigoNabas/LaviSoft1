using System.Collections.Generic;
using ProjetoLavi.Dominio.Entities.Cliente;

namespace ProjetoLavi.Aplicacao.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetByName(string nomeCliente);
    }
}
