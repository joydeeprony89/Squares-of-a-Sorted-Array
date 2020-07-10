using System;
using System.Collections.Generic;
using System.Linq;

namespace Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", SortedSquares(new int[] { -7, -3, 2, 3, 11 }));
        }

        public static int[] SortedSquares(int[] A)
        {
           for(int i = 0; i< A.Length; i++)
            {
                A[i] = A[i] * A[i];
            }

            Array.Sort(A);
            return A;
        }
    }
}
