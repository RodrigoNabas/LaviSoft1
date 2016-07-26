using Ninject.Modules;
using ProjetoLavi.Aplicacao;
using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dominio.Interfaces.Services;
using ProjetoLavi.Dominio.Services;

namespace ProjetoLavi.Comum.ModuloNinject
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IMaquinaAppService>().To<MaquinaAppSerivce>();
            Bind<IFornecedorAppService>().To<FornecedorAppService>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IMaquinaService>().To<MaquinaService>();
            Bind<IFornecedorService>().To<FornecedorService>();

        }
    }
}
