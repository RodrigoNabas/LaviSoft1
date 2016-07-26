using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoLavi.Dominio.Entities.Receitas;

namespace ProjetoLavi.Dominio.Test.Entities.Receitas
{
    [TestClass]
    public class ReceitaTest
    {
        // TODO : Concluir Testes Classe Receita
        private const string NomeReceita = "Receita Teste";
        private const string CodigoReceita = "1234567";

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Receita_SetCodigo_Deve_validar_tamanho_da_propriedade_codigo_maior_que_permitido()
        {
            var codigo = TestHelper.CriarParametro(Receita.CodigoMaxLength + 1);
            new Receita(codigo, NomeReceita);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Receita_SetCodigo_Deve_validar_ao_passar_vazio()
        {
            new Receita(" ", NomeReceita);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Receita_SetCodigo_Deve_validar_tamanho_da_propriedade_nome_maior_que_permitido()
        {
            var nome = TestHelper.CriarParametro(Receita.NomeMaxLength + 1);
            new Receita(CodigoReceita, nome);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Receita_SetCodigo_Deve_validar_tamanho_da_propriedade_nome_menor_que_permitido()
        {
            var nome = TestHelper.CriarParametro(Receita.NomeMinLength - 1);
            new Receita(CodigoReceita, nome);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Receita_SetCodigo_Deve_validar_ao_passar_nome_vazio()
        {
            new Receita(CodigoReceita, " ");
        }
    }
}
