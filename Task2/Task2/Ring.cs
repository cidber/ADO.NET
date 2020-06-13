using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Ring : Circle
    {
        public double radius2;
        public double radius;
        public Ring(Point center, double radius, double radius2) : base(center, radius)
        {
            this.radius2 = radius2;
        }

        public override string Show()
        {
            return base.Show() + "Внутренний радиус:" + radius2 + "\n";
        }
        public override double S
        {
            get
            {
                return Math.PI * Math.Abs((Math.Pow(radius, 2) - Math.Pow(radius2, 2)));
            }
            set
            {
                S = Math.PI * Math.Abs((Math.Pow(radius, 2) - Math.Pow(radius2, 2)));
            }
        }

        public override double P
        {
            get
            {
                return 2 * Math.PI * radius + 2 * Math.PI * radius2;
            }
            set
            {
                P = 2 * Math.PI * radius + 2 * Math.PI * radius2;
            }
        }
    }
}