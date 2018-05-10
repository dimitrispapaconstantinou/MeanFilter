using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meanfilter1
{
    public class Point
    {
        private int x;
        private int y;

       // public int X2{ get => x; set => x = value; }
        //public int Y { get => y; set => y = value; }

   

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }


        public Point(int xx, int yy)
        {
            this.x = xx;
            this.y = yy;

        }
        public static double EucDist( Point a, Point b)
        {
            double ed = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)) ;
            return ed;

        }
    }
}
