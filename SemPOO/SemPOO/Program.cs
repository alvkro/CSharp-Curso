using System;

namespace Curso 
{ 
    class SemPoo
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com as medidas do triângulo X: ");
            string[] medida_x = Console.ReadLine().Split();

            // COORDENADAS (x):

            double x1 = double.Parse(medida_x[0]);
            double x2 = double.Parse(medida_x[1]);
            double x3 = double.Parse(medida_x[2]);

            // CÁLCULOS (x):

            double px = (x1 + x2 + x3) / 2;
            double area_x = Math.Sqrt(px*(px - x1) * (px - x2) * (px - x3));

            Console.Write("Entre com as medidas do triângulo Y: ");
            string[] medida_y = Console.ReadLine().Split();

            // COORDENADAS (y):

            double y1 = double.Parse(medida_y[0]);
            double y2 = double.Parse(medida_y[1]);
            double y3 = double.Parse(medida_y[2]);

            // CÁLCULOS (y):

            double py = (y1 + y2 + y3) / 2;
            double area_y = Math.Sqrt(py * (py - y1) * (py - y2) * (py - y3));

            Console.WriteLine($"Área de X: {area_x.ToString("F3")}");
            Console.WriteLine($"Área de Y: {area_y.ToString("F3")}");

            if (area_x > area_y)
            {
                Console.WriteLine("X possui maior área.");
            }
            else
            {
                Console.WriteLine("Y possui maior área.");
            }
        }
    }
}
