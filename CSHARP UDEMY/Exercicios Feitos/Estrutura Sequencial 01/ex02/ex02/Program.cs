using System;
using System.Globalization;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;

            Console.WriteLine("Calcular o raio de um círculo");
            Console.WriteLine("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double FormulaRaio = PI * Math.Pow(raio, 2);

            Console.WriteLine("A = " + FormulaRaio.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
