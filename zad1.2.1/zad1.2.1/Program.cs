using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine()); 
            int[] arr = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Enter number for searching:");
            int target = int.Parse(Console.ReadLine());

            (int count, List<int> positions) = LinearSearch(arr, target);

            Console.WriteLine($"Number of found elements with value {target}: {count}");
            if (count > 0)
            {
                Console.WriteLine("Positions of the elements with values {0}: {1}", target, string.Join(", ", positions));
            }
            else
            {
                Console.WriteLine("Not found elements with that value {0}.", target);
            }

            Console.ReadKey();
        }
        static (int, List<int>) LinearSearch(int[] arr, int target)
        {
            int count = 0;
            List<int> positions = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    count++;
                    positions.Add(i+1);
                }
            }
            return (count, positions);
        }
    }
}
