using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercício de Fixação - Entrada de Dados part 2 ");
            Console.WriteLine("Entre com seu nome ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos Quartos tem na sua casa? ");
            int QtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double PrecoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string LastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seus dados digitados foram: ");
            Console.WriteLine(nome);
            Console.WriteLine(QtdQuartos);
            Console.WriteLine(PrecoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(LastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
