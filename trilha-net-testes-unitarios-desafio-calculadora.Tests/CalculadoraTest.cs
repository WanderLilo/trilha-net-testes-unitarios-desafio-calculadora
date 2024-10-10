using trilha_net_testes_unitarios_desafio_calculadora.console;

namespace trilha_net_testes_unitarios_desafio_calculadora.Tests
{
    public class CalculadoraTest
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 7)]
        public void TestarSomar(int num1, int num2,int resultado)
        {
            Calculadora _calculadora = new Calculadora();
            var resultadoCalculadora = _calculadora.Somar(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(8, 2, 6)]
        public void TestarSubtrair(int num1, int num2, int resultado)
        {
            Calculadora _calculadora = new Calculadora();
            var resultadoCalculadora = _calculadora.Subtrair(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(2, 5, 10)]
        public void TestarMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora _calculadora = new Calculadora();
            var resultadoCalculadora = _calculadora.Multiplicar(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(6, 3, 2)]
        public void TestarDividir(int num1, int num2, int resultado)
        {
            Calculadora _calculadora = new Calculadora();
            var resultadoCalculadora = _calculadora.Dividir(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora _calculadora = new Calculadora();

            _calculadora.Somar(1, 2);
            _calculadora.Somar(3, 4);
            _calculadora.Somar(5, 6);

            Assert.Equal(3,_calculadora.ObterHistorico().Count());      
        }



    }
}