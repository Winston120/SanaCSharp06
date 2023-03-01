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
        public int Physics { get; set; }
        public int English { get; set; }

        public ZNO()
        {
            Ukrainian = 120;
            Maths = 120;
            Physics = 120;
            English = 120;
        }
        public ZNO(int ukrainian, int maths, int physics, int english)
        {
            Ukrainian = ukrainian;
            Maths = maths;
            Physics = physics;
            English = english;
        }
        public ZNO(int ukrainian, int maths, int physics)
        {
            Ukrainian = ukrainian;
            Maths = maths;
            Physics = physics;
            English = 0;
        }

        public ZNO(ZNO zno)
        {
            Ukrainian= zno.Ukrainian;
            Maths= zno.Maths;
            Physics= zno.Physics;
            English= zno.English;
        }
        public string GetInfo()
        {
            return $"Результати ЗНО:\n\tУкр. - {Ukrainian}\n\tМат - {Maths}\n\tФізика - {Physics}\n\tАнг. - {English}\n";
        }
    }
}
