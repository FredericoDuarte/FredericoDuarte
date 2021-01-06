using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine(); // Forma de receber a frase digitada pelo telcado
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] v = Console.ReadLine().Split(' '); // Estou separando uma string em 3 outras pelo espaço em branco
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
