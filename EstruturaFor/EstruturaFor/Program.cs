using System;

namespace Curso
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            // FUNCIONAMENTO DA ESTRUTURA FOR:
            // for (inicio [executa uma vez] ; condição ; incremento)
            //{
            //  comando 1
            //  comando 2
            //}
            // P/ condição: True -> executa e volta / False -> pula fora

            Console.Write("Quantos números você vai digitar? :");
            int n = int.Parse(Console.ReadLine());

            int soma_n = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}:  ");
                int valor = int.Parse(Console.ReadLine());
                soma_n += valor;
            }

            Console.WriteLine($"Total: {soma_n}");
        }
    }
}