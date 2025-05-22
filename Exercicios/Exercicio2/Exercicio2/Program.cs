using System;
using System.Threading.Channels;

namespace Curso
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            //Nome Sobrenome
            string[] vet_ns = Console.ReadLine().Split(' ');
            string nome = vet_ns[0];
            string sobrenome = vet_ns[1];

            int quartos = int.Parse(Console.ReadLine());

            double preco = double.Parse(Console.ReadLine());

            //Idade altura
            string[] vet_ia = Console.ReadLine().Split(' ');
            int idade = int.Parse(vet_ia[0]);
            double altura = double.Parse(vet_ia[1]);


            Console.WriteLine($"{nome} {sobrenome}, {quartos}, {preco}, {sobrenome}, {idade} e {altura}");
        }
    }
}
