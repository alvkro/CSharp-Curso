using System;
using System.Threading.Channels;

namespace Curso
{
    class Exercicio4
    {
        static void Main(string[] args)
        {

            while (true)
            {

                string[] coordenadas = Console.ReadLine().Split(' ');

                int x = int.Parse(coordenadas[0]);
                int y = int.Parse(coordenadas[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    break;
                }
            }
        }
    }
}