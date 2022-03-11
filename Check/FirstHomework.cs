using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class Variables
    {
        public static int DecideLinearEquation (int a, int b, int c)
        {
            int x;
            x=(c-b)/a;
            return x;
        }

        public static void DecideTwoPointEquation (int x1, int x2, int y1, int y2)
        {
            int A;
            int B;
            A=(y2-y1)/(x2-x1);
            B = y1 - x1 * A;

            Console.WriteLine($"y={A}x+{B}");
        }
    }
}
