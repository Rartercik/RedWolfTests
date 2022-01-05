using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    class PlaneDetail : Detail
    {
        public PlaneDetail()
        {
            Name = "Деталь самолёта";
            RequredTime = 10;
            RequredMetal = 16;
            RequredWood = 5;
        }
    }
}
