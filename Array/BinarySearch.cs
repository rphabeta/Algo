// See https://aka.ms/new-console-template for more information

namespace BinarySearch
{
    class Program
    {
        static int binarySearch(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;
          
            while (low <= high)
            {
                int pivot = (low + high) / 2;
                if (nums[pivot] == target)
                    return pivot;
                else if (nums[pivot] < target)
                    low = pivot + 1;
                else 
                    high = pivot - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[]{ 1, 3, 6, 7, 8, 9 };
            int idx = binarySearch(arr, 8);
            Console.WriteLine(idx);

        }
    }
}
