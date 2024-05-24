using NewTalents;
using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            Calculadora calc = new Calculadora(DateTime.Now.ToShortDateString());
            return calc;
        }
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void DeveSomarDoisNumerosERetornarResultadoEsperado(int n1, int n2, int res)
        {
            //Arrange
            Calculadora _calc = ConstruirClasse();


            //Act
            var resultado = _calc.Somar(n1, n2);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void DeveSubtrairDoisNumerosERetornarResultadoEsperado(int n1, int n2, int res)
        {
            //Arrange
            Calculadora _calc = ConstruirClasse();


            //Act
            var resultado = _calc.Subtrair(n1, n2);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void DeveMultiplicarDoisNumerosERetornarResultadoEsperado(int n1, int n2, int res)
        {
            //Arrange
            Calculadora _calc = ConstruirClasse();


            //Act
            var resultado = _calc.Multiplicar(n1, n2);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(4, 5, 0)]
        public void DeveDividirDoisNumerosERetornarResultadoEsperado(int n1, int n2, int res)
        {
            //Arrange
            Calculadora _calc = ConstruirClasse();


            //Act
            var resultado = _calc.Dividir(n1, n2);

            //Assert
            Assert.Equal(res, resultado);
        }
        [Fact]
        public void TestarDivisaoPor0()
        {
            Calculadora _calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora _calc = ConstruirClasse();

            _calc.Somar(1, 2);
            _calc.Somar(3, 6);
            _calc.Somar(4, 8);
            _calc.Somar(8, 10);

            var lista = _calc.historico();


            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
