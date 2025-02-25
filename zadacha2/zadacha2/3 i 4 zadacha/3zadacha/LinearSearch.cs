using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zadacha
{
    class LinearSearchWithTranspose
    {
        public static int LinearSearchWithTransposeMethod(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    if (i > 0)
                    {
                        
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                    return i;
                }
            }
            return -1; 
        }
    }
}
