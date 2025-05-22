using System;
using System.Globalization;

namespace Exercicio1
{
    class Programa
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            string produto1 = "Computador";
            string produto2 = "Mesa";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650;
            double medida = 53.234567;

            //OUTPUT
            Console.WriteLine("PRODUTOS:");
            Console.WriteLine($"{produto1} - R${preco1}");
            Console.WriteLine($"{produto2} - R${preco2}");
            Console.WriteLine($"");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero {genero}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}