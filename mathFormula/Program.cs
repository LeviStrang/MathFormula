using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathFormula
{
    class Program
    {
          static void Main(string[] args)
        {
            
            //Task 1
            //Calculate Circumference based on user input of radius

            double Circle_Area, Circle_Circumf, circle_Radius;

            Console.WriteLine("Enter radius of the circle.");

            circle_Radius = Convert.ToDouble(Console.ReadLine());

            Circle_Area = Math.PI * circle_Radius * circle_Radius;
            Console.WriteLine($"The area of the circle is:{Circle_Area}");

            Circle_Circumf = 2 * Math.PI * circle_Radius;
            Console.WriteLine($"The circumference of the circle is:{Circle_Circumf}");
            Console.ReadLine();

            ////Task 2
            ////Calculate volume of a hemisphere based on user input of radius
            
            //double Vol, Radius;


            //Console.Write("Please input the radius of the hemisphere:");
            //Radius = Convert.ToDouble(Console.ReadLine());

            //Vol = (4.0 / 3 * Math.PI * Math.Pow(Radius, 3) / 2);

            //Console.WriteLine($"The volume of the Hemisphere is: {Vol}");
            //Console.ReadLine();

            ////Task 3
            ////Calculate the area of a triangle based on user input of all three sides

            //double sideA, sideB, sideC, P, areaT;

            //Console.WriteLine("In order to tell the area of a triangle we will need the length of all three sides. \nPlease give the length of side A of the triangle: ");
            //sideA = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nGreat! Now side B: ");
            //sideB = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nPerfect! And now side C: ");
            //sideC = Convert.ToDouble(Console.ReadLine());

            //P = ((sideA + sideB + sideC) / 2);

            //areaT = Math.Sqrt(P * (P - sideA) * (P - sideB) * (P - sideC));

            //Console.WriteLine($"\nThank you for your help. The area of the triangle is: {areaT}.");
            //Console.ReadLine();

            ////Task 4
            ////Solve for quadratic equation based on user input of "A", "B" and "C"
            
            //double A, B, C, X1, X2;

            //Console.WriteLine("We are now going to solve a quadratic equation with the quadratic formula. \nPLease input A:");
            //A = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nThank you!\nNow input B:");
            //B = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nFantastic!\nAnd lastly C:");
            //C = Convert.ToDouble(Console.ReadLine());

            //X1 = (-B - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
            //X2 = (-B + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);


            //Console.WriteLine($"Thank you for helping!\nThe solved equation is:{X1}.");
            //Console.WriteLine($"Or {X2}");
            //Console.ReadLine();
        }
    }
}
