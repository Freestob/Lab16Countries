using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountryApplication.Library
{
    public class CountriesTextFile
    {
        public static void CountryRead()
        {
             using (StreamReader countryStream = new StreamReader(@"C: \Users\frees\source\repos\Lab16\countries.txt"))
                {
                    while (!countryStream.EndOfStream)
                    {
                        string line = countryStream.ReadLine();

                        Console.WriteLine(line);
                        Console.ReadKey();
                       
                        
                    }
                countryStream.Close();
            }

             CounrtiesApp.MainMenu();
        }

        public static void CountryAdd()
        {
            Console.WriteLine("What country would you like to add?");
            var countryToAdd = Console.ReadLine();
            using (StreamWriter countryAdder = new StreamWriter(@"C: \Users\frees\source\repos\Lab16\countries.txt"))
            {
                countryAdder.WriteLine(countryToAdd);
                countryAdder.Close();
            }
            CounrtiesApp.MainMenu();
        }
    }
}
