using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    class ShipDetail : Detail
    {
        public ShipDetail()
        {
            Name = "Деталь корабля";
            RequredTime = 15;
            RequredMetal = 2;
            RequredWood = 8;
        }
    }
}
