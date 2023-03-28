using System;

class Program
{
    static void Main()
    {
        //Input_Point
        double C1x = Convert.ToDouble(Console.ReadLine());
        double C1y = Convert.ToDouble(Console.ReadLine());
        double C2x = Convert.ToDouble(Console.ReadLine());
        double C2y = Convert.ToDouble(Console.ReadLine());

        //Input_Radius
        double radiusC1 = Convert.ToDouble(Console.ReadLine());
        double radiusC2 = Convert.ToDouble(Console.ReadLine());

        //Calculate_Distance_Between_C1_n_C2
        double x = C2x - C1x;
        double y = C2y - C1y;
        double distance = Math.Sqrt((x * x) + (y * y));

        if (distance <= radiusC1 + radiusC2) //Check_If_Intersect
        {
            double a = ((radiusC1 * radiusC1) - (radiusC2 * radiusC2) + (distance * distance)) / (2 * distance);
            double h = Math.Sqrt((radiusC1 * radiusC1) - (a * a));
            double midPointX = C1x + (a * (C2x - C1x)) / distance;
            double midPointY = C1y + (a * (C2y - C1y)) / distance;
            double VectorX = (h * (C2y - C1y)) / distance;
            double VectorY = (h * (C2x - C1x)) / distance;

            if (distance == radiusC1 + radiusC2) //Check_If_Connect
            {
                Console.WriteLine("{0:0.00}", midPointX - VectorX);
                Console.WriteLine("{0:0.00}", midPointY + VectorY);
            }

            else //If_Not_Connect
            {
                Console.WriteLine("{0:0.00}", midPointX - VectorX);
                Console.WriteLine("{0:0.00}", midPointY + VectorY);
                Console.WriteLine("{0:0.00}", midPointX + VectorX);
                Console.WriteLine("{0:0.00}", midPointY - VectorY);
            }
        }
    }
}
