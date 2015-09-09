using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            Roman roman = new Roman();

            Console.WriteLine(roman.ToRoman(a));
            Console.ReadKey();
        }
    }
}
