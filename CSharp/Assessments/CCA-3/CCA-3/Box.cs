﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA_3
{
    internal class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public Box Add(Box box2)
        {
            double newLength = this.Length + box2.Length;
            double newBreadth = this.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Box Details -> Length is : {Length} & Breadth is : {Breadth}");
        }
    }

    internal class Test
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length for box1: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth for box1: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);

            Console.Write("Enter the length for box2: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth for box2: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());

            Box box2 = new Box(length2, breadth2);
            Box box3 = box1.Add(box2);

            box3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
