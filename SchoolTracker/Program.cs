using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student ID: ");
                newStudent.StudentId = int.Parse(Console.ReadLine());

                Console.Write("Student Credits: ");
                newStudent.NumberOfCredits = int.Parse(Console.ReadLine());

                Console.Write("Student GPA: ");
                newStudent.Gpa = double.Parse(Console.ReadLine());


                students.Add(newStudent);
                Student.Count++;
                //Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, ID: {1}", student.Name, student.StudentId);
            }
        }
    }    
}
