using System;

namespace Curso
{
    class While
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um número: ");
                double num = double.Parse(Console.ReadLine());

                double sqrt = Math.Sqrt(num);

                if (sqrt > 0)
                {
                    Console.WriteLine($"A raiz quadrada de {num} é {sqrt.ToString("F3")}");
                }
                else
                {
                    Console.WriteLine("Raiz negativa");
                    break;
                }
            }
        }
    }
}