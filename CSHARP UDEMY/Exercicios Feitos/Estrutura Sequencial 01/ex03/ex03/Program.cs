using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Entre com 4 valores separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            int n3 = int.Parse(vet[2]);
            int n4 = int.Parse(vet[3]);

            int diferenca = ((n1 * n2) - (n3 * n4));

            Console.WriteLine("DIFERENÇA = " + diferenca);
        }
    }
}
