using System;
using System.Globalization;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tCalculadora de Adição");
            Console.WriteLine("Entre com o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = n1 + n2;
            Console.WriteLine("SOMA = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
