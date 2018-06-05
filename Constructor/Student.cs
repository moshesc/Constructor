using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Student
    {
        int roll;
        float marks;
        public Student()//Constructor
        {
            roll = 0;
            marks = 0.0F;
        }
        public Student(int a, float b) //Constractor
        {
            roll = a;
            marks = b;
        }
    }
}
