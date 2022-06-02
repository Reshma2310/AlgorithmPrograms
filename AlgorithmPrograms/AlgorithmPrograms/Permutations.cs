using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Permutations
    {
        public void Permute(String input, String output)
        {
            if (input.Length == 0)
            {
                Console.Write(output + "  ");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char ap = input[i];
                String left_substr = input.Substring(0, i);
                String right_substr = input.Substring(i + 1);
                String result = left_substr + right_substr;
                Permute(result, output + ap);
            }
        }
    }
}
