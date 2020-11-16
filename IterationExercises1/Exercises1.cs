using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercises1
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            //1 user enters a number between 1 and 10, if valid display valid, otherwise tell them it ain't valid.

            Console.WriteLine("Please enter a number between 1 and 10");
            var input = Console.ReadLine();
            var result = Int32.Parse(input);
            if (result >= 0 && result < 11)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("I said between 1 and 10!");
            }

            //2 user enters 2 numbers, output displays max of the 2.

            //Console.WriteLine("Please enter 2 numbers");
            //var a = Console.ReadLine();
            //var b = Console.ReadLine();

            //if (Int32.Parse(a) > Int32.Parse(b))
            //{
            //    Console.WriteLine(a + " is the larger of the two!");
            //}
            //else
            //{
            //    Console.WriteLine(b + " is the larger of the two!");
            //}

            //3 User inputs 2 dimensions, output tells them if it is landscape or portrait
            //Console.WriteLine("Enter the height of the image");
            //var a = Console.ReadLine();
            //Console.WriteLine("Enter the width of the image");
            //var b = Console.ReadLine();

            //if (Int32.Parse(a) > Int32.Parse(b))
            //{
            //    Console.WriteLine("That is a portrait");
            //}
            //else
            //{
            //    Console.WriteLine("That is a landscape");
            //}

            //4 user enters speed limit. user enters speed of a car. if speed is below limit output is OK. if not calc demerits. 5mph above
            //limit is 1 points, 12 is License Suspended.

            //Console.WriteLine("What is the speed limit?");
            //var limit = Console.ReadLine();
            //Console.WriteLine("How fast is dat car goin??");
            //var speed = Console.ReadLine();

            //var points = (Int32.Parse(speed) - Int32.Parse(limit)) / 5;

            //if(Int32.Parse(limit) > Int32.Parse(speed))
            //{
            //    Console.WriteLine("That car is doin fine");
            //}
            //else if(points > 12)
            //{
            //    Console.WriteLine("That driver is suspended!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Give that driver " + points + " points on their license");
            //}
        }
    }
}
