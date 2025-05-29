using System;
using System.Threading.Channels;

namespace Curso
{
    class Funcoes
    {
        // Funções são processamentos que significam algo (Math, Max... [se lembre de Python]
        // Ajudam a modularizar e reaproveitar codigos.
        // Em POO, as funções serão chamadas de "métodos".
        static void Main(string[] args) // Isso aqui é uma função, que indica o entry point da aplicação.
        {
            string[] num3s = Console.ReadLine().Split();
            double x = double.Parse(num3s[0]);
            double y = double.Parse(num3s[1]);
            double z = double.Parse(num3s[2]);

            // Sem funções:

            if (x > y && x > z)
            {
                Console.WriteLine($"O maior é {x}");
            }
            else if (y > z)
            {
                Console.WriteLine($"O maior é {y}");
            }
            else
            {
                Console.WriteLine($"O maior é {z}");
            }

            // Com função:

            double resultado = Greater(x, y, z);

            Console.WriteLine($"O maior é {resultado}");
        }
        static double Greater( double x, double y, double z )
        {
            double g;

            if (x > y && x > z)
            {
                g = x;
            }
            else if (y > z)
            {
                g = y;
            }
            else
            {
                g = z;
            }
            return g;
        }
    }
}