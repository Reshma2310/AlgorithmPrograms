using System;
namespace AlgorithamProblems
{
    class program
    {
        public static void Main(String[] args)
        {
            String input;
            String output = "";

            Console.Write("Enter the string: ");
            input = Console.ReadLine();

            Console.Write("\nAll possible strings are : ");
            AlgorithmPrograms.Permutations prog = new AlgorithmPrograms.Permutations();
            prog.Permute(input, output);
        }
    }
}
