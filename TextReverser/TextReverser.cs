using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class TextReverser
    {
        public static void Start()
        {
            var text = Console.ReadLine();
            Console.WriteLine(new string(text.Reverse().ToArray()));
        }
    }
}
