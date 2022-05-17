using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithms.Array_Algorithms
{
    public class ArrayAlgorithms
    {
        public Boolean LinearSearch(int[] input, int n)
        {
            foreach (int current in input)
            {
                if (n== current)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean BinarySearch(int[] binarSearch, int item)
        {
            int min = 0;
            int max = binarSearch.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if(item == binarSearch[mid]) return true;

                else if(item < binarSearch[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }

        // Aggregate arrays into one array
        public int[] FindEvenNumbers(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();

            foreach (var item in arr1)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            foreach (var item in arr2)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return (int[])(result.ToArray((typeof(int))));
        }

        //Reverse Algorithm for array
        public int[] Reverse(int[] input)
        {
            int[] reverse = new int[input.Length];

            for (int i = 0; i < reverse.Length; i++)
            {
                reverse[i] = input[input.Length - i -1];
            }
            return reverse;
        }
    }
}
