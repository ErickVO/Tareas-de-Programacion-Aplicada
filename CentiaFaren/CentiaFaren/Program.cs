using System;

namespace CentiaFaren
{
    class Program
    {
        private const float constante1 = 1.8f;
        private const float constante2 = 32;
        static void Main(string[] args)
        {
            float a, resultado;
            string Celcius;

            Console.WriteLine("Introduzca los grados Celsius: ");
            Celcius = Console.ReadLine();

            a = Convert.ToSingle(Celcius);

            resultado = (a * constante1) + constante2;

            Console.Write("Celsius a Farenheit: {0}",resultado  + " F");
        }
    }
}
