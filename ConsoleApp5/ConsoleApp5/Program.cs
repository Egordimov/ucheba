using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("largest number : " + num1);
                }
                else
                {
                    Console.WriteLine("largest number : " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("largest number : " + num2);
                }
                else
                {
                    Console.WriteLine("largest number : " + num3);
                }

            }
        }
    }    
}