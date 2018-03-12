using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._5
{
    class Program
    {
        static int Max(int x, int y)
        {

            if (x > y)
                return x;
            else if (x < y)
                return y;
            else
                return 0;

        }

        static int Min(int x, int y)
        {

            if (x < y)
                return x;
            else if (x > y)
                return y;
            else
                return 0;

        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int max = Max(x, y);
            int min = Min(x, y);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }
    }
}
