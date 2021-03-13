using System;

namespace ActOptativa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a = 0, b = 0;
            
            Console.WriteLine("Digite el valor a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Restando {a} - {b} es igual a:  {AddNumbers(a,b)} ");
        }

        public static int AddNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
