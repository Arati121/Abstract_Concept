using System;

namespace Abstract_Concept
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Circle c1 = new Circle(4);
            //Console.WriteLine(c1.test());
            //c1.CalculateArea();
            //Console.WriteLine(c1);

            //Reactangle r1 = new Reactangle(4, 5);
            //r1.CalculateArea();
            //Console.WriteLine(r1);

            //User u1 = new User();
            //try
            //{
            //    int age = u1.AcceptAge(15);
            //    Console.WriteLine("this user valid  for votting=" + age);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Name n1 = new Name();
            try
            {
                //string name = n1.AcceptName("arati");
                String name = n1.AcceptName("");
                Console.WriteLine("the name is="+name);
            }
            catch(NameException ex )
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
