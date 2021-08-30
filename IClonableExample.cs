using System;
using System.Collections;

namespace DemoIclonable
{
    public class Student : ICloneable
    {
        private int rollNo;
        private string Name;
        public Student(int rollNo, string Name)
        {
            this.rollNo = rollNo;
            this.Name = Name;
        }
        public object Clone()
        {
            return new Student(this.rollNo, this.Name);
        }
        public override string ToString()
        {
            return string.Format("Roll no:{0}\nName:{1}",this.rollNo,this.Name);
        }
    }
    class IClonableExample
    {
        static void Main(string[] args)
        {
            Student ST1 = new Student(17, "Vivek");
            Student ST2 = ST1.Clone() as Student;

            Console.WriteLine("{0}mm", ST1);
            Console.WriteLine("{0}mm", ST2);
        }
    }
}
