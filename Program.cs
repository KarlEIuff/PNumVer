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
            // bool to check if amount of chars entered is correct or not
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
                            // Calling the method to check the day
                            if(CheckDay(pNumber) && check)
                            {
                                // Calling the method to check the birth number
                                if(CheckBirthNumber(pNumber) && check)
                                {
                                    // Calling the method to check the gender and prints out the resulting string of the program
                                    Console.WriteLine("The number " + pNumber + " is valid and the gender of it is " + CheckGender(pNumber));

                                } 
                                else
                                {
                                    check = false;
                                    Console.WriteLine("Incorrect birth number! Try again");
                                }
                            }
                            else
                            {
                                check = false;
                                Console.WriteLine("Incorrect day! Try again");
                            }
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
        // Returns true if the year is valid
        static bool CheckYear(string pNumber)
        {
            string sYear = "";
            for(int i = 0; i < 4; i++)
            {
                sYear += pNumber[i];
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
        // Returns true if the month is valid
        static bool CheckMonth(string pNumber)
        {
            string sMonth = "";

            for(int i = 4; i < 6; i++)
            {
                sMonth += pNumber[i];
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

        // Checking if day is valid by calling other methods to check the month of amount of days depending on the year
        // Returns true if the day is valid
        static bool CheckDay(string pNumber)
        {
            string sDay = "";
            string sMonth = "";
            string sYear = "";

            for (int i = 0; i < 4; i++)
            {
                sYear += pNumber[i];
            }

            for (int i = 4; i < 6; i++)
            {
                sMonth += pNumber[i];
            }

            for (int i = 6; i < 8; i++)
            {
                sDay += pNumber[i];
            }

            int year = int.Parse(sYear);
            int month = int.Parse(sMonth);
            int day = int.Parse(sDay);
            int amountOfDays = DaysInMonth(month, year);

            if(day > 0 && day <= amountOfDays)
            {
                return true;
            }
            return false;
        }

        // Returns the amount of days the month has
        static int DaysInMonth(int month, int year)
        {

            switch (month)
            {
                case 1:
                    return 31;
                case 2:
                    // Calls a method to check if the year is a leap year or not
                    if (LeapYear(year))
                    {
                        return 29;
                    } else
                    {
                        return 28;
                    }
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
                default:
                    return 0;
            }
        }

        // Checks if the year entered is a leap year or not
        static bool LeapYear(int year)
        {

            if(year % 400 == 0)
            {
                return true;
                
            } else
            {
                if (year % 100 != 0)
                {
                    if (year % 4 == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Checking if all three birth numbers are valid
        static bool CheckBirthNumber(string pNumber)
        {
            // if counter becomes 3, that means all three numbers are valid
            int counter = 0;

            for(int i = 8; i < 11; i++)
            {
                string sBirthNumber = "";
                sBirthNumber += pNumber[i];
                // making each birth number into int one at a time and checking them individually in the if statement
                int birthNumber = int.Parse(sBirthNumber);
                if(birthNumber >= 0 && birthNumber <= 9)
                {
                    counter++;
                }
            }

            if(counter == 3)
            {
                return true;
            }
            return false;
        }

        // Checking if the birthnumber is even or odd and returns the gender in a string
        static string CheckGender(string pNumber)
        {
            string sBirthNumber = "";
            int birthNumber;
            string gender;

            sBirthNumber += pNumber[10];
            birthNumber = int.Parse(sBirthNumber);

            if(birthNumber % 2 == 0 || birthNumber == 0)
            {
                gender = "female";
            }
            else
            {
                gender = "male";
            }

            return gender;
        }
    }
}
