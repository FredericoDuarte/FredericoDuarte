using System;
using System.Globalization;

namespace EntradaDeDadosPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler numero inteiro
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + n1);

            //Ler char
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + ch);

            //Ler double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // aceita .
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            //Receber varios dados de uma vez só e separar em variáveis com Split
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
