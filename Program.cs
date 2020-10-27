using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNumVer
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool to check if amount of of chars entered is correct or not
            bool check = false;

            do
            {
                Console.Write("Please enter your number: ");
                string pNumber = Console.ReadLine();

                if (pNumber.Length == 12)
                {
                    check = true;
                    // Calling the method to check the year
                    if (CheckYear(pNumber) && check)
                    {
                        // Calling the method to check the month
                        if(CheckMonth(pNumber) && check)
                        {

                        }
                        else
                        {
                            check = false;
                            Console.WriteLine("Incorrect month! Try again");
                        }
                    }
                    else
                    {
                        check = false;
                        Console.WriteLine("Incorrect year! Try again");
                    }
                } else
                {
                    Console.WriteLine("You entered an incorrect amount of numbers! Try again");
                }
            } while (!check);
        }

        // Checking if year is between 1753 and 2020
        // Returns true if this is true
        static bool CheckYear(string pNumber)
        {
            string sYear = "";
            for(int i = 0; i < 4; i++)
            {
                sYear = sYear + pNumber[i];
            }
            int year = int.Parse(sYear);

            if(year >= 1753 && year <= 2020)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Checking if month is between 1 and 12
        // Returns true if this is true
        static bool CheckMonth(string pNumber)
        {

            string sMonth = "";

            for(int i = 4; i < 6; i++)
            {
                sMonth = sMonth + pNumber[i];
            }
            int month = int.Parse(sMonth);

            if(month >= 1 && month <= 12)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
