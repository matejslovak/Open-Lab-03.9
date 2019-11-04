using System;

namespace Open_Lab_03_09
{
    class Program
    {
        public static bool IsPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                {
                    return false;
                }
                    return true;
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Enter number:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPrimeNumber(num));
        }
    }
}