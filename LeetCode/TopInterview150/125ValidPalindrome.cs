using System.Text.RegularExpressions;

namespace LeetCode.TopInterview150
{
    public static class _125ValidPalindrome
    {
        public static bool Exercise(string s)
        {
            //Inputs
            //string s = "A man, a plan, a canal: Panama";

            //Solution
            string sWithoutNonAlphanumeric = string.Concat(s.Where(char.IsLetterOrDigit)).ToLower();
            string reversed = new string(sWithoutNonAlphanumeric.Reverse().ToArray());

            return sWithoutNonAlphanumeric == reversed;

            //Testes de referência em objetos
            var obj1 = new Teste
            {
                Age = 10,
                Name = "Obj1"
            };

            var obj2 = obj1;

            obj1.Name = "Teste";

            Console.WriteLine(obj1.Name);
            Console.WriteLine(obj2.Name);
            Console.WriteLine("Fim");

            return true;
        }

        public class Teste
        {
            public int Age;
            public string Name;
        }
    }
}
