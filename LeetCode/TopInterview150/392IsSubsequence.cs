namespace LeetCode.TopInterview150
{
    public static class _392IsSubsequence
    {
        public static bool Exercise()
        {
            //Inputs
            //string s = "abc";
            //string t = "ahbgdc";

            string s = "aaaaaa";
            string t = "bbaaaa";

            //Solution

            //1. Pegar string s e verificar se há todos os chars na string t OKOKOK
            // Se tiver próximo passo
            //2. Verificar se a order dos chars da string s são os mesmos da string t
            // Se tiver returna true

            //1

            for (int i = 0; i < s.Length; i++)
            {
                if (t.IndexOf(s[i]) < 0)
                {
                    return false;
                }
            }

            //2

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (t.IndexOf(s[i + 1]) - t.IndexOf(s[i]) < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
