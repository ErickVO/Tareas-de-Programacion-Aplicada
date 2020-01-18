using System;

namespace GradosRadianes
{
    class Program
    {
        private const int radianes = 180;
        static void Main(string[] args)
        {
            float grados = 0, resultado = 0;
            string a;

            Console.WriteLine("Introduzca los Grados: ");
            a = Console.ReadLine();

            grados = Convert.ToSingle(a);

            resultado = grados / radianes;

            Console.Write("Los Radianes son: {0}", resultado + " Radianes");

        }
    }
}
