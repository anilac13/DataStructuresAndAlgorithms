using DataStructuresAndAlgorithms.BinarySearchProblem;
using System;
namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Binary Search \n2.Permutations of a String \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadFile(@"D:\BridgeLabs\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\BinarySearchProblem\File.txt");
                        break;
                    case 2:
                        PermutationsOfString permutations = new PermutationsOfString();
                        string a = "abcd";
                        int b = a.Length;
                        permutations.Permutation(a, 0, b - 1);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}