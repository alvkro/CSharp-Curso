using System;

namespace Curso
{
    class OperadoresLogicos
    {
        static void Main(string[] args)
        {
            //OPERADORES LÓGICOS EM C#:
            //&&: E
            //||: OU
            //!: NÃO

            bool c1 = 2 > 3 && 4 != 5; // false
            bool c2 = !(2>3) && 4 != 5; // true
            bool c3 = c2 || c1; // true
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}
