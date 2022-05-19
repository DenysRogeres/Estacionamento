using Estacionamento.Modelos;
using System;
using Xunit;

namespace Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void Acelerar_Tempo10Segundos_RetornaVelocidade100()
        {
            var veiculo = new Veiculo();
            veiculo.Acelerar(10);

            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void Frear_Tempo10Segundos_RetornarVelocidade150Negativo()
        {
            var veiculo = new Veiculo();
            veiculo.Frear(10);

            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}
