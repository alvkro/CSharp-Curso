//  MEMBROS ESTÁTICOS: São membros que fazem sentido independentemente de objetos. Não
//  precisam de objeto para serem chamados. São chamados a partir do
//  próprio nome da classe. A função Math.Sqrt pode ser considerada um membro estático, o programa
//  que calculava a área do triângulo, por exemplo, era de instância, afinal, o valor do triângulo mudava
//  de acordo com o valor do objeto.

using MembrosEstaticos;
using System;

namespace Curso
{
    class MembrosEstaticos
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {vol.ToString("F2")}");
        }
    }
}