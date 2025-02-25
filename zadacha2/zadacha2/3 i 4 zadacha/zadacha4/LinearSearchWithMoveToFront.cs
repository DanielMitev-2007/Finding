using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class LinearSearchWithMoveToFront
    {
        public static int LinearSearchWithMoveToFrontMethod(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    if (i != 0)
                    {
                        int temp = arr[i];
                        for (int j = i; j > 0; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[0] = temp;
                    }
                    return 0;
                }
            }
            return -1;
        }
    }
}
