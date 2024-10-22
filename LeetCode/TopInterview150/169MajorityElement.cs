namespace LeetCode.TopInterview150
{
    public static class _169MajorityElement
    {
        public static int Exercise()
        {
            //Inputs
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            //Solution

            //{ 2, 1 };
            int[] numsDistinct = nums.Distinct().ToArray();

            for (var i = 0; i < numsDistinct.Length; i++)
            {
                int repeats = 0;

                for (var j = 0; j < nums.Length; j++)
                {
                    if (numsDistinct[i] == nums[j])
                    {
                        repeats++;
                    }
                }

                if (repeats > nums.Length/2)
                {
                    return numsDistinct[i];
                }
            }

            return 0;
        }
    }
}
