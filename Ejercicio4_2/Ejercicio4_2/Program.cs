using System;

namespace Ejercicio4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bas,pot, i = 0,r = 1;
            string b,p;

            Console.WriteLine("Introduzca una base");
            b = Console.ReadLine();
            bas = Convert.ToInt32(b);
            Console.WriteLine("Introduzca una potencia");
            p = Console.ReadLine();
            pot = Convert.ToInt32(p);

            do
            {
                r = bas * r;
                
               i++;                

            } while (i != pot);
            Console.WriteLine("El Resultado es: {0}", r);
        }
    }
}
