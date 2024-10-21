namespace LeetCode.TopInterview150
{
    public static class _26RemoveDuplicatesFromSortedArray
    {
        public static int Exercise()
        {
            //Inputs
            int[] nums = [1, 2];

            //Solution
            if (nums.Length == 1)
            {
                return 1;
            }

            int maxPlusOne = nums.Max() + 1;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                int repeats = 0;

                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        repeats++;
                        
                        if (repeats != 1)
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

            int k = Array.IndexOf(nums, maxPlusOne) - 1;

            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine(k);

            return k > 0 ? k : nums.Length;
        }
    }
}
