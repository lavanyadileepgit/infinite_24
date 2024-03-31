using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeassignment
{
    public class employee
    {
        public int EmployeeID { get; set; }
        public string firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Doj { get; set; }
        public string City { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<employee>employeelist = new List<employee>{
            new employee
            {
              EmployeeID = 1001, 
              firstname = "Malcolm", 
              Lastname = "Daruwalla", 
              Title = "Manager",
              Dob = new DateTime(1984, 11, 16), 
              Doj = new DateTime(2011, 6, 8), 
              City = "Mumbai" },
            new employee
            {
              EmployeeID = 1002, 
              firstname = "Asdin", 
              Lastname = "Dhalla", 
              Title = "AsstManager",
              Dob = new DateTime(1984, 8, 20), 
              Doj = new DateTime(2012, 7, 7), 
              City = "Mumbai" },
            new employee 
            {
              EmployeeID = 1003, 
              firstname = "Madhavi", 
              Lastname = "Oza", 
              Title = "Consultant",
              Dob = new DateTime(1987, 11, 14), 
              Doj = new DateTime(2015, 4, 12), 
              City = "Pune" },
            new employee 
            {
              EmployeeID = 1004, 
              firstname = "Saba", 
              Lastname = "Shaikh", 
              Title = "SE",
              Dob = new DateTime(1990, 6, 3),
              Doj = new DateTime(2016, 2, 2), 
              City = "Pune" },
            new employee
            {
              EmployeeID = 1005, 
              firstname = "Nazia", 
              Lastname = "Shaikh", 
              Title = "SE",
              Dob = new DateTime(1991, 3, 8), 
              Doj = new DateTime(2016, 2, 2), 
              City = "Mumbai" },
            new employee 
            {
                EmployeeID = 1006, 
                firstname = "Amit", 
                Lastname = "Pathak", 
                Title = "Consultant",
                Dob = new DateTime(1989, 11, 7), 
                Doj = new DateTime(2014, 8, 8), 
                City = "Chennai" },
            new employee 
            {
                EmployeeID = 1007, 
                firstname = "Vijay", 
                Lastname = "Natrajan", 
                Title = "Consultant",
                Dob = new DateTime(1989, 12, 2), 
                Doj = new DateTime(2015, 6, 1), 
                City = "Mumbai" },
            new employee 
            {
                EmployeeID = 1008, 
                firstname = "Rahul",
                Lastname = "Dubey",
                Title = "Associate",
                Dob = new DateTime(1993, 11, 11), 
                Doj = new DateTime(2014, 11, 6), 
                City = "Chennai" },
            new employee 
            { 
                EmployeeID = 1009, 
                firstname = "Suresh",
                Lastname = "Mistry", 
                Title = "Associate",
                Dob = new DateTime(1992, 8, 12),
                Doj = new DateTime(2014, 12, 3), 
                City = "Chennai" },
            new employee 
            { 
                EmployeeID = 1010, 
                firstname = "Sumit",
                Lastname = "Shah",
                Title = "Manager",
                Dob = new DateTime(1991, 4, 12),
                Doj = new DateTime(2016, 1, 2),
                City = "Pune" }
        };
        Console.WriteLine("employee's who joined before '01-01-2015' are: ");
        var emp1 = from emp in employeelist
                       where emp.Doj < new DateTime(2015, 1, 1)
                       select emp;
        foreach (var emp in emp1)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", emp.EmployeeID, emp.firstname, emp.Lastname, emp.Title, emp.Dob, emp.Doj, emp.City);

            }
            Console.WriteLine();
            Console.WriteLine("employee's whose dob is after '01-01-1990' is: ");
        
            var emp2 = from emp in employeelist
                       where emp.Dob > new DateTime(1990, 1, 1)
                       select emp;
        foreach(var emp in emp2)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}",emp.EmployeeID,emp.firstname,emp.Lastname,emp.Title,emp.Dob,emp.Doj,emp.City);
                
            }
            Console.WriteLine();
            Console.WriteLine("employee's whose designation is consultant or assoicate is :");
            var emp3=from emp in employeelist
                     where emp.Title =="Consultant" ||emp.Title=="Associate"
                     select emp;
            foreach(var emp in emp3)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", emp.EmployeeID, emp.firstname, emp.Lastname, emp.Title, emp.Dob, emp.Doj, emp.City);
            }
            Console.WriteLine();
            Console.WriteLine("total count of employee's are : {0}",employeelist.Count());
            Console.WriteLine();
            Console.WriteLine("total number of employee's belonging to chennai as as follows:");
            var emp4 = from emp in employeelist
                       where emp.City == "Chennai"
                       select emp;
            foreach (var emp in emp4)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", emp.EmployeeID, emp.firstname, emp.Lastname, emp.Title, emp.Dob, emp.Doj, emp.City);
            }
            Console.WriteLine();
            Console.WriteLine("Highest employee id from the employee list are as follows: {0} ", employeelist.Max(emp => emp.EmployeeID));
            Console.WriteLine();
            Console.WriteLine( "total no. of employee's joined after '01/01/2015 is : {0}",employeelist.Count(emp=>emp.Doj> new DateTime(2015,1,1)));
            Console.WriteLine();
            Console.WriteLine("total no. of employee's whose designation is not associate is {0} : ",employeelist.Count(emp=>emp.Title!="Associate"));
            Console.WriteLine();
            Console.WriteLine("total no. of employee's based on city :");
            var emp5 = from e in employeelist
                         group e by e.City into g
                         select new { City = g.Key, Count = g.Count() };

            foreach (var r in emp5)
            {
                Console.WriteLine($"{r.City}: {r.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("total no. of employee's based on city and title :");
            var emp6 = from e in employeelist
                       group e by e.City into g 
                       select new { City = g.Key, Count = g.Count() };

            foreach (var r in emp5)
            {
                Console.WriteLine($"{r.City}: {r.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("Total number of employees in each city and title:");
            var emp7 = from emp in employeelist
                         group emp by new { emp.City, emp.Title } into g
                         select new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() };
            foreach (var city in emp7)
            {
                Console.WriteLine("{0} {1}: {2}", city.City, city.Title, city.Count);
            }
            Console.WriteLine();
            Console.WriteLine("The youngest employee in the list is: ");
            var emp8 = (from emp in employeelist
                          orderby emp.Dob
                          select emp).First();
            Console.WriteLine("{0} {1} {2} {3} ",emp8.EmployeeID,emp8.firstname,emp8.Lastname,emp8.Title);
            Console.Read();
        }
    }
}

    

