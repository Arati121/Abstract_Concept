using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{

    public class NameException:Exception
    {
        public  NameException(string msg) : base(msg)
        {

        }

    }
    public class Name
    {

        public String AcceptName(String Name)
        {
            if(String.IsNullOrEmpty(Name))
            {
                throw new NameException("the name either empty or null");
            }
            return Name;
        }
  
}
    }

