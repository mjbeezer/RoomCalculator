using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool application = true;

            while (application)
            {
                Console.WriteLine("Welcome to Room Calculator. Your trusted space measuring app since 2021.");

                Console.WriteLine("What is the length of the room?");
                string one = Console.ReadLine();
                double wallOne = double.Parse(one);
                Console.WriteLine("What is the width of the room?");
                string two = Console.ReadLine();
                double wallTwo = double.Parse(two);
                
                Console.WriteLine("What is the height of the room?");
                string height = Console.ReadLine();
                double hgt = double.Parse(height);

                //assume user inputs values from assignment
                //mathmetics to calculate perimeter and area
                double perimeter = wallOne * 2 + wallTwo * 2;
                double area = wallOne * wallTwo;
                double volume = area * hgt;
                Console.WriteLine($" The perimeter of the room is {perimeter} . The area of the room is {area}. The volume of the room is {volume}.");
                
                //calculate how much paint and carpet tiles are needed for the room
                double paint = perimeter / 5;
                double carpet = area / 5;
                Console.WriteLine($"You will need {paint} cans of paint. You will need {carpet} tiles.");
                
                //ask user if they want to measure another room
                Console.WriteLine("Would you like to measure another room? y/n");
                string keepGoing = Console.ReadLine();
                if (keepGoing == "y")
                {
                    application = true;
                }
                else
                {
                    application = false;
                }
            }
        }
    }
}