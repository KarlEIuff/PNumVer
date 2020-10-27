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

            bool check = false;

            do
            {
                Console.Write("Please enter your number: ");
                string pNumber = Console.ReadLine();

                if (pNumber.Length == 12)
                {
                    check = true;
                } else
                {
                    Console.WriteLine("You entered an incorrect amount of numbers! Try again");
                }
            } while (!check);

            

        }
    }
}
