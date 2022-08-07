using System;

class Circle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double circumference = 2 * Math.PI * radius;
        double diameter = 2 * radius;
        Console.WriteLine("Area of circle: " + area + "\nCircumference of circle: " + circumference + "\nDiameter of circle: " + diameter);
        Console.ReadKey();
    }
}





