using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Iterations
    {
        static void Main(string[] args)
        {
            //For loops in C#:
            //for (var i = 1; i <= 10; i++)
            //{
            //    if(i%2 == 0)
            //    { 
            //    Console.WriteLine(i);
            //    }

            //}
            //for(var i = 10; i >=1; i--)
            //{
            //    if(i%2 == 0)
            //    {
            //    Console.WriteLine(i);
            //    }
            //}
            //foreach example:
            //var name = "John Smith";
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var letter in name) 
            //{
            //    Console.WriteLine(letter);
            //}
            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach(var numb in numbers)
            //{
            //    Console.WriteLine(numb);
            //}

            //while loop examples:
            //var i = 0;
            //while (i<=10)
            //{
            //    if ( i % 2 == 0)
                
            //        Console.WriteLine(i);
            //        i++;
                
            //}

            //Same while loop 2 different ways:
            //while(true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    Console.WriteLine("@Echo " + input);
            //}

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();
            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo " + input);
            //        continue;
            //    }
            //        break;
            //}

            //Random Class
            var random = new Random();
            var length = 20;

            var buffer = new char[length];
            for(var i = 0; i < length; i++)
                //Console.WriteLine(random.Next(1, 10));
                buffer[i]=((char)('a' + random.Next(0, 26)));

            var password = new string(buffer);

                Console.WriteLine(password);



        }
    }
}
