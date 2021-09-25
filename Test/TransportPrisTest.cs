using DiplomOpgaver;
using Xunit;

namespace Test
{
    public class TransportPrisTest
    {
        [InlineData(4, 6, 0)]
        [InlineData(4, 10, 50)]
        [InlineData(6, 6, 75)]
        [InlineData(6, 11, 100)]

        [Theory]
        public void Kan_beregne_korrekt_transportpris(double km, double vaegt, int forventetPris)
        {
            // Arrange
            Transportpris beregner = new Transportpris();

            // Act
            double pris = beregner.BeregnTransportpris(km, vaegt);

            // Assert
            Assert.Equal(forventetPris, pris);
        }
    }
}

