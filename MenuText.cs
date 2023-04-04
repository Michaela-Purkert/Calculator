using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MenuText
    {
        public void MenuOptions()
        {
            Console.WriteLine("Choose an option:");

            Console.WriteLine("1 - Choose first number");
            Console.WriteLine("2 - Choose second number");
            Console.WriteLine("3 - Addition");
            Console.WriteLine("4 - Subtraction");
            Console.WriteLine("5 - Multiplication");
            Console.WriteLine("6 - Division");
            Console.WriteLine("7 - Show the last 3 results");
            Console.WriteLine("8 - End of program");
        }
    }
}
