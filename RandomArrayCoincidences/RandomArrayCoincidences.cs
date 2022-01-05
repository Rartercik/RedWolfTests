using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class RandomArrayCoincidences
    {
        public static void Start()
        {
            var array1 = new int[10];
            var array2 = new int[10];
            var random = new Random();
            int summary = 0;

            for (int i = 0; i < 10; i++)
            {
                array1[i] = random.Next(1, 6);
                array2[i] = random.Next(1, 6);
            }
            for(int i = 0; i < array1.Length; i++)
            {
                var index2 = FindCoinsidence(array1[i], array2);
                if (index2 != -1)
                {
                    Console.WriteLine("{0}, indexes: {1} | {2}", array1[i], i, index2);
                    summary += array1[i];
                }
            }
            Console.WriteLine("Summary: " + summary);
        }
        private static int FindCoinsidence(int arg, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == arg) return i;
            return -1;
        }
    }
}
