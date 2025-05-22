using System;
using System.Threading.Channels;

namespace Curso
{
    class EntradaDados2
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            //No C#, não é possível fazer conversão direta de string -> int.
            //por isso, utiliza-se a função Parse, para a conversão ser funcional.

            char ch = char.Parse(Console.ReadLine());
            double db = double.Parse(Console.ReadLine());

            Console.WriteLine($"Você digitou {n1}");
            Console.WriteLine($"Você digitou {ch}");
            Console.WriteLine($"Você digitou {db}");

            string[] vet = Console.ReadLine().Split(' ');

            //Nome, sexo, idade e altura.

            string i1 = vet[0];
            char i2 = char.Parse(vet[1]);
            int i3 = int.Parse(vet[2]);
            double i4 = double.Parse(vet[3]);

            Console.WriteLine($"Você digitou {i1}, {i2}, {i3} e {i4}");
        }
    }
}
