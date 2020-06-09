using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    class Student
    {
        static public int Count = 0;

        public string Name;
        public int StudentId;
        public int NumberOfCredits;
        public double Gpa;

        
        public Student()
        {

        }

        public Student(string name, int studentid, int numberOfCredits, int gpa)
        {
            Name = name;
            StudentId = studentid;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

    }
}
