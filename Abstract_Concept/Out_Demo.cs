using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{
    public class Out_Demo
    {
        public static void Calculation(int n1,int n2,out int add,out int sub, out int mul)
        {
            
           add=n1+n2;
           sub=n1-n2;
           mul=n1* n2;


        }
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            int add, sub, mul;
            Calculation( a, b,out  add, out sub,out  mul);
            Console.WriteLine("addition= "+add);
            Console.WriteLine("substrtion= "+sub);
            Console.WriteLine("multiplication= "+mul);
        }
    }
}
