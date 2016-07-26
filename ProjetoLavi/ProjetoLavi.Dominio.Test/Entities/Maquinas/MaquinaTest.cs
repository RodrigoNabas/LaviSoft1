//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ProjetoLavi.Dominio.Entities.Maquinas;
//using ProjetoLavi.Dominio.Enums;
//using ProjetoLavi.Dominio.ValueObjects;

//namespace ProjetoLavi.Dominio.Test.Entities.Maquinas
//{
//    [TestClass]
//    public class MaquinaTest
//    {
//        //TODO : Concluir testes para todos os métodos da classe Maquina
//        private const string DescricaoMaquina = "Descricao Teste";
//        private const string NomeMaquina = "Nome de Teste";
//        private const double Capacidade = 40.0d;
//        private readonly Ip _ipMaquina = new Ip("192.168.1.1");

//        private Maquina Maquina { get; }

//        public MaquinaTest()
//        {
//            Maquina = new Maquina(NomeMaquina,DescricaoMaquina,_ipMaquina,EnumTipoMaquina.Lavadora,EnumModeloMaquina.F200, Capacidade);
//        }

//        [TestMethod]
//        public void Maquina_Nome_valido()
//        {

//            Assert.AreEqual(NomeMaquina,Maquina.Nome);
//        }

//        [TestMethod]
//        public void Maquina_Descricao_valida()
//        {
//            Assert.AreEqual(DescricaoMaquina, Maquina.Descricao);
//        }

//        [TestMethod]
//        public void Maquina_Ip_valido()
//        {
//            Assert.AreEqual(_ipMaquina, Maquina.IpMaquina);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void Maquina_SetNome_Validar_tamanho_minimo()
//        {
//            new Maquina("Maq",DescricaoMaquina,_ipMaquina,EnumTipoMaquina.Lavadora, EnumModeloMaquina.F30, Capacidade);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void Maquina_SetNome_Validar_tamanho_Maximo()
//        {
//            var nomeMaquina = TestHelper.CriarParametro(Maquina.NomeMaxLength + 1);

//            new Maquina(nomeMaquina, DescricaoMaquina, _ipMaquina, EnumTipoMaquina.Lavadora, EnumModeloMaquina.F30, Capacidade);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void Maquina_SetDescricao_Validar_tamanho_Maximo()
//        {
//            var descMaquina = TestHelper.CriarParametro(Maquina.DescricaoMaxLength + 1);

//            new Maquina(NomeMaquina, descMaquina, _ipMaquina, EnumTipoMaquina.Lavadora, EnumModeloMaquina.F30, Capacidade);
//        }

//        [TestMethod]
//        public void Maquina_SetDescricao_Deve_Atribuir_a_capacidade()
//        {
//            var maquina = new Maquina(NomeMaquina, DescricaoMaquina, _ipMaquina, EnumTipoMaquina.Lavadora, EnumModeloMaquina.F30, Capacidade);
//            Assert.AreEqual(Capacidade, maquina.Capacidade);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void Maquina_SetDescricao_GerarErro_capacidade_Negativa()
//        {
//            new Maquina(NomeMaquina, DescricaoMaquina, _ipMaquina, EnumTipoMaquina.Lavadora, EnumModeloMaquina.F30, -0.01);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void Maquina_SetIpMaquina_GerarErro_ipMaquina_nulo()
//        {
//            new Maquina(NomeMaquina, DescricaoMaquina, null, EnumTipoMaquina.Lavadora, EnumModeloMaquina.F30, Capacidade);
//        }
//    }
//}
