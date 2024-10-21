namespace LeetCode.Top_Interview_150
{
    public static class _80RemoveDuplicatesFromSortedArrayII
    {
        public static int Exercise()
        {
            //Inputs
            int[] nums = [1, 1, 1];

            //Solution
            int maxPlusOne = nums.Max() + 1;

            for (var i = 0; i < nums.Length; i++)
            {
                int repeats = 0;

                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        repeats++;
                        if (repeats > 2)
                        {
                            nums[j] = maxPlusOne;
                        }
                    }
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp;
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            int k = Array.IndexOf(nums, maxPlusOne);

            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine(k);

            return k > 0 ? k : nums.Length;
        }
    }
}
