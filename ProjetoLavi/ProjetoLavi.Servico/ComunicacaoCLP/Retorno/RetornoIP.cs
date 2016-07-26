using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Servico.ComunicacaoCLP
{
    public class RetornoIP
    {
        public String Mensagem { get; set; }
        public int Tipo { get; set; }
        public List<CLPclass> ClPclasses { get; set; }
    }
}
