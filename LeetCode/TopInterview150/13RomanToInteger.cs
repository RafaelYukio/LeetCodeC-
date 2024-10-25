namespace LeetCode.TopInterview150
{
    public static class _13RomanToInteger
    {
        public static int Exercise()
        {
            //Inputs
            string s = "III";

            //Solution

            var romanToIntDictionary = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
            };

            int total = 0;

            for(int i = 0; i < s.Length; i++)
            {
                int value = romanToIntDictionary[s[i]];

                if (i == s.Length - 1)
                {
                    total += value;
                }
                else
                {
                    int nextValue = romanToIntDictionary[s[i + 1]];

                    if (nextValue > value)
                    {
                        total -= value;
                    }
                    else
                    {
                        total += value;
                    }
                }
            }

            return total;
        }
    }
}
