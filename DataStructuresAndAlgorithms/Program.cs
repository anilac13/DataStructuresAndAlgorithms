﻿using DataStructuresAndAlgorithms.BinarySearchProblem;
using DataStructuresAndAlgorithms.InsertionSortProblem;
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
                Console.WriteLine("\nChoose option to perform \n1.Binary Search \n2.Permutations of a String \n3.Insertion Sort \n4.Exit");
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
                        InsertionSort sort = new InsertionSort();
                        sort.Sort(@"D:\BridgeLabs\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\InsertionSortProblem\File.txt");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}