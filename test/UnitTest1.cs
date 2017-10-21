using System;
using Xunit;
using lib;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void SomaDoisInteiros()
        {
            Calculadora calc = new Calculadora();
            int r = calc.Soma(2,3);
            Assert.Equal(5, r);
        }
        [Fact]
        public void SomaSemParametro()
        {
            Calculadora calc = new Calculadora();
            int r = calc.Soma();
            Assert.Equal(0, r);
        }
    }
}
