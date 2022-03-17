using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{
    class Exception_dividedbyZero
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0,result;
            try
            {
                result = a / b;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("excute finally block");
            }
        }
    }
}
