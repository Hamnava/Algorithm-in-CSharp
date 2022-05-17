using System;
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
    }
}
