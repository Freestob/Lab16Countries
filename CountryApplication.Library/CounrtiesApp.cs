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
            var userChoice = (Enums.UserChoices)int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case Enums.UserChoices.SeeList:
                    CountriesTextFile.CountryRead();
                    break;

                case Enums.UserChoices.AddCounty:
                    CountriesTextFile.CountryAdd();
                    break;

                case Enums.UserChoices.Exit:
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("I'm sorry. That is not a valid option");
                    MainMenu();
                    break;
            }
          
        }
    }
}
