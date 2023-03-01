using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ZNO
    {
        public int Ukrainian { get; set; }
        public int Maths { get; set; }
        public int History { get; set; }
        public int English { get; set; }

        public ZNO()
        {
            Ukrainian = 120;
            Maths = 120;
            History = 120;
            English = 120;
        }
        public ZNO(int ukrainian, int maths, int history, int english)
        {
            Ukrainian = ukrainian;
            Maths = maths;
            History = history;
            English = english;
        }
        public ZNO(int ukrainian, int maths, int history)
        {
            Ukrainian = ukrainian;
            Maths = maths;
            History = history;
            English = 0;
        }

        public ZNO(ZNO zno)
        {
            Ukrainian= zno.Ukrainian;
            Maths= zno.Maths;
            History= zno.History;
            English= zno.English;
        }
    }
}
