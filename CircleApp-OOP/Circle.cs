using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp_OOP
{
    class Circle
    {
        public void SetRadius(double radius)
        {
            this.radius = Math.Abs(radius);
        }

        public double GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        // Type override - select ToString() - hit TAB
        public override string ToString()
        {
            return $"For a circle with a radius of {radius} "
                + $"the area is {GetArea()} and circumference is {GetCircumference()}";
        }

        // ATTRIBUTES (The data of the object)
        private double radius = 0;
    }
}
