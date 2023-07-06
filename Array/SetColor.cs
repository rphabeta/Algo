// See https://aka.ms/new-console-template for more information

namespace sample
{
    class Program
    {
        static int[] SetColor(int[] nums)
        {
            int lIdx = 0;
            int rIdx = nums.Length - 1;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    Swap(nums, i, lIdx);
                    lIdx++;
                }
                else if (nums[i] == 2)
                {
                    Swap(nums, i, rIdx);
                    rIdx--;
                }
                if (i >= rIdx)
                {
                    return nums;
                }
                
            }
            return nums;
        }

        static void SetColor2(int[] nums)
        {
            int idx0 = 0;
            int idx2 = nums.Length - 1;
            int i = 0;
            while(i <= idx2)
            {
                if (nums[i] == 0)
                {
                    Swap(nums, i, idx0);
                    idx0++;
                    i++;
                }
                else if (nums[i] == 2)
                {
                    Swap(nums, i, idx2);
                    idx2--;
                }
                else
                {
                    i++;
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
            int[] nums = new int[] { 1, 0, 2, 2, 0, 1, 2, 1, 0 };
            nums = SetColor(nums);
            PrintArray(nums);
            
        }
    }
}

