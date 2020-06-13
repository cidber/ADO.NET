using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Circle
    {
        Point center;
        double radius;
        public Circle (Point center,double radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public virtual double S
        {
            get
            {
                return Math.PI * Math.Pow(radius,2);
            }
            set
            {
                S = Math.PI * Math.Pow(radius, 2);
            }
        }

        public virtual double P
        {
            get
            {
                return 2 * Math.PI * radius;
            }
            set
            {
                P = 2 * Math.PI * radius;
            }
        }
        public virtual string Show()
        {
            return "Координаты: (" + center.x + ";" + center.y + ")" + "\n" + "Радиус:" + radius + "\n";
        }
    }
}