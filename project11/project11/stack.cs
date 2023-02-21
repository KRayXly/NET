using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11
{
    public class Stack<T>
    {
        private T[] s;
        int pos;
        public Stack(int size)
        {
            s = new T[size];
            pos = 0;
        }

        public void Push(T val)
        {
            s[pos] = val;
            pos++;
        }

        public T Pop()
        {
            pos--;
            return s[pos];
        }

        public void display()
        {
            Console.WriteLine("Stack Push:");
            foreach (T i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class Student
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
    public class Student_Num_ASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Num.CompareTo(y.Num);
        }
    }
    public class Student_Name_ASE : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Student_Age_ASE : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
    public class Student_Grade_ASE : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Grade.CompareTo(y.Grade);
        }
    }
}
