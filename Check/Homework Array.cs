using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class HomeworkArray
    {
        public static int FindMinOfArray (int[] a)
        {
            int min = a[0];
            for (int i=1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        public static int FindMaxOfArray(int[] a)
        {
            int max = a[0];
            for(int i=1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static int FindIndexOfMinElement(int[] a)
        {
            int indexOfMin=0;
            int minElement = a[0];
            for (int i=1; i<a.Length; i++)
            {   
                if (a[i] < minElement)
                {
                    minElement = a[i];
                    indexOfMin = i;
                }
            }
            return indexOfMin;
        }
        public static int FindIndexOfMaxElement(int[] a)
        {
            int indexOfMax=0;
            int maxElement = a[0];
            for (int i=1; i<a.Length; i++)
            {   
                if (a[i] > maxElement)
                {
                    maxElement = a[i];
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }
        public static int CountElementsWithOddIndex (int[] a)
        {
            int sumOfElements = 0;
            for (int i=0; i<a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOfElements+=a[i];
                }
            }
            return sumOfElements;
        }

        public static int CountOddElements(int[] a)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
