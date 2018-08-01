using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please input another number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));

            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));

            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));

        }
    }
}
