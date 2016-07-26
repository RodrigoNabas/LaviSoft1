using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dominio.Entities.Fornecedor;
using ProjetoLavi.Dominio.Interfaces.Services;
using ProjetoLavi.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Aplicacao
{
    public class FornecedorAppService : AppServiceBase<Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService)
                : base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
    }
}
