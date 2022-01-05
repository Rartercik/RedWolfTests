using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class MedianNumbers
    {
        public static void Start()
        {
            var array1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var array2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var array = array1.Concat(array2).OrderBy(x => x).Select(x => x.ToString()).ToArray();
            var arrayText = String.Join(" ", array);
            var h1 = array.Length / 2;
            var h2 = array.Length / 2 - 1;
            var medianText =
                array.Length % 2 != 0
                ? array[h1]
                : String.Format("({0} + {1})/2 = ", array[h2], array[h1]) +
                ((Convert.ToDouble(array[h2]) + Convert.ToDouble(array[h1])) / 2).ToString();
            Console.WriteLine("merged array = [{0}] and median is {1}", arrayText, medianText);
        }
    }
}
