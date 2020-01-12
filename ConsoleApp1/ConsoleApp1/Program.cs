using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Store name and place to variables, then display them using string interpolation
            string name = "Trevor";
            string place = "Utah";
            var date = DateTime.Now;
            Console.WriteLine("My name is {0}!", name);
            Console.WriteLine("I am from {0}.",place);
            Console.WriteLine("Today is {0}, the date is {1:MMM-dd-yyyy}",date.DayOfWeek, date);

            //Calculate days until Christmas 2020
            DateTime endTime = new DateTime(2020, 12, 25, 0, 0, 0);
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            Console.WriteLine("There are {0:dd} days until Christmas 2020", ts);

            // Paste the code from 2.1 in the C# Programming Yellow Book
            // Add Text labels to input
            //Add pause so program doesn't close when complete

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("What is the width of your box in meters?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("What is the height of your box in meters?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();
        }
    }
}
