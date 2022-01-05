using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    class AutomobileDetail : Detail
    {
        public AutomobileDetail()
        {
            Name = "Деталь автомобиля";
            RequredTime = 5;
            RequredMetal = 7;
            RequredWood = 3;
        }
    }
}
