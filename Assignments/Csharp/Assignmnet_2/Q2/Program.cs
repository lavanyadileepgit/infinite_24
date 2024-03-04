using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    using System;

    class Student
    {
        private int rollNo;
        private string name;
        private string className;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string className, int semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subs:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            double totalMarks = 0;
            foreach (var mark in marks)
            {
                totalMarks += mark;
                if (mark < 35)
                {
                    Console.WriteLine("Result: Failed");
                    return;
                }
            }

            double average = totalMarks / 5;
            if (average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Roll Number: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            string className = Console.ReadLine();

            Console.Write("Enter Semester: ");
            int semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();

            Student student = new Student(rollNo, name, className, semester, branch);

            student.GetMarks();
            student.DisplayResult();
            student.DisplayData();
            Console.Read();
        }
    }

}
