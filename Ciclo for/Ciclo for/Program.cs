using System;

namespace Ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Ingresa el numero con el que quieres que inicie el ciclo:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el numero con el que quieres que finalice el ciclo:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el numero con el que quieres que tu ciclo avance:");
            z = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= y; i+=z)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
