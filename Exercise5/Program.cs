using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Enter 5 numbers");
            for(int i = 1; i <=5; i++)
            {
                Console.WriteLine("");
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            double avarage = sum / 5;
            Console.WriteLine($"The average is:{avarage}");
        }
    }
}
