using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedWolfTests
{
    static class OOPTask
    {
        public static void Start()
        {
            int recordTime = 0;
            int recordMetal = 0;
            int recordWood = 0;

            var automobileProducer = new DetailProducer<AutomobileDetail>();
            var shipProducer = new DetailProducer<ShipDetail>();
            var planeProducer = new DetailProducer<PlaneDetail>();

            var requredDetails = 5;

            for(int i = 0; i < requredDetails; i++)
            {
                ProduceDetail(automobileProducer, ref recordMetal, ref recordWood);
                ProduceDetail(shipProducer, ref recordMetal, ref recordWood);
                ProduceDetail(planeProducer, ref recordMetal, ref recordWood);
            }
            recordTime = CountTime(requredDetails, new int[] { new AutomobileDetail().RequredTime,
                new ShipDetail().RequredTime, 
                new PlaneDetail().RequredTime }
            );
            Console.WriteLine();

            Console.WriteLine("Все детали успешно изготовлены!");
            Console.WriteLine("Было затрачено {0} секунд, {1} металла и {2} дерева", recordTime, recordMetal, recordWood);

        }
        private static void ProduceDetail<T>(DetailProducer<T> detail, ref int recordMetal, ref int recordWood)
            where T : Detail, new()
        {
            detail.ProduceDetail();
            recordMetal += detail.GetMetalCosts();
            recordWood += detail.GetWoodCosts();
        }
        private static int CountTime(int number, int[] detailsTime)
        {
            var maxTime = 0;
            foreach (var e in detailsTime)
                if (e > maxTime) maxTime = e;
            return maxTime * number;
        }
    }
}
