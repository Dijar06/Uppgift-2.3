using System;

namespace Uppgift2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra en lamborghini?");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer tänker du köra?");
            float y = float.Parse(Console.ReadLine());
            float z = 300 + 1 * y + 500 * x - 500;
            Console.WriteLine("Priset blir totalt " + z + " kronor");
        }
    }
}