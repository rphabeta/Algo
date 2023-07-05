class Program
{
    static int Partition(int[] nums, int left, int right)
    {
        int pivot = nums[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (nums[j] < pivot)
            {
                i++;
                Swap(nums, i, j);
            }
        }

        Swap(nums, i + 1, right);
        return i + 1;
    }

    static void QuickSort(int[] nums, int left, int right)
    {
        if( left < right)
        {
            int pivot = Partition(nums, left, right);
            QuickSort(nums, left, pivot - 1);
            QuickSort(nums, pivot + 1, right);
        }
    }

    static int partition2(int[] nums, int left, int right)
    {
        int pivot = nums[(right + left) / 2];
        int i = left - 1;
        int j = right + 1;

        while (true)
        {
            do
            {
                i++;
            } while (nums[i] < pivot);

            do
            {
                j--;
            } while (nums[j] > pivot);

            if (i >= j)
            {
                return j;
            }
            Swap(nums, i, j);
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

    static void Main(string[] args)
    {
        int[] nums = { 5, 2, 6, 3, 1, 4 };

        Console.WriteLine("정렬 전:");
        PrintArray(nums);

        QuickSort(nums, 0, nums.Length - 1);

        Console.WriteLine("\n정렬 후:");
        PrintArray(nums);
    }
}
