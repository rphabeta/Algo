// See https://aka.ms/new-console-template for more information

namespace sample
{
    class Program
    {
        
        static void merge(int[] nums1, int m, int[] nums2, int n)
        {
            int num1Idx = m - 1;
            int num2Idx = n - 1;
            int wIdx = nums1.Length - 1;

            if (num2Idx < 0)
            {
                return;
            }
            while (0 <= num1Idx && 0 <= num2Idx)
            {
                int num1 = nums1[num1Idx];
                int num2 = nums2[num2Idx];
                if(num2 <= num1)
                {
                    nums1[wIdx] = num1;
                    num1Idx--;
                    wIdx--;
                }
                else
                {
                    nums1[wIdx] = num2;
                    num2Idx--;
                    wIdx--;
                }
            }
            while(0 <= num2Idx)
            {
                nums1[wIdx] = nums2[num2Idx];
                num2Idx--;
                wIdx--;
            }
        }
        

        static void PrintArray(int[] nums)
        {
            foreach(int element in nums)
            {
                Console.Write(element + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] nums1 = new int[] { 4, 5, 6, 0, 0, 0 };
            int[] nums2 = new int[] { 1, 2, 3 };
            
            merge(nums1, 3, nums2, 3);
            PrintArray(nums1);
        }
    }
}

