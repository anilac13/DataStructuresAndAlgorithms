using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BubbleSortProblem
{
    public class BubbleSort
    {
        public void Sort(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            Console.WriteLine("Before sorting \n======================");
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.Write(data + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting \n======================");
            foreach (var data in arr)
            {
                Console.Write(data + " ");
            }
        }
    }
}
