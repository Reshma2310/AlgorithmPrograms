using System;
namespace AlgorithamProblems
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Select an Option\n1. Permutations of a String\n2. Binary Search\n3. Insertion Sort\n4. Bubble Sort\n5. Merge Sort\n6. Anagram\n7. End the Program");
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
                case 3:
                    Console.WriteLine("Enter the Number of words to be given as input");
                    int no = Convert.ToInt32(Console.ReadLine());
                    string[] names = new string[no];
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine("Enter {0} words", no);
                        names = Console.ReadLine().Split(",");
                        break;
                    }
                    AlgorithmPrograms.InsertionSort sort = new AlgorithmPrograms.InsertionSort();
                    sort.InsertSort(names);
                    foreach (var item in names)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the Number of values to be given as input");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[num];
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Enter {0} Numbers for Bubble Sorting", num);
                        array = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
                        break;
                    }
                    AlgorithmPrograms.BubbleSort bubble = new AlgorithmPrograms.BubbleSort();
                    bubble.bubbleSort(array);
                    Console.WriteLine("Sorted array");
                    bubble.printArray(array);
                    break;
                case 5:
                    AlgorithmPrograms.MergeSort merge = new AlgorithmPrograms.MergeSort();                    
                    int[] inputArr = { 212, 63, 513, 55, 86, 6 };
                    merge.PrintArray(inputArr);
                    merge.sort(inputArr, 0, inputArr.Length - 1);
                    Console.WriteLine("\nSorted array");
                    merge.PrintArray(inputArr);
                    break;
                case 6:                                        
                    Console.WriteLine("Enter first string");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string input2 = Console.ReadLine();
                    AlgorithmPrograms.Anagram anagram = new AlgorithmPrograms.Anagram();                    
                    if (anagram.AnagramProg(input1, input2) == true)
                    {
                        Console.WriteLine("Both string are anagram string.");
                    }
                    else
                    {
                        Console.WriteLine("Both string are not anagram string.");
                    }
                    Console.ReadLine();
                    break;
                default:
                    break;
            }           
        }
    }
}
