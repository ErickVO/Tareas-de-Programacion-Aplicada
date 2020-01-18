using System;

namespace EjercicioPerimetroPoligono
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, r = 0;
            string LLados, Nlados;

            Console.WriteLine("Introduzca la Cantidad de lados:");
            Nlados = Console.ReadLine();
            Console.WriteLine("Introduzca la Longitud de un Lado:");
            LLados = Console.ReadLine();


            a = Convert.ToInt32(LLados);
            b = Convert.ToInt32(Nlados);

            r = a * b;

            Console.WriteLine("El Perimetro es: {0}",r);
            
        }
    }
}
