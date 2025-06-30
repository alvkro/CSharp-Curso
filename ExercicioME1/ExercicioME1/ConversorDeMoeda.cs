using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioME1
{
    internal class ConversorDeMoeda
    {
        public static Double Converter(double cot_dolar, double qt)
        {
            return (cot_dolar * qt) * 1.06;
        }
    }
}
