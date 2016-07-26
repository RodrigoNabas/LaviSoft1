using ProjetoLavi.Dominio.Entities.Receitas;
using ProjetoLavi.Dominio.Interfaces;
using ProjetoLavi.Dominio.Interfaces.Repositories;

namespace ProjetoLavi.Dados.Repositories
{
    public class ReceitaRepository : RepositoryBase<Receita>,IReceitaRepository{}
}
