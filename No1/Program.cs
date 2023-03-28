using System;

class Program
{

    static void Main(string[] args)
    {
        //Input
        double P1X = Convert.ToDouble(Console.ReadLine()); 
        double P1Y = Convert.ToDouble(Console.ReadLine()); 
        double P2X = Convert.ToDouble(Console.ReadLine()); 
        double P2Y = Convert.ToDouble(Console.ReadLine()); 
        double P3X = Convert.ToDouble(Console.ReadLine()); 
        double P3Y = Convert.ToDouble(Console.ReadLine());

        // Calculate_Center_Of_Circle
        double Cx = ((P2X - P1Y) * (P3Y * P3Y - P1Y * P1Y + P3X * P3X - P1X * P1X) + (P3Y - P1Y) * (P1Y * P1Y - P2Y * P2Y + P1X * P1X - P2X * P2X)) / (2 * (P3X - P1X) * (P2Y - P1Y) - 2 * (P2X - P1X) * (P3Y - P1Y));
        double Cy = ((P2X - P1X) * (P3X * P3X - P1X * P1X + P3Y * P3Y - P1Y * P1Y) + (P3X - P1X) * (P1X * P1X - P2X * P2X + P1Y * P1Y - P2Y * P2Y)) / (2 * (P3Y - P1Y) * (P2X - P1X) - 2 * (P2Y - P1Y) * (P3X - P1X));

        //Calculate_Radius
        double Radius = Math.Sqrt((P1X - Cx) * (P1X - Cx) + (P1Y - Cy) * (P1Y - Cy));

        // Output
        Console.WriteLine(Cx);
        Console.WriteLine(Cy);
        Console.WriteLine(Radius);
    }
}
