using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQATAssignment
{
    public static class TriangleSolver //static class triangle solver
    {
        //static method analyze which takes integer as input
        public static string Analyze (int side1, int side2, int side3) 
        {
            // if condition for triangle not formed
            if(side1 == 0 || side2 == 0 || side3 == 0)
            {
                return "Triangle cannot be formed";
            }
            // else if where all three sides are equal
            else if(side1 == side2 && side2 == side3)
            {
                return "It is an Equilateral Triangle";
            }
            // else if when any two sides are equal
            else if(side1 == side2 || side2 == side3 || side3 == side1)
            {
                return "It is an Isosceles Triangle";
            }
            // else if when no sides are equal
            else if(side1 != side2 || side2 != side3 || side3 != side1 )
            {
                return "It is a Scalene Triangle";
            }
            // if none of the statements apply, else condition is printed 
            else
            {
                return "Triangle cannot be formed";
            }
        }
    }
}
