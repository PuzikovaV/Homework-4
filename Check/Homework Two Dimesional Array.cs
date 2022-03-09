using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class TwoDimesionalArray
    {
        public static int FindMin (int [,] a)
        {
            int min=a[0,0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
               for(int j=0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i,j];
                    }
                }
            }
            return min;
        }

        public static int FindMax(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }
    }
}
