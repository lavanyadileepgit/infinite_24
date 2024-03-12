using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Box
        {
            public double Length { get; set; }
            public double Breadth { get; set; }

            public Box(double length, double breadth)
            {
                Length = length;
                Breadth = breadth;
            }

            public static Box Add(Box box1, Box box2)
            {
                double newLength = box1.Length + box2.Length;
                double newBreadth = box1.Breadth + box2.Breadth;

                Box newBox = new Box(newLength, newBreadth);
                return newBox;
            }
        }

        public class Interface

        {
            static void Main(string[] args)
            {
                Console.Write("Enter Length for Box 1: ");
                double length1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Breadth for Box 1: ");
                double breadth1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Length for Box 2: ");
                double length2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Breadth for Box 2: ");
                double breadth2 = Convert.ToDouble(Console.ReadLine());

                Box box1 = new Box(length1, breadth1);
                Box box2 = new Box(length2, breadth2);

                Box sumBox = Box.Add(box1, box2);

                Console.WriteLine("\nSum of Boxes:");
                Console.WriteLine($"Length: {sumBox.Length}, Breadth: {sumBox.Breadth}");
                Console.ReadLine();
            }
        }
}

