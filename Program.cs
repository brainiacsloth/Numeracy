using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeracy
{
    internal class Numeracy
    {

        static void Main (string [] args)
        {

            Console.WriteLine(5);
            Console.WriteLine(5 + 6);
            Console.WriteLine(5 % 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);

            int num = 6;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(2, 2));
        }
    }
}