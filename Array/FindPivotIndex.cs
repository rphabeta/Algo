// See https://aka.ms/new-console-template for more information

namespace sample
{
    class Program
    {

        // ver1
        static int FindPivotIndex(int[] arr)
        {
            int rightSum = 0;
            int leftSum = arr[0];


            for (int i = 2; i < arr.Length; i++)
            {
                rightSum += arr[i];
            }


            for(int i = 1; i < arr.Length - 1; i++)
            {
                if (rightSum == leftSum)
                    return i;
                else 
                {
                    rightSum -= arr[i + 1];
                    leftSum += arr[i];
                }
            }
            return -1;
        }

        // ver2
        static int FindPivotIndex2(int[] nums)
        {
            int sum = 0;
            foreach(int element in nums)
            {
                sum += element;
            }
            int leftSum = 0;
            int rightSum = sum;

            int pastPivotNum = 0;
            for(int idx = 0; idx < nums.Length; idx++)
            {
                int num = nums[idx];
                rightSum -= num;
                leftSum += pastPivotNum;

                if(leftSum == rightSum)
                {
                    return idx;
                }
                pastPivotNum = num;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[]{1, 8, 2, 9, 2, 3, 6 };
            int pivot = FindPivotIndex(arr);
            Console.Write(pivot);
        }
    }
}

