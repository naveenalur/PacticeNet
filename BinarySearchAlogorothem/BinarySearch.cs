using System;

namespace BinarySearchAlogorothem
{
    public class BinarySearch
    {
        private static void Main(string[] args)
        {
            int[] array = { 4, 23, 14, 1, 2 };

            PrintArray(SortArray(array));

            int poistion = BinarySearchFindKey(0, array.Length, 14, SortArray(array));
            if (poistion != -1)
                Console.WriteLine("The element present at " + poistion + "\n");

            Console.WriteLine("Using recursion ");
            int poistion1 = BinarySearchByRecursion(0, array.Length, 2, SortArray(array));
            if (poistion1 != -1)
                Console.WriteLine("The element present at " + poistion1 + "\n");

            Console.ReadLine();
        }

        public static int BinarySearchFindKey(int low, int high, int key, int[] array)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] < key)
                {
                    low = mid + 1;
                }
                else if (array[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public static int BinarySearchByRecursion(int low, int high, int key, int[] array)
        {
            if (high >= low)
            {
                int mid = (low + high) / 2;
                if (array[mid] == key)
                    return mid;
                else if (array[mid] > key)
                {
                    return BinarySearchByRecursion(low, mid - 1, key, array);
                }
                else if (array[mid] < key)
                {
                    return BinarySearchByRecursion(mid + 1, high, key, array);
                }
            }
            return -1;
        }
        public static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} Hey my position is {i} ");
            }
            Console.WriteLine("-----------------------------------------");
        }
    }
}