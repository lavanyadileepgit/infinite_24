using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Type: Dayscholar");
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Type: Resident");
        }
    }

    class student
    {
        static void Main()
        {
            IStudent student;
            Console.Write("Enter student type (1 for Dayscholar, 2 for Resident): ");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                student = new Dayscholar();
            }
            else
            {
                student = new Resident();
            }

            Console.Write("Enter student ID: ");
            student.StudentId = int.Parse(Console.ReadLine());

            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();

            student.ShowDetails();

            Console.ReadLine();
        }
    }

}

