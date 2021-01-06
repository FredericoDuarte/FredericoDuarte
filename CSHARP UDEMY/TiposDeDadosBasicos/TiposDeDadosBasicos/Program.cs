using System;
using System.Globalization;

namespace TiposDeDadosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char sexo = 'f';
            char letra = '\u0041'; // Letra A em unicode
            sbyte x = 100; //de -128 vai até 127
            byte n1 = 126; // vai até 255
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // Especificar que estou trabalhando com long
            float n5 = 4.5f; // Especificando que é um float
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = 4.5f;  // Tipo de dado genérico e pode receber qualquer valor e tipo de dado


            Console.WriteLine(completo);
            Console.WriteLine(sexo);
            Console.WriteLine(letra);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);

            decimal teste = decimal.MaxValue;
            Console.WriteLine(teste);

            double saldo = 10.4565;

            Console.WriteLine(saldo.ToString("F2")); // para imprimir com 2 casas decimais 
            Console.WriteLine(saldo.ToString("F4")); // imprimir com 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // para imprimir com . separando as casas decimais ao invez da ,  e 4 casas decimais

            int idade = 32;
            string nome_ = "Maria Green";

            // Place Holder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome_, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome_} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");


        }
    }
}
