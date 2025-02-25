namespace zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ArrayCreator.ArrayCreate(10, false);
            Console.WriteLine("Initial Array: " + string.Join(", ", arr));

            int key = 4;
            int index = LinearSearchWithMoveToFront.LinearSearchWithMoveToFrontMethod(arr, key);
            if (index != -1)
            {
                Console.WriteLine($"Found {key} at index {index}. Array after moving to front: " + string.Join(", ", arr));
            }
            else
            {
                Console.WriteLine($"{key} not found in the array.");
            }
        }
    }
}