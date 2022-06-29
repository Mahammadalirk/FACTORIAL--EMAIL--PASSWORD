using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            ulong number = (ulong)Convert.ToInt32(Console.ReadLine());
            ulong factorial = 1;
            for (ulong i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(number + "! = " + factorial);

            Console.ReadLine();
        }
    }
}
