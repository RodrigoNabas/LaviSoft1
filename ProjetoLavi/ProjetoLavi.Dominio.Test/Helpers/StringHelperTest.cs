using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoLavi.Dominio.Helpers;

namespace ProjetoLavi.Dominio.Test.Helpers
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void StringHelper_Deve_RemoverAcentos()
        {
            Assert.AreEqual("aaaa",StringHelper.RemoverAcentos("ãáâà"));
        }

        [TestMethod]
        public void StringHelper_Deve_Retornar_apenas_numeros()
        {
            Assert.AreEqual("321", StringHelper.GetNumeros("teste 321"));
        }
        [TestMethod]
        public void StringHelper_Deve_Retornar_stringvazia()
        {
            Assert.AreEqual("", StringHelper.GetNumeros("teste"));
        }

        [TestMethod]
        public void StringHelper_Deve_Retornar_Primeira_letra_maiuscula()
        {
            Assert.AreEqual("Mais Um Teste", StringHelper.ToTitleCase("mais um teste"));
        }

        [TestMethod]
        public void StringHelper_Deve_Retornar_Primeira_letra_maiuscula_de_texto_todo_maiusculo()
        {
            Assert.AreEqual("Mais Um Teste", StringHelper.ToTitleCase("MAIS UM TESTE",false));
        }

        [TestMethod]
        public void StringHelper_Deve_manter_o_texto_original()
        {
            Assert.AreEqual("MAIS UM TESTE", StringHelper.ToTitleCase("MAIS UM TESTE", true));
        }
    }
}
