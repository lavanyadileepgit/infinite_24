using System;
namespace assignment5
{

    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee ID: {Empid}, Name: {Empname}, Salary: {Salary}");
        }
    }

    public class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }

        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary)
        {
            Wages = wages;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Wages: {Wages}");
        }
    }

    class fullpartemp

    {
        static void Main()
        {
            Console.WriteLine("Enter details for Full-time Employee:");
            Console.Write("Employee ID: ");
            int empid = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string empname = Console.ReadLine();

            Console.Write("Employee Salary: ");
            float salary = float.Parse(Console.ReadLine());

            Employee employee = new Employee(empid, empname, salary);

            Console.WriteLine("\nEnter details for Part-time Employee:");
            Console.Write("Employee ID: ");
            empid = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            empname = Console.ReadLine();

            Console.Write("Employee Salary: ");
            salary = float.Parse(Console.ReadLine());

            Console.Write("Employee Wages: ");
            float wages = float.Parse(Console.ReadLine());

            ParttimeEmployee parttimeEmployee = new ParttimeEmployee(empid, empname, salary, wages);

            Console.WriteLine("\nFull-time Employee Details:");
            employee.Display();

            Console.WriteLine("\nPart-time Employee Details:");
            parttimeEmployee.Display();

            Console.ReadLine();
        }
    }
}
