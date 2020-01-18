using System;

namespace Ejercicio4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string num;

            Console.WriteLine("Introduzca un Numero: ");
            num = Console.ReadLine();
            n = Convert.ToInt32(num);

            Console.Clear();
            Console.WriteLine("Tabla de Multiplicacion del {0}", n);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(n + "x" + i + "= " + (n * i));
            }

        }
    }
}
