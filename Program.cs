using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant8MaksimTsvetkov
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string max = "max";
            string min = "min";
            string surname = "surname";
            string namecal = "namecal";

            Console.WriteLine("Choose what u want\nmax-show the max number between 2 random\nmin-show the min number between 2 random\nsurname-write 3 surnames and get the longest\nnamecal-write a name ang get number of glasnqe and soglasnqe");
            string word = Console.ReadLine();

            if (word == max)
            {
                Alamprogram.Max();
            }

            else if (word == min)
            {
                Alamprogram.Min();
            }

            else if (word == surname)
            {
                Alamprogram.surname();
            }

            else if (word == namecal)
            {
                Alamprogram.namecal();
            }

            Console.ReadLine();
        }
    }
}
