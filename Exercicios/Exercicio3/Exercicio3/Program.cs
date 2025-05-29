using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Curso
{
    class Exercicio3
    {
        static void Main(string[] args) 
        {
            string[] xy = Console.ReadLine().Split(' ');
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);

            // Origem:

            if(x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }

            // O resto:

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

            // Eixos:

            if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
        } 
    }
}
