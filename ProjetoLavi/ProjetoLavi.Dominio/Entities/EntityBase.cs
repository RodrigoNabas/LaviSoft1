using System;

namespace ProjetoLavi.Dominio.Entities
{
    public abstract class EntityBase
    {
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
