using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Insertion
    {
        public static int[] Sort(int[] values)
        {
            for(int i = 1; i < values.Length; i++)
            {
                
                for(int j = i; j > 0 && values[j-1]>values[j];)
                {
                    int temp = values[j];
                    values[j] = values[j - 1];
                    values[j - 1] = temp;
                    j--;
                }
            }
            return values;
        }
    }
}
