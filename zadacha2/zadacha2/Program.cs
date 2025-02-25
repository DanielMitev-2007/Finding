namespace zadacha2
{
    internal class Program
    {
    static (int count, List<int> positions) BinarySearch(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;
            List<int> positions = new List<int>();

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    positions.Add(mid);

                    int leftIndex = mid - 1;
                    while (leftIndex >= 0 && array[leftIndex] == target)
                    {
                        positions.Add(leftIndex);
                        leftIndex--;
                    }

                    int rightIndex = mid + 1;
                    while (rightIndex < array.Length && array[rightIndex] == target)
                    {
                        positions.Add(rightIndex);
                        rightIndex++;
                    }

                    positions.Sort();
                    return (positions.Count, positions);
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return (0, positions);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Колко елемента да съдържа масивът?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Какво е търсеното число?");
            int target = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 10); 
            }

            Console.WriteLine("Масивът е:");
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Array.Sort(array);

            var (count, positions) = BinarySearch(array, target);

            if (count > 0)
            {
                Console.WriteLine($"Намерени са {count} елемента със стойност {target}.");
                Console.WriteLine("Позициите на елементите са:");
                foreach (var pos in positions)
                {
                    Console.WriteLine(pos);
                }
            }
            else
            {
                Console.WriteLine("Не са намерени елементи със стойност " + target);
            }
        }
    }
}
