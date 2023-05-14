using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            /* Teste Classe Adicionar 2 Números */
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            }

            /* Teste Classe Multiplicar 2 Números */
            [Test]
            public void DeveMultiplicarDoisNumertos()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Multiplicar(5, 3);

                Assert.That(resultado, Is.EqualTo(15));
            }
        }
    }
}
