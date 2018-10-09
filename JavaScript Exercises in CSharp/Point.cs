using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{
    class Point
    {

            public int X;
            public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
        
    }
}
