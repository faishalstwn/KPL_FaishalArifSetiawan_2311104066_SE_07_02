using Xunit;
using tpmodul12_2311104066;

namespace tpmodul12_xUnitTests
{
    public class Form1Tests
    {
        [Theory]
        [InlineData(-99, "Negatif")]
        [InlineData(0, "Nol")]
        [InlineData(42, "Positif")]
        public void CariTandaBilangan_ReturnsExpectedResult(int input, string expected)
        {
            string actual = Form1.CariTandaBilangan(input);
            Assert.Equal(expected, actual);
        }
    }
}
