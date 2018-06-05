using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            Student obj2 = new Student(17,58.08F);

            OverloadStudent obj3 = new OverloadStudent();//Defult Constructor
            OverloadStudent obj4 = new OverloadStudent(43);//Single parameter
            OverloadStudent obj5 = new OverloadStudent(37, "Steve");//Two parameters

            Console.WriteLine(obj5);
        }
    }
}
