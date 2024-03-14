using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codetest3
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, FirstName: {FirstName}, LastName: {LastName}, Title: {Title}, DOB: {DOB.ToShortDateString()}, DOJ: {DOJ.ToShortDateString()}, City: {City}";
        }
    }

    class genrics
    {
        static void Main()
        {
            Dictionary<int, Employee> empDict = new Dictionary<int, Employee>
        {
        {1001, new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("11/16/1984"), DOJ = DateTime.Parse("6/8/2011"), City = "Mumbai" }},
        {1002, new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("08/20/1984"), DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" }},
        {1003, new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("11/14/1987"), DOJ = DateTime.Parse("4/12/2015"), City = "Pune" }},
        {1004, new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("6/3/1990"), DOJ = DateTime.Parse("2/2/2016"), City = "Pune" }},
        {1005, new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("3/8/1991"), DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" }},
        {1006, new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("11/7/1989"), DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" }},
        {1007, new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("12/2/1989"), DOJ = DateTime.Parse("6/1/2015"), City = "Mumbai" }},
        {1008, new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("11/6/2014"), City = "Chennai" }},
        {1009, new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("8/12/1992"), DOJ = DateTime.Parse("12/3/2014"), City = "Chennai" }},
        {1010, new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("4/12/1991"), DOJ = DateTime.Parse("1/2/2016"), City = "Pune" }}
        };



        Console.WriteLine("Enter an option:\n" +
            "a. Display detail of all the employee\n " +
            "b. Display details of all the employee whose location is not Mumbai\n " +
            "c. Display details of all the employee whose title is AsstManager\n " +
            "d. Display details of all the employee whose Last Name start with S");

        string option = Console.ReadLine();

        switch (option)
        {
                case "a":
                    Console.WriteLine("Details of all employees:");
                    DisplayEmployees(empDict.Values.ToList());
                    break;
                case "b":
                    Console.WriteLine("Details of employees not in Mumbai:");
                    DisplayEmployees(empDict.Values.Where(e => e.City != "Mumbai").ToList());
                    break;
                case "c":
                    Console.WriteLine("Details of employees with title AsstManager:");
                    DisplayEmployees(empDict.Values.Where(e => e.Title == "AsstManager").ToList());
                    break;
                case "d":
                    Console.WriteLine("Details of employees with Last Name starting with S:");
                    DisplayEmployees(empDict.Values.Where(e => e.LastName.StartsWith("S")).ToList());
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
        }
            Console.Read();
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
                Console.Read();
            }
        }
    }
}
