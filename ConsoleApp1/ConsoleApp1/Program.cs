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

            Console.Write("What is your favorite Color?");

            var respone = Console.ReadLine();

            Console.Write("You said your favorite color was " + respone + ".");

            Console.ReadLine();
        }
    }
}
