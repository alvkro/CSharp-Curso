using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{

    // Ao usar static, não é necessário criar um objeto, da para acessar diretamente da classe Calculadora
    // afinal, tanto faz usar calc1 quando calc2, o resultado será o mesmo.
    internal class Calculadora
    {
        public static Double pi = 3.14;

        public static Double Circunferencia(double raio)
        {
            return 2 * pi * raio;
        }

        public static Double Volume(double raio)
        {
            return 4 / 3 * pi * Math.Pow(raio, 3);
        }
    }
}
