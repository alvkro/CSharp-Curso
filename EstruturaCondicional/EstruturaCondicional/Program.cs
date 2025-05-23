using System;

namespace Curso
{
    class EstruturaLogica
    {
        static void Main(string[] args)
        {
            // Existem 3 tipos de estruturas lógicas: simples, compostas e encadeadas.

            int x = int.Parse(Console.ReadLine());

            // Simples:

            if (x > 5)
            {
                Console.WriteLine("Teste");
            }

            // Composta:
            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            // Encadeada:
            if (x == 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (x < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            // Utilizando o else-if, o programa testará apenas as condições necessárias,
            // ou seja, se a primeira funcionar, ela nem olha para as outras, otimizando o programa,
            // e não será necessário repetir a condição de novo, como no primeiro else-if, não sendo
            // necessário colocar x > 12 || x < 18, afinal, se foi para o else-if é porque a primera condição
            // deu False.
            }
        }
    }
