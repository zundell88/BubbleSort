using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSortTest
    {
        int[] intArray;
        Random rnd = new Random();
        static void Main(string[] args)
        {
            var test = new BubbleSortTest();
            for (int i = 10; i <= 15; i++)
            {
                var arrayLength = (int) Math.Pow(2, i);
                Console.WriteLine(test.GenerateUnsortedArray(arrayLength));
                Console.WriteLine(test.BubbleSort());
            }
        }

        public string GenerateUnsortedArray(int length)
        {
            intArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                intArray[i] = rnd.Next(length);
            }
            return $"Created array of length: {length}";
        }

        public string BubbleSort()
        {
            int temp;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int step = 0; step < intArray.Length-1; step++)
                for (int j = 0; j < intArray.Length-step-1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            stopwatch.Stop();
            return $"Bubble sorted the array in: {stopwatch.ElapsedMilliseconds} [ms]";
        }
    }

}
