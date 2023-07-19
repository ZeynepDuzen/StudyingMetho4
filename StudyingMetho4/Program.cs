using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMetho4
{
    internal class Program
    {
        static void Addname(string lastName) {
            Console.WriteLine("Zeynep" + " " +  lastName);
        }

        static void Main(string[] args)
        {
            Addname("Can");
            Addname("Cankus");
            Addname("Can Can");

            Console.Read();
        }
    }
}
