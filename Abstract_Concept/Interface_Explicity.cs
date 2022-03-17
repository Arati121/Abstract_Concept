using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{
    class Interface_Explicity
    {
        interface ICustomer
        {
            string Detalis();
        }

        interface IOperation
        {
            string Details();
        }

        public class Customer:ICustomer,IOperation
        {
            string ICustomer.Detalis()
            {
                return "customer deatils";
            }
            string IOperation.Details()
            {
                return "Operation deatils";
            }
        }
    }
}