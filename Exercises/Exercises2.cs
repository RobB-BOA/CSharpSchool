using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Exercises2
    {
        static void Main(string[] args)
        {
            //1 count numbers between 1 and 100 that are divisible by 3, display the count
            //var count = 0;
            //for(var i = 1; i <= 100; i++)
            //    if(i%3 == 0)
            //    {
            //        count++;
            //    }
            //Console.WriteLine(count);

            //2 user enters as many numbers until typing ok. displays sum of all numbers

            //var total = 0;
            //while(true)
            //{
            //Console.WriteLine("Enter the numbers you wish to add. Type 'ok' or hit enter to finish.");
            //var input = Console.ReadLine();
            //    if (String.IsNullOrEmpty(input) || input == "ok")
            //        break;
            //    total += Int32.Parse(input);
            //}
            //Console.WriteLine(total);

            //3 user enters a number, compute factorial and output.
            //Console.WriteLine("Let's find the factorial! Enter a number...");
            //var input = Int32.Parse(Console.ReadLine());
            //var output = 1;
            //for (var i = input; i > 1; i--)
            //{
            //    output *= i ;
            //}
            //Console.WriteLine(output);

            //4 random number between 1 and 10, user gets 4 chances, if they guess display 'You Win, if not 'You Lost'
            //var random = new Random();
            //var secretNumber = random.Next(1, 10);
            //Console.WriteLine("Guess a number between 1 and 10!");
            //Console.WriteLine(secretNumber);

            //for(var i = 0; i <4;i++)
            //{
            //    var input = Int32.Parse(Console.ReadLine());

            //if(input == secretNumber)
            //    {
            //        Console.WriteLine("You Win");
            //        break;
            //    }
            //    else if(i<3)
            //    {
            //        Console.WriteLine("Nope, keep guessing");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you lose! The secret number was " + secretNumber);
            //    }

            //}

            //5 user enters numbers until they don't, find max number. This works but not what exactly what the exercise was asking for.. 

            //var max = 0;
            //Console.WriteLine("Enter as many number as you want and I'll find the max. Hit enter when you want me to do my thing...");
            //while(true)
            //{
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    if(Int32.Parse(input) > max)
            //    {
            //        max = Int32.Parse(input);
            //    }
            //}
            //Console.WriteLine("The biggest number you entered was " + max + ".");

            //The correct way:

            Console.WriteLine("Enter Numbers seperated by a comma");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach(var number in numbers)
            {
                if(Convert.ToInt32(number) > max)
                {
                    max = Convert.ToInt32(number);
                }
            }
            Console.WriteLine("Highest number is {0}", max);
                


          
        }
    }
}
