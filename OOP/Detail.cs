using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWolfTests
{
    abstract class Detail
    {
        protected string Name;
        private int requredTime;
        private int requredMetal;
        private int requredWood;

        public int RequredTime
        {
            get
            {
                return requredTime;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                requredTime = value;
            }
        }
        public int RequredMetal
        {
            get
            {
                return requredMetal;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                requredMetal = value;
            }
        }
        public int RequredWood
        {
            get
            {
                return requredWood;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                requredWood = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
