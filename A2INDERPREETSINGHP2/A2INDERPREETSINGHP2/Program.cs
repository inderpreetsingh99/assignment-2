using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2INDERPREETSINGHP2
{
    class Program
    {
        static double vol(double rad)
        {
            double volumesphere = 1.33 * 3.14159 * rad * rad * rad;
            return volumesphere;
        }

        static double vol(double rad, double height)
        {
            double volumecylinder = 3.14159 * rad * rad * height;
            return volumecylinder;
        }
        static double vol(double len, double width, double height)
        {
            double volumerprism = len * width * height;
            return volumerprism;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To calculate volume of sphere press 1");
            Console.WriteLine("To calculate volume of cylinder press 2");
            Console.WriteLine("To calculate volume of rectangular prism press 3");
            string x = Console.ReadLine();
            int choice = int.Parse(x);

            if (choice == 1)
            {
                Console.WriteLine("Enter Radius of Sphere");
                string r = Console.ReadLine();
                double rad = double.Parse(r);
                double Result = vol(rad);
                Console.WriteLine("The volume of sphere with  is " + Result);
            }
            if (choice == 2)
            {
                Console.WriteLine("Enter radius of sphere");
                string r = Console.ReadLine();
                double rad = double.Parse(r);
                Console.WriteLine("Enter height of cylinder");
                string h = Console.ReadLine();
                double height = double.Parse(h);
                double res = vol(rad, height);
                Console.WriteLine("The Volume of Cylinder is "+ res);
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter length of rectangular Prism");
                string l = Console.ReadLine();
                double len = double.Parse(l);
                Console.WriteLine("Enter width of rectangular Prism");
                string w = Console.ReadLine();
                double width = double.Parse(w);
                Console.WriteLine("Enter height of rectangular Prism");
                string h = Console.ReadLine();
                double height = double.Parse(h);
                double res = vol(len, width, height);
                Console.WriteLine("the volume of rectangular Prism with length is "+res);
            }
        }
    }
}  
