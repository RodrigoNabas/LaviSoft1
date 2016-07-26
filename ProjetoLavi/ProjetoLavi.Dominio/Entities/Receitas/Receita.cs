using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjetoLavi.Dominio.Helpers;

namespace ProjetoLavi.Dominio.Entities.Receitas
{
    public class Receita : EntityBase
    {
        [Key]
        public int ReceitaId { get; set; }

        public const int CodigoMaxLength = 10;
        public const int CodigoMinLength = 1;
        public string Codigo { get; private set; }

        public const int NomeMaxLength = 30;
        public const int NomeMinLength = 6;
        public string Nome { get; private set; }

        public const int ReceitaMinItens = 1;
        public virtual List<ReceitaItem> ReceitaItens { get; set; }

        protected Receita() { }

        public Receita(string codigo,string nome)
        {
            SetCodigo(codigo);
            SetNome(nome);
            DataCadastro = DateTime.Now;
        }

        public void SetCodigo(string codigo)
        {
            Guard.StringLength("Codigo", codigo, CodigoMinLength,CodigoMaxLength);
            Codigo = codigo;
        }

        public void SetNome(string nome)
        {
            Guard.StringLength("Nome", nome, NomeMinLength, NomeMaxLength);
            Nome = nome;
        }

        public void SetReceitaItem(List<ReceitaItem> itens)
        {
            Guard.ListLength("Itens de receita", itens.Count, ReceitaMinItens);
            ReceitaItens = itens;
        }
    }

}
