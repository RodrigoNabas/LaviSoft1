using ProjetoLavi.Dominio.Entities.Fornecedor;
using ProjetoLavi.Dominio.Interfaces.Repositories;
using ProjetoLavi.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Dominio.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository) 
                : base(fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
    }
}
