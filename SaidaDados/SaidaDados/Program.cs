using System;
using System.Globalization; // "Universaliza" o código (lembre-se de geografia)

namespace Dados
{
    class SaidaDados
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 23;
            double saldo = 23.75234;
            string nome = "Maria";

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde"); //WriteLine inclui uma quebra de linha
            Console.WriteLine("Boa noite");
            Console.WriteLine("------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));                               //Esse comando ToString() serve para especificar a precisão
            Console.WriteLine(nome);                                               //das casas decimais e arredonda, semelhante ao :.2f do Python :)
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //Essa função CultureInfo.InvariantCulture serve justamente para tirar a 
        }                                                                          //vírgula e colocar o ponto, "deslocaliza" o programa e torna-o "universal" :P
        
    }
}

