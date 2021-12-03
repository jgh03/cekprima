using System;

namespace cekprima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input bilangan:");
            int bilangan = Convert.ToInt32(Console.ReadLine());
            if (bilangan > 0 && bilangan % 2 == 1)
            {
                Console.Write("bilangan prima");
            }
            else
            {
                Console.Write("bukan bilangan prima");
            }
        }
    }
}
