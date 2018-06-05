using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class OverloadStudent
    {
        public OverloadStudent()
        {
            //Default constructor
        }
        public OverloadStudent(int age)
        {
            //single parameter constructor
        }
        public OverloadStudent(int age, string name)
        {
            //two parameter constuctor
        }
    }
    
}
