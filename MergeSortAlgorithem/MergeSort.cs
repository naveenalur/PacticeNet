using System;

namespace MergeSortAlgorithem
{
    public class MergeSort
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 4, 3, 2, 1 };
            PrintArray(MergeSortElements(array));
            Console.ReadLine();
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i);
            }
        }

        public static int[] MergeSortElements(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int midPoint = array.Length / 2;
            int[] leftArray = new int[midPoint];
            int[] rightArray;
            if (array.Length % 2 == 0)
            {
                rightArray = new int[midPoint];
            }
            else
            {
                rightArray = new int[midPoint + 1];
            }

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[i];
            }
            for (int j = 0; j < rightArray.Length; j++)
            {
                rightArray[j] = array[midPoint + j];
            }

            int[] result = new int[array.Length];
            leftArray = MergeSortElements(leftArray);
            rightArray = MergeSortElements(rightArray);
            result = Merge(leftArray, rightArray);
            return result;


        }

        private static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int leftPointer, rightPointer, resultPointer;
            leftPointer = rightPointer = resultPointer = 0;
            int[] resultArray = new int[leftArray.Length + rightArray.Length];
            while (leftPointer < leftArray.Length || rightPointer < rightArray.Length)
            {
                if (leftPointer < leftArray.Length && rightPointer < rightArray.Length)
                {
                    if (leftArray[leftPointer] < rightArray[rightPointer])
                    {
                        resultArray[resultPointer++] = leftArray[leftPointer++];
                    }
                    else
                    {
                        resultArray[resultPointer++] = rightArray[rightPointer++];
                    }
                }
                else if (leftPointer < leftArray.Length)
                {
                    resultArray[resultPointer++] = leftArray[leftPointer++];

                }
                else if (rightPointer < rightArray.Length)
                {
                    resultArray[resultPointer++] = rightArray[rightPointer++];

                }

            }
            return resultArray;
        }
    }
}
