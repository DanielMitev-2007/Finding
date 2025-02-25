namespace _3zadacha
{
    internal class Program
    {
        public static void Main()
        {
            int[] arr = ArrayCreator.CreateArray(10, false);
            Console.WriteLine("Initial Array: " + string.Join(", ", arr));
            Console.Write("Enter value for searching: ");
            int key = int.Parse(Console.ReadLine());
            int index = LinearSearchWithTranspose.LinearSearchWithTransposeMethod(arr, key);
            if (index != -1)
            {
                Console.WriteLine($"Found {key} at index {index}. Array after transposition: " + string.Join(", ", arr));
            }
            else
            {
                Console.WriteLine($"{key} not found in the array.");
            }
        }
    }
}
