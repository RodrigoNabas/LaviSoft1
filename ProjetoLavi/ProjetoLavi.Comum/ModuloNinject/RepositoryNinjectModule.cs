using Ninject.Modules;
using ProjetoLavi.Dados.Repositories;
using ProjetoLavi.Dominio.Interfaces.Repositories;

namespace ProjetoLavi.Comum.ModuloNinject
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
        }
    }
}
