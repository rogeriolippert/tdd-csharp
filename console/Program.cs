using System;
using lib;
namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Calculadora calc = new Calculadora();
            int r = calc.Soma(2,3);
            Console.WriteLine(r);
        }
    }
}
