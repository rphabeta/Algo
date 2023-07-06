// See https://aka.ms/new-console-template for more information
namespace MoveZeroes
{
    class Program
    {
        // 후에 0을 채워넣는 방식
        static void MoveZeroes(int[] nums)
        {
            int wIdx = 0;
            for (int idx = 0; idx < nums.Length; idx++)
            {
                if (nums[idx] != 0)
                {
                    nums[wIdx] = nums[idx];
                    wIdx++;
                }
            }
            // setZeroes();
            for (; wIdx < nums.Length; wIdx++)
            {
                nums[wIdx] = 0;
            }
        }

        // Swap을 이용한 방법
        static void MoveZeroes2(int[] nums)
        {
            int wIdx = 0;
            for(int idx = 0; idx < nums.Length; idx++)
            {
                if (nums[idx] != 0)
                {
                    Swap(nums, wIdx, idx);
                    wIdx++;
                }
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        static void PrintArray(int[] arr)
        {
            foreach(int element in arr)
            {
                Console.Write(element + " ");
            }
        }

        public static void Main(string[] args)
        {

            int[] arr = new int[] { 3, 1, 0, 1, 0, 4, 6 };
            int[] arr2 = new int[] { 3, 1, 0, 1, 0, 4, 6 };
            MoveZeroes(arr);
            MoveZeroes2(arr2);
            PrintArray(arr);
            Console.WriteLine();
            PrintArray(arr2);
        }
    }
}

