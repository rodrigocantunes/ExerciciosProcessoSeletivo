using NUnit.Framework;
using System;
using System.Linq;

namespace ExerciciosProcessoSeletivo.Test
{
    [TestFixture]
    public class ExerciciosTest
    {
        public string Data => DateTime.Now.ToString("d");
        [Test]
        public void Should_Exercicio1_ReturnFuncionariosAtivos()
        {
            Exercicio1 exercicio1 = new Exercicio1();
            var funcionarios = exercicio1.GetFuncionariosAtivos();
            Assert.That(funcionarios.All(x => !x.excluido));
        }

        [Test]
        public void Should_Exercicio2_OrdenarValores()
        {
            Exercicio2 exercicio2 = new Exercicio2();
            var codigosOrdenados = exercicio2.GetCodigosOrdenados(new int[] { 3, 2, 1});
            Assert.That(codigosOrdenados.SequenceEqual(new int[] { 1, 2, 3 }));
        }

        [Test]
        public void Should_Exercicio3_GerarClausula()
        {
            Exercicio3 exercicio3 = new Exercicio3();
            var clausula = exercicio3.GerarClausula("JOSE");
            var clasulaJose = "O FUNCIONÁRIO JOSE, É CONTRATADO PELA EMPRESA YPSUM\nPARA PRESTAR SERVIÇOS DE DESENVOLVEDOR. DATA: " + Data;
            Assert.That(clausula,Is.EqualTo(clasulaJose));
        }
    }
}
