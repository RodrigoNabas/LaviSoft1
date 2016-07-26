using ProjetoLavi.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Dominio.Entities.Fornecedor
{
    public class Fornecedor
    {
        public int FornecedorId { get; set;}
        public string Nome { get; set; }
        public string Estado { get; set; }
        public virtual Cnpj Cnpj { get; set; }
        public bool Ativo { get; set; }
    }
}
