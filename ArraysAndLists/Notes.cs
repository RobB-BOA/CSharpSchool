using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Notes
    {
        static void Main(string[] args)
        {       
            //Built in array methods:
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine(numbers.Length);

            //IndesOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            //Clear() clearing numbers results in 0, clearing boolean results in false, clearing strings results in Null.
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach(var n in numbers)
                Console.WriteLine(n);

        }
    }
}
