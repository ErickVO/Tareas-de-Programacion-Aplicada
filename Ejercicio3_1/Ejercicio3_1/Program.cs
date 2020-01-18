using System;

namespace Ejercicio3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string n;

            Console.WriteLine("Introduzca un Numero: ");
            n = Console.ReadLine();

            num = Convert.ToInt32(n);

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
