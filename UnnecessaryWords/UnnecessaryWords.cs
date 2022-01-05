using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class UnnecessaryWords
    {
        public static void Start()
        {
            var text = "Строка Админ удалил привет Инструменты новый инструментарий про Строка котиков привет";
            var result = text.Replace("привет", "")
                .Replace("Строка", "")
                .Replace("Инструменты", "")
                .Replace("  ", " ")
                .Remove(0, 1);
            Console.WriteLine(result);
        }
    }
}
