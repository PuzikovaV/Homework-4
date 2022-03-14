using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    public class Variables
    {
        public static int DecideLinearEquation (int a, int b, int c)
        {
            if (a==0)
            {
                throw new Exception("Wrong value for a");
            }

            else if (b == 0)
            {
                throw new Exception("Wrong value for b");
            }
            else if  (c == 0)
            {
                throw new Exception("Wrong value for a");
            }

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

        public static int DecideSimpleProblem (int a, int b)
        {
            return (5 * a + b * b) / (b - a);
        }

        public static void MakeDivide (int a, int b, out int rez1, out int rez2)
        {
            if (b == 0)
            {
                throw new Exception("Wrong value for b");
            }
            rez1 = a / b;
            rez2 = a % b;
        }

        public static void SwapTwoValues (ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
    }
}
