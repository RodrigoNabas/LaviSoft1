using System;
using System.Collections.Generic;
using ProjetoLavi.Dominio.ValueObjects;

namespace ProjetoLavi.Dominio.Entities.Cliente
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int Codigo { get; set; }

        public const int NomeMaxLength = 100;
        public const int NomeMinLength = 3;
        public string Nome { get; set; }
        public virtual Email Email { get; set; }
        public virtual List<Telefone> Telefones { get; set; }
        public virtual Cnpj Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}