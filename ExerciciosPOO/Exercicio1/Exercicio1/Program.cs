using Exercicio1;
using System;

namespace Curso
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa(); // Aqui, p1  recebe os dois atributos da classe Pessoa (Nome e idade).
            p2 = new Pessoa(); // O mesmo ocorre aqui.

            Console.Write("Digite o primeiro nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            //

            Console.Write("Digite o segundo nome: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade >  p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} é mais velho(a).");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} é mais velho(a).");
            }
        }
    }
}