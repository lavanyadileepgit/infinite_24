using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string Name { get; }
    public int Id { get; }

    protected Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual bool CheckStatus(double score)
    {
        return false;
    }
}

class Ug : Person
{
    public double Grade { get; }

    public Ug(string name, int id, double grade) : base(name, id)
    {
        Grade = grade;
    }

    public override bool CheckStatus(double score)
    {
        return score > 70.0;
    }
}

class Grad : Person
{
    public double Score { get; }

    public Grad(string name, int id, double grade) : base(name, id)
    {
        Score = grade;
    }

    public override bool CheckStatus(double score)
    {
        return score > 80.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter ID: ");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid ID provided.");
            return;
        }

        Console.Write(" ug or pg:  ");
        char role = Convert.ToChar(Console.ReadLine().ToUpper());

        double inputScore;
        Person person;
        if (char.Equals(role, 'U'))
        {
            Console.Write("Enter your grade: ");
            if (!double.TryParse(Console.ReadLine(), out inputScore))
            {
                Console.WriteLine("Invalid grade provided.");
                return;
            }
            person = new Ug(name, id, inputScore);
            Console.WriteLine("Undergraduate " + person.Name + " status: " + (person.CheckStatus(inputScore) ? "Approved" : "Not Approved"));
        }
        else if (char.Equals(role, 'G'))
        {
            Console.Write("Enter your score: ");
            if (!double.TryParse(Console.ReadLine(), out inputScore))
            {
                Console.WriteLine("Invalid ...........");
                return;
            }
            person = new Grad(name, id, inputScore);
            Console.WriteLine("Graduate " + person.Name + " status: " + (person.CheckStatus(inputScore) ? "Approved" : "Not Approved"));
        }
        else
        {
            Console.WriteLine("Invalid.........");
        }
        Console.Read();
    }
}
