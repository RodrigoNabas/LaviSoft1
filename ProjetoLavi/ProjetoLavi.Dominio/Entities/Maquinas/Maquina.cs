using System;
using ProjetoLavi.Dominio.Enums;
using ProjetoLavi.Dominio.Helpers;
using ProjetoLavi.Dominio.ValueObjects;

namespace ProjetoLavi.Dominio.Entities.Maquinas
{
    public class Maquina
    {
        public int MaquinaId { get; private set; }

        public const int NomeMaxLength = 30;
        public const int NomeMinLength = 5;
        public string Nome { get; private set; }

        public const int DescricaoMaxLength = 100;
        public string Descricao { get; private set; }

        //public Ip IpMaquina { get; private set; }
        //public EnumTipoMaquina TipoMaquina { get; private set; }
        //public EnumModeloMaquina ModeloMaquina { get; private set; }
        public double Capacidade { get; private set; }
        //protected Maquina()
        //{

        //}

        //public Maquina(string nome, string descricao, Ip ipMaquina, EnumTipoMaquina tipoMaquina, EnumModeloMaquina modeloMaquina, double capacidade)
        //{
        //    SetNome(nome);
        //    SetCapacidade(capacidade);
        //    SetModeloMaquina(modeloMaquina);
        //    SetTipoMaquina(tipoMaquina);
        //    SetIpMaquina(ipMaquina);
        //    SetDescricao(descricao);
        //}

        //private void SetCapacidade(double capacidade)
        //{
        //    Guard.ValidarNaoNegativo(capacidade, "Capacidade");
        //    Capacidade = capacidade;
        //}

        //private void SetModeloMaquina(EnumModeloMaquina modeloMaquina)
        //{
        //    ModeloMaquina = modeloMaquina;
        //}

        //private void SetTipoMaquina(EnumTipoMaquina tipoMaquina)
        //{
        //    TipoMaquina = tipoMaquina;
        //}

        //public void SetNome(string nome)
        //{
        //    Guard.StringLength("Nome", nome, NomeMinLength, NomeMaxLength);
        //    Nome = nome;
        //}

        //public void SetDescricao(string descricao)
        //{
        //    Guard.StringLength("Descricao", descricao, DescricaoMaxLength);
        //    Descricao = descricao;
        //}

        //public void SetIpMaquina(Ip ipMaquina)
        //{
        //    if (ipMaquina == null)
        //        throw new Exception("Ip Obrigatório");
        //    IpMaquina = ipMaquina;
        //}
    }
}
