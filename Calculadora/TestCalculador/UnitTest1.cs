using Controller;

namespace TestCalculador
{
    public class UnitTest1
    {
        Calculadora calculadora = new Calculadora();

        [Fact]
        public void Deve_Retornar_Valor_3_Ao_Somar()
        {
            var resultadoSoma = calculadora.Soma(1, 2);

            Assert.Equal(3, resultadoSoma);
        }

        [Theory]
        [InlineData(3,2,1)]
        [InlineData(5,3,2)]
        public void Deve_Retornar_Valor_Esperado_Ao_Subtrair(int val1,int val2, int val3)
        {
            var resultadoSubtracao = calculadora.Subtracao(val1, val2);

            Assert.Equal(val3, resultadoSubtracao);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(5, 3, 15)]
        public void Deve_Retornar_Valor_Esperado_Ao_Multiplicar(int val1, int val2, int val3)
        {
            var resultadoMultiplicacao = calculadora.Multiplacao(val1, val2);

            Assert.Equal(val3, resultadoMultiplicacao);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(9, 3, 3)]
        public void Deve_Retornar_Valor_Esperado_Ao_Dividir(int val1, int val2, int val3)
        {
            var resultadoDivisao = calculadora.Divisao(val1, val2);

            Assert.Equal(val3, resultadoDivisao);
        }

        [Fact]
        public void Deve_Retornar_Historico_Da_Calculadora_Com_As_Ultimas_3_Operacoes()
        {
            List<string> historicoEsperado = new List<string>();
            historicoEsperado.Add("1 + 2 = 3");
            historicoEsperado.Add("2 - 1 = 1");
            historicoEsperado.Add("1 * 2 = 2");
            
            calculadora.Soma(5, 4);
            calculadora.Soma(1, 2);
            calculadora.Subtracao(2, 1);
            calculadora.Multiplacao(1, 2);

            var resultadoHistorico = calculadora.RetornarHistorico();

            Assert.Equal(historicoEsperado, resultadoHistorico);
        }
    }
}