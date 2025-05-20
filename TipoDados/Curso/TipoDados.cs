using System;

namespace Curso{
    internal class TipoDados{
        static void Main(string[] args){
            bool completo = false;
            char genero = 'f'; 
            char letra = '\u0041'; // É possível colocar o código unicode também.

            byte n1 = 255; //Overflow: cálculo estrapola o limite. Se estrapolar
                           //o número vai para o limite oposto.
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Alvaro"; //String no C# é imutável (seguro, simples e threadsafe)
            object obj1 = "Renilliene";
            object obj2 = 4.5f;
            //OBS: Para saber o valor mínimo ou máximo de um dado, usa-se a função MinValue e MaxValue, respectivamente.

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4); //cw tab tab
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}