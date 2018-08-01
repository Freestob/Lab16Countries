using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CountryApplication.Library;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream country = File.Create(@"C: \Users\frees\source\repos\Lab16\countries.txt"))
            {
                country.Close();
            }
                CounrtiesApp.MainMenu();
        }
    }
}
