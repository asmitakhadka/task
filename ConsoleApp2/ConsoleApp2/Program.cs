using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first name");
            string name1 = Console.ReadLine();

            Console.WriteLine("please enter your last name");
            string name2 = Console.ReadLine();
            
            Console.Writeline({name1} + {name2});
            
            
        }
    }
}
