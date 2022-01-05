using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class RandomArrayNegative
    {
        public static void Start()
        {
            var array = new int[10];
            var random = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = random.Next(-5, 6);
            var result = array.Where(x => x >= 0)
                .OrderBy(x => x)
                .Select(x => x.ToString())
                .ToArray();
            Console.WriteLine(result.Aggregate((a, b) => a + " " + b));
        }
    }
}
