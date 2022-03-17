using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{
    public delegate int Mydelegate(int a, int b);
    public delegate String Mydegate1(string name);

    public class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

    }
    public class Test
    {
        public string AcceptName(string name)
        {
            return name.ToUpper();
        }
    }
    public class Test1
    {
        public string Acceptname1(string name1)
        {
            return name1.ToLower();
        }
    }
}

