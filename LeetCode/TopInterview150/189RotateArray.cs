using System.ComponentModel.Design;

namespace LeetCode.TopInterview150
{
    public static class _189RotateArray
    {
        public static void Exercise()
        {
            //Inputs
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            //Solution
            //Dado a array e o int k
            //Mover para a direita a array conforme o int k
            //Se estiver no final, o movimento será para retornar ao início

            if (nums.Length == 0 || nums.Length == 1)
            {
                return;
            }

            for (int i = 0; i < k; i++)
            {
                int temp1 = 0;
                int temp2 = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == 0)
                    {
                        temp1 = nums[j + 1];
                        nums[j + 1] = nums[j];
                    }
                    else if (j < nums.Length - 1)
                    {
                        if (j % 2 != 0)
                        {
                            temp2 = nums[j + 1];
                            nums[j + 1] = temp1;
                        }
                        else
                        {
                            temp1 = nums[j + 1];
                            nums[j + 1] = temp2;
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            nums[0] = temp1;
                        }
                        else
                        {
                            nums[0] = temp2;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(",", nums));
        }
    }
}
