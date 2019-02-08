using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        int Peri(int a, int b, int c)
        {
            return a + b + c;
        }
        [Fact]
        public void Peri_WorksWithThreePositiveIntegers()
        {
            var expected = 6;
            var a = 2;
            var b = 2;
            var c = 2;
            var actual = Peri(a, b, c);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(6, 2, 2, 2)]
        [InlineData(12, 3, 4, 5)]
        [InlineData(9, 3, 3, 3)]
        public void Peri_WorksWithManyInputs(int exp, int n1, int n2, int n3)
        {
            Assert.Equal(exp, Peri(n1, n2, n3));
        }

    }
}
