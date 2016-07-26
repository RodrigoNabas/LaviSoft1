using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoLavi.Dominio.Helpers;

namespace ProjetoLavi.Dominio.Test.Helpers
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Em_Branco()
        {
            Guard.ForNullOrEmpty("", "valor não pode ser vazio!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Null()
        {
            Guard.ForNullOrEmpty(null, "valor não pode ser vazio!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ValidarNaoNegativo_Erro_Quando_negativo()
        {
            Guard.ValidarNaoNegativo(-1,"Propriedade");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ValidarNaoNegativo_Erro_Quando_negativo_double()
        {
            Guard.ValidarNaoNegativo(-0.1d, "Propriedade");
        }
    }
}
