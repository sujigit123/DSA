//Two sum using two pointers approach
namespace DSA
{
    internal class DSA3
    {
        public static void Main()
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7, 8, 16, 17, 18, 19, 20, 9, 10, 11, 12, 13, 14, 15 };

            Array.Sort(items);

            int leftIndex = 0;
            int rightIndex = items.Length-1;
            int targetSum = 34;

            while (leftIndex < rightIndex) 
            {
                int sum = items[leftIndex] + items[rightIndex];
                if (sum == targetSum) {
                    Console.WriteLine($"Sum Found and the numbers are :  {items[leftIndex]} and {items[rightIndex]}");
                    break;
                }
                else if(sum>targetSum)
                {
                    rightIndex--;
                }
                else
                {
                    leftIndex++;
                }
            }
            Console.ReadLine();
        }
    }
}
