using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class Class1
    {
        public static int ToDoSums (int a, int b)
        {
            if (a> b)
            {
                return a+b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        public static void DeterminationOfQuarterCoordinates (int x, int y)
        {
            if (x < 0 && y > 0)
            {
                Console.Write("Точка принадлежит второй координатной четверти");
            }
            else if (x > 0 && y > 0)
            {
                Console.Write("Точка принадлежит первой координатной четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.Write("Точка принадлежит четвертой координатной четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.Write("Точка принадлежит третьей координатной четверти");
            }
        }


    }
}
