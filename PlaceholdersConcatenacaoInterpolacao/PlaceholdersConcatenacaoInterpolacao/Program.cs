using System;
using System.Globalization;

namespace PCI
{
    class PlaceConcaInter
    {
        static void Main(string[] args)
        {
            int idade = 22;
            double saldo = 22.5751;
            string name = "Fulano";

            //Via Placeholder:
            Console.WriteLine("{0} tem {1} anos e possui {2:F2} reais.", name, idade , saldo);

            //Via Interpolação:
            Console.WriteLine($"Seu nome é {name}, tem {idade} anos e possui um saldo de {saldo:F2}");

            //Via concatenação de strings (arcaico):
            Console.WriteLine(name + " tem " + idade + "anos de idade e possui um saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            //Via F-String:
            string msg = $"Seu nome é {name}, tem {idade} anos e possui um saldo de {saldo}";
            Console.WriteLine(msg);//O F-String do C# usa o símbolo de $, semelhante a interpolação.
        }
    }
}
