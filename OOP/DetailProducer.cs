using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedWolfTests
{
    class DetailProducer<TDetail>
        where TDetail : Detail, new()
    {

        public void ProduceDetail()
        {
            var detail = new TDetail();
            Console.WriteLine("Деталь \"{0}\" успешно сделана!", detail.ToString());
        }
        public int GetMetalCosts()
        {
            var detail = new TDetail();
            return detail.RequredMetal;
        }
        public int GetWoodCosts()
        {
            var detail = new TDetail();
            return detail.RequredWood;
        }
    }
}
