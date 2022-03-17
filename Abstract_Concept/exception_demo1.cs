using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{
    public class exception_demo1
    {
        static void Main(string[] args)
        { 

            int[] arr = new int[3] { 1, 5, 6 };
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
