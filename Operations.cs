using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operations
    {
        public double firstNumber { get; private set; }
        public double secondNumber { get; private set; }

        public void SetFirstNumber()
        {
            bool check = true;
            string inputNumber;
            double number;

            Console.WriteLine("Set new value of first number:");
            do
            {
                inputNumber = Console.ReadLine();
                check = double.TryParse(inputNumber, out number);
                if (check)
                    firstNumber = round(number);
                else
                    Console.WriteLine("You must assign a number!");

            } while (check == false);
        }

        public void SetSecondNumber()
        {
            bool check = true;
            string inputNumber;
            double number;

            Console.WriteLine("Set new value of second number:");
            do
            {
                inputNumber = Console.ReadLine();
                check = double.TryParse(inputNumber, out number);
                if (check)
                    secondNumber = round(number);
                else
                    Console.WriteLine("You must assign a number!");
            } while (check == false);
        }

        public double Addition()
        {
            if (NumbersNoZero())
            {
                double addition = firstNumber + secondNumber;
                Console.WriteLine("The sum of the numbers {0} and {1} is: {2}", firstNumber, secondNumber, round(addition));
                return round(addition);
            }

            return 0;
        }

        public double Subtraction()
        {
            if (NumbersNoZero())
            {
                double subtraction = firstNumber - secondNumber;
                Console.WriteLine("The subtraction of the numbers {0} and {1} is: {2}", firstNumber, secondNumber, round(subtraction));
                return round(subtraction);
            }
            return 0;
        }

        public double Multiplication()
        {
            if (NumbersNoZero())
            {
                double multiplication = firstNumber * secondNumber;
                Console.WriteLine("The multiplication of the numbers {0} and {1} is: {2}", firstNumber, secondNumber, round(multiplication));
                return round(multiplication);
            }
            return 0;
        }

        public double Division()
        {
            if (NumbersNoZero())
            {
                if (SecondNumberNoZero())
                {
                    double division = firstNumber / secondNumber;
                    Console.WriteLine("The division of the numbers {0} and {1} is: {2}", firstNumber, secondNumber, round(division));
                    return round(division);
                }
                return 0;
            }
            return 0;
        }

        private double round(double number)
        {
            double x = Math.Round(number, 2);
            return x;
        }

        private bool NumbersNoZero()
        {
            if (firstNumber == 0 && secondNumber == 0)
            {
                Console.WriteLine("For completion of this operation the numbers must not be zero!");
                return false;
            }
            else
            {
                Console.WriteLine();
                return true;
            }
        }

        private bool SecondNumberNoZero()
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("For completion of this operation the second number must not be zero!");
                return false;
            }
            else
            {
                Console.WriteLine();
                return true;
            }
        }
    }
}
