using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoLavi.Dominio.Test
{
    [TestClass]
    public class TestHelper
    {
        [TestMethod]
        public void TestHelper_CriaParametro()
        {
            var resultado = CriarParametro(5);
            Assert.AreEqual(5, resultado.Length);
        }

        public static string CriarParametro(int tamanhoParametro)
        {
            var parametro = new StringBuilder();
            for (var i = 1; i <= tamanhoParametro; i++)
                parametro.Append("0");

            return parametro.ToString();
        }
    }
}
