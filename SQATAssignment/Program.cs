using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQATAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection; 
            /*do while loop for user to select the option. If user 
             selects other options then loop will be executed*/
            do
            {
                // first selection
                Console.WriteLine("1. Enter Triangle Dimensions");
                // second selection
                Console.WriteLine("2. Exit");
                selection = Console.ReadLine();
            } while (selection !="1" || selection !="2" ); //user selects amonng these two options
            // if condition when user selects 1, user inputs 3 sides of the triangle
            if (selection == "1")
            {
                string side1;
                Console.WriteLine("Enter side 1: ");
                side1 = Console.ReadLine();
                string side2;
                Console.WriteLine("Enter side 2: ");
                side2 = Console.ReadLine();
                string side3;
                Console.WriteLine("Enter side 3: ");
                side3 = Console.ReadLine();
            }
            else // when user selects option 2, it exits
            {
                return;
            }
        }
    }
}
