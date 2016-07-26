using ProjetoLavi.Dados.Repositories;
using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Dados.Repositories
{
    public class MaquinaRepository : RepositoryBase<Maquina>, IMaquinaRepository
    {
        //Repositorio especializado
    }
}
