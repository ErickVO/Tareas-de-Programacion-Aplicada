using System;

namespace Ejercicio3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0,apo = 0,r = 0, selec;
            string LLados, Nlados, Apotema, seleccion;
            float area;

            Console.WriteLine("Seleccione lo que desea buscar: " + "\n1. Perimetro" +"\n2. Area");
            seleccion = Console.ReadLine();
            selec = Convert.ToInt32(seleccion);

            Console.Clear();

            Console.WriteLine("Introduzca la Cantidad de lados:");
            Nlados = Console.ReadLine();
            Console.WriteLine("Introduzca la Longitud de un Lado:");
            LLados = Console.ReadLine();

            a = Convert.ToInt32(LLados);
            b = Convert.ToInt32(Nlados);

            if (selec == 1)
            {
                

                r = a * b;

                Console.WriteLine("El Perimetro es: {0}", r);
            }
            else if (selec == 2)
            {
                Console.WriteLine("Introduzca el Apotema:");
                Apotema = Console.ReadLine();
                apo = Convert.ToInt32(Apotema);

                area = (a * b * apo) / 2;

                Console.WriteLine("El Area es: {0}", area);
            }
            

        }
    }
}
