// Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
// uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
// que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
// para ser responsável pelos cálculos.

using ExercicioME1;
using System;

namespace Curso
{
    class DolarReal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cot_dolar = double.Parse(Console.ReadLine());    

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double qt = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.Converter(cot_dolar, qt)}");
        }
    }
}