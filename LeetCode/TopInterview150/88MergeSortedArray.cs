namespace LeetCode.TopInterview150
{
    public static class _88MergeSortedArray
    {
        public static void Exercise()
        {
            //Inputs
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;

            //Teste
            //int[] teste = [3, 2, 1, 4, 5, 2, 10, 8, 7];
            //nums1 = teste;

            //Solution

            for (var i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Console.WriteLine(string.Join(", ", nums1));

            //BubbleSort
            for (var j = 0; j < m + n; j++)
            {
                for (var i = 0; i < m + n - 1 - j; i++)
                {
                    if (nums1[i] > nums1[i + 1])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums1[i + 1];
                        nums1[i + 1] = temp;
                    }
                    Console.WriteLine(string.Join(", ", nums1));
                }
            }
        }
    }
}
