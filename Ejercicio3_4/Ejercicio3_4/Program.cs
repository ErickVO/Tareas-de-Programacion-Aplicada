using System;

namespace Ejercicio3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string n;

            Console.WriteLine("Introduzca un Numero del 1 al 7: ");
            n = Console.ReadLine();

            num = Convert.ToInt32(n);

            if(num == 1)
            {
                Console.WriteLine("Lunes");

            }else if (num == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (num == 3)
            {
                Console.WriteLine("Miercoles");
            }
            else if (num == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if(num == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (num == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (num == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
                Console.WriteLine("Numero no existente");
        }
    }
}
