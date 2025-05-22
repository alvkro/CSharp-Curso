using System;

namespace Curso
{
    class EntradaDados
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine($"Você digitou: {frase}, {x}, {y}, {z}");

            //Para armazenar mais de um dado em uma mesma linha:
            string[] vet = Console.ReadLine().Split(' ');

            //Assim, o C# armazena as informações em um vetor (em colchetes)
            //usando uma array, e usa a função split para separar a partir do parâmetro
            //dado que é o espaço. Imagine que cada variável esteja sendo armazenada em uma lista
            //e tem uma ordem a partir do index, em termos de Python.

            string c1 = vet[0];
            string c2 = vet[1];
            string c3 = vet[2];

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

        }
    }
}