using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoLavi.Dominio.ValueObjects;

namespace ProjetoLavi.Dominio.Test.ValueObjects
{
    [TestClass]
    public class EmailTest
    {
        private const string EnderecoEmail = "lucas@gmail.com";
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Set_Email_Em_Branco()
        {
            new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Set_Email_Null()
        {
            new Email(null);
        }

        [TestMethod]
        public void Email_Set_Email_Valido()
        {

            var email = new Email(EnderecoEmail);
            Assert.AreEqual(EnderecoEmail, email.Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Set_Email_Invalido()
        {
            new Email("sdfgsdbglsdkjbgsdlkgb");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Set_Email_Erro_MaxLength()
        {
            var email = new StringBuilder();
            while (email.Length < Email.EnderecoMaxLength + 1)
            {
                email.Append($"{EnderecoEmail}lucas@gmail.com.br");
            }

            new Email(email.ToString());
        }
    }
}
