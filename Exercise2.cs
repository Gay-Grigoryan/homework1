using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercise1
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 50, 4, 7, 3, 90 };
            InsertionSort(arr, arr.Length);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        public static void InsertionSort(int[] arr, int n)
        {

            if (n <= 1)
                return;

            InsertionSort(arr, n - 1);

            int last = arr[n - 1];
            int i = n - 2;

            while (i >= 0 && arr[i] > last)
            {
                arr[i + 1] = arr[i];
                i--;
            }
            arr[i + 1] = last;
        }
    }
}
