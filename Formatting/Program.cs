using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "one";
            string two = "two";
            string three = "three";
            string one1 = "one1";
            string two1 = "two1";
            string three1 = "three1";

            Console.WriteLine(string.Format("{0}{1}{2}", one.PadRight(10, ' '), two.PadRight(10, ' '), three.PadRight(10, ' ')));
            Console.WriteLine();
            Console.WriteLine(string.Format("{0,-10}{1,10}{2,10}", one1.PadRight(10, ' '), two1.PadRight(10, ' '), three1.PadRight(10, ' ')));

        }
    }
}
