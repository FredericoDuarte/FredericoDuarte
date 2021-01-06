using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;

            a = 5.1;
            b = (float)a; // Fazendo casting de double para float
            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double)e / f; // Se não tiver o casting o resultado será somente 2  ***

            Console.WriteLine(resultado);




        }
    }
}
