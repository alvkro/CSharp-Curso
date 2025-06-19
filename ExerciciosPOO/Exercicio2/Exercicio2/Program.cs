using Exercicio2;
using System;
using System.Net.Http.Headers;

namespace Curso
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite o nome e o salário do primeiro funcionário: ");
            string[] dados1 = Console.ReadLine().Split();

            f1.Nome = dados1[0];
            f1.Salario = double.Parse(dados1[1]);

            Console.WriteLine("Digite o nome e o salário do segundo funcionário: ");
            string[] dados2 = Console.ReadLine().Split();

            f2.Nome = dados2[0];
            f2.Salario = double.Parse(dados2[1]);

            double media = (f1.Salario +  f2.Salario)/2;

            Console.WriteLine($"Média salarial: R${media.ToString("F2")}");


        }
    }
}
