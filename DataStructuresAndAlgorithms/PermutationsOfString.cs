using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class PermutationsOfString
    {
        public void Permutation(string a, int b, int c)
        {
            if (b == c)
            {
                Console.WriteLine(a);
            }
            else
            {
                for (int i = b; i <= c; i++)
                {
                    a = Swap(a, b, i);
                    Permutation(a, b + 1, c);
                    a = Swap(a, b, i);
                }
            }
        }

        public string Swap(string d, int i, int j)
        {
            char temp;
            char[] arr = d.ToCharArray();
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            string result = new string(arr);
            return result;
        }
    }
}
