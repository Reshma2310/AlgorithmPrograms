using System;
namespace AlgorithamProblems
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Select an Option\n1. Permutations of a String\n2. Binary Search\n3. End the Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    String input;
                    String output = "";

                    Console.Write("Enter the string: ");
                    input = Console.ReadLine();
                    Console.WriteLine("All possible strings are : ");
                    AlgorithmPrograms.Permutations prog = new AlgorithmPrograms.Permutations();
                    prog.Permute(input, output);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter the Number of words to be given as input");
                    int n = Convert.ToInt32(Console.ReadLine());
                    string[] arr = new string[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine("Enter {0} words",n);
                        arr = Console.ReadLine().Split(",");
                        break;
                    }
                    Console.WriteLine("Enter the word you want to search");
                    String x = Console.ReadLine();
                    AlgorithmPrograms.BinarySearch search = new AlgorithmPrograms.BinarySearch();
                    int result = search.binarySearch(arr, x);
                    if (result == -1)
                        Console.WriteLine("Word is not present");
                    else
                        Console.WriteLine("Word found at " + "index " + result);
                    Console.WriteLine();
                        break;
                default:
                    break;
            }
            
        }
    }
}
