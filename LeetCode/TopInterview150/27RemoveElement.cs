namespace LeetCode.TopInterview150
{
    public static class _27RemoveElement
    {
        public static int Exercise()
        {
            //Inputs
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;

            //Solution
            int k = nums.Length;

            if (k == 0)
            {
                return k;
            }

            int maxPluxOne = nums.Max() + 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = maxPluxOne;
                    k--;
                }
            }

            for (var j = 0; j < nums.Length; j++)
            {
                for (var i = 0; i < nums.Length - 1 - j; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp;
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
            }

            return k;
        }
    }
}
