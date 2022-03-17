using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Concept
{

    public class AgeException : Exception
    {
        public AgeException(string msg) : base(msg)
        {

        }
    }
    public class User
    {
        public int AcceptAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("this user not vaild form vote");
            }
            return age;
        }
       
    }
   
        
    
}
