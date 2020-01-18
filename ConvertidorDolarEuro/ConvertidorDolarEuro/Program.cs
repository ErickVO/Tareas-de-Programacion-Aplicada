using System;

namespace ConvertidorDolarEuro
{
    class Program
    {
        static void Main(string[] args)
        {
            float DolarDia, EuroDia, Cantidad, cambioDolar,cambioEuro,DvE,EvD;
            string a,b,c;

            Console.WriteLine("Dolar al Dia: ");
            a = Console.ReadLine();

            Console.WriteLine("Euro al Dia: ");
            b = Console.ReadLine();

            Console.WriteLine("Cantidad a Cambiar");
            c = Console.ReadLine();

            DolarDia = Convert.ToSingle(a);
            EuroDia = Convert.ToSingle(b);
            Cantidad = Convert.ToSingle(c);

            cambioDolar = DolarDia * Cantidad;
            cambioEuro = EuroDia * Cantidad;

            DvE = DolarDia / EuroDia;
            EvD = EuroDia / DolarDia;

            Console.WriteLine("Cambio Dolar: {0}", cambioDolar);
            Console.WriteLine("Cambio Euro: {0}", cambioEuro);
            Console.WriteLine("Valor de Dolar vs Euro: {0}", DvE);
            Console.WriteLine("Valor de Euro vs Dolar: {0}", EvD);

        }
    }
}
