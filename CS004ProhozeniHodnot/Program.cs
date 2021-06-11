using System;

namespace CS004ProhozeniHodnot
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo1, cislo2, docasne;
            Console.WriteLine("Zadej první číslo: ");
            cislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo: ");
            cislo2 = int.Parse(Console.ReadLine());
            docasne = cislo1;
            cislo1 = cislo2;
            cislo2 = docasne;
            Console.WriteLine("\nPO PROHOZENÍ: ");
            Console.WriteLine("První číslo: " + cislo1);
            Console.WriteLine("Druhé číslo: " + cislo2);
            Console.ReadKey();
        }
    }
}
