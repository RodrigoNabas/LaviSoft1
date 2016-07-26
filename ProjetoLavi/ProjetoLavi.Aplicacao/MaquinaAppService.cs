

using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Dominio.Interfaces.Services;

namespace ProjetoLavi.Aplicacao
{
    public class MaquinaAppSerivce : AppServiceBase<Maquina>, IMaquinaAppService
    {
        private readonly IMaquinaService _maquinaService;

        public MaquinaAppSerivce(IMaquinaService maquinaService) : base(maquinaService)
        {
            _maquinaService = maquinaService;   
        }
    }
}
