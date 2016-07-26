using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Dominio.Interfaces.Repositories;
using ProjetoLavi.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLavi.Dominio.Services
{
    public class MaquinaService : ServiceBase<Maquina>, IMaquinaService
    {
        private readonly IMaquinaRepository _maquinaRepository;

        public MaquinaService(IMaquinaRepository maquinaRepository)
                : base(maquinaRepository)
        {
            _maquinaRepository = maquinaRepository;
        }

    }
}
