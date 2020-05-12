using System;

namespace ConsoleApp1.GeometryExample
{
    public class Exercise1
    {
        public static void Main(string[] args)
        {
            Cylinder c1=new Cylinder();
            Console.WriteLine("Enter the dimension of the cynlinder: ");
            Console.WriteLine("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            c1.Process(radius,height);
            Console.WriteLine("Cylinder characteristics");
            Console.WriteLine("Radius: "+radius);
            Console.WriteLine("Height: "+height);
            c1.Result();
        }
    }
}