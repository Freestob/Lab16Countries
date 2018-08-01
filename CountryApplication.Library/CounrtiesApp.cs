using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountryApplication.Library
{
    public class CounrtiesApp
    {
        public static void MainMenu()
        {
            Console.WriteLine("What would you like to do?\n1.\tSee list of countries\n2.\tAdd a country\n3.\tExit");
            var userChoice = Console.ReadLine();


            if (userChoice == "1")
            {
                CountriesTextFile.CountryRead();
            }
            else if (userChoice == "2")
            {
                CountriesTextFile.CountryAdd();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Okay thanks");
            }
        }
    }
}
