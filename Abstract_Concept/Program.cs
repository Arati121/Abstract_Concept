using System;

namespace Abstract_Concept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(4);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Reactangle r1 = new Reactangle(4, 5);
            r1.CalculateArea();
            Console.WriteLine(r1);
        }
    }
}
