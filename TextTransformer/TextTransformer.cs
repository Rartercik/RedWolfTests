using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class TextTransformer
    {
        public static void Start()
        {
            var startArray = Console.ReadLine().Split();
            var target = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            var flag = false;

                for(int i = 0; i < startArray.Length; i++)
                {
                    for(int j = 0; j < startArray.Length; j++)
                    {
                        if (i == j) continue;

                        if (startArray[i] + startArray[j] == target)
                        {
                            Console.WriteLine("-({0}, {1}): \"{2}\" + \"{3}\"", i, j, startArray[i], startArray[j]);
                            count--;
                        }

                        if(count <= 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag) break;
                }
        }
    }
}
