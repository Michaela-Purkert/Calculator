using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class SimpleCalculator
    {
        MenuText menu;
        Operations operations;
        double[] threeNumbers = new double[3];

        public SimpleCalculator()
        {
            operations = new Operations();
            menu = new MenuText();
        }

        private void PastThreeNumbers(double newResult)
        {
            threeNumbers[2] = threeNumbers[1];
            threeNumbers[1] = threeNumbers[0];
            threeNumbers[0] = newResult;
        }

        private void ShowPastThreeNumbers()
        {
            for (int i = 0; i < threeNumbers.Length;)
            {
                Console.WriteLine("{0}. result from the past three results is: {1}", i + 1, threeNumbers[i]);
                i++;
            }
        }

        public void Menu()
        {
            bool continueCheck = true;
            bool check = true;
            int option;
            string optionInput;
            do
            {
                do
                {
                    menu.MenuOptions();
                    optionInput = Console.ReadLine();
                    check = int.TryParse(optionInput, out option);

                    if ((check) && (option > 0) && (option < 9))
                    {
                        switch (option)
                        {
                            case 1:
                                operations.SetFirstNumber();
                                break;
                            case 2:
                                operations.SetSecondNumber();
                                break;
                            case 3:
                                PastThreeNumbers(operations.Addition());
                                break;
                            case 4:
                                PastThreeNumbers(operations.Subtraction());
                                break;
                            case 5:
                                PastThreeNumbers(operations.Multiplication());
                                break;
                            case 6:
                                PastThreeNumbers(operations.Division());
                                break;
                            case 7:
                                ShowPastThreeNumbers();
                                break;
                            case 8:
                                continueCheck = false;
                                Console.WriteLine("Thank you for using this simple calculator!");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        Console.WriteLine("You must input an integer from menu!");
                    Console.ReadKey();
                    Console.Clear();
                } while ((check == false) || (option <= 0) || (option >= 9));
            } while (continueCheck == true);
        }
    }
}
