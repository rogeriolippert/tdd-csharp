using System;
using Xunit;
using lib;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculadora calc = new Calculadora();
            int r = calc.Soma(2,3);
            Assert.Equal(5, r);
        }
    }
}
