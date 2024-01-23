using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string rezultat = "";
            
            if (s1.Length < 5)
            {
                rezultat = s1;
            }
            else
            {
                rezultat = s1.Substring(2, s1.Length - 4);
            }
            Console.WriteLine(rezultat);
            Console.ReadKey();
        }
    }
}
