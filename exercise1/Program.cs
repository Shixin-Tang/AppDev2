using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercise 1
            Console.WriteLine("Ex.1 Write a  method SortArray to sort one dimensional array in descending order: ");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //output the original array
            Console.WriteLine("Original array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            SortArray(arr);

            //output the sorted array
            Console.WriteLine("\nSorted array in descending order: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            //exercise 2
            Console.WriteLine("\n\nEx.2 Write A Program To Print One Dimensional Array In Reverse Order: ");
            int[] arr2 = { 1, 3, 2, 10, 9, 6, 4, 7, 8, 5 };
            //output the original array
            Console.WriteLine("Original array: ");
            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }

            //output the reversed array
            Console.WriteLine("\nReversed array: ");
            for (int i = arr2.Length - 1; i >=0; i--)
            {
                Console.Write(arr2[i] + " ");
            }

            //exercise 3
            Console.WriteLine("\n\nEx.3 Write A Program To Add The Diagonal Of Two-Dimensional Array: ");
            int[,] arr3 = new int[5,5] { { 22, 50, 11, 2, 49 }, { 92, 63, 12, 64, 37 }, { 75, 23, 64, 12, 99 }, { 21, 25, 71, 69, 39}, { 19, 39, 58, 28, 83} };

            //output the original array
            Console.WriteLine("Original array: ");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the result to add the diagonal of the two-dimensional array is: " + AddDiagonal(arr3));


        }

        //method to sort the array in descending order
        public static void SortArray(int[] arr)
        {
            Array.Sort(arr, (a, b) => b.CompareTo(a));
        }

        //method to add the diagonal of a 2D array
        public static int AddDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            return sum;
        }
    }
}
