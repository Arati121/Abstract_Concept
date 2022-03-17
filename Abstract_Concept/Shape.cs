using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{
  abstract public  class Shape
    {
        abstract public void CalculateArea();
    }
    public class Circle : Shape
    {
        private int radius;
        double result, PI = 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            result = PI * radius * radius;
        }
        public override string ToString()
        {
            return "Area of circle= " + result;
        }
    }
        public class Reactangle : Shape
        {
            private int length;
            private int breath;
            private int result;
            public Reactangle(int length,int breath)
            {
                this.length = length;
                this.breath = breath;
            }

            public override void CalculateArea()
            {
                result = length * breath;
            }
            public override string ToString()
            {
                return "Area of reactangle= " + result;
            }
        
    }
}
