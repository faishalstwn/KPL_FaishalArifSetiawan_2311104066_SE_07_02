using Xunit;
using jurnalmodul12_2311104066;

namespace jurnalmodul12_2311104066.Tests
{
    public class Form1Tests
    {
        [Theory]
        [InlineData(2, 3, 8)]       // Normal
        [InlineData(2, 0, 1)]       // b = 0
        [InlineData(2, -1, -1)]     // b negatif
        [InlineData(101, 3, -2)]    // a > 100
        [InlineData(2, 11, -2)]     // b > 10
        public void CariNilaiPangkat_ValidCases_ReturnsExpected(int a, int b, int expected)
        {
            int result = Form1.CariNilaiPangkat(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CariNilaiPangkat_Overflow_ReturnsNegativeThree()
        {
            int result = Form1.CariNilaiPangkat(9, 30); // Ini memicu overflow
            Assert.Equal(-3, result);
        }
    }
}
