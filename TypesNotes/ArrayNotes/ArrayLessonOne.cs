using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesNotes.ArrayNotes
{
    public class ArrayLessonOne
    {
        int[] numbers = new int[4] { 1, 2, 3, 4 };

        bool[] flags = new bool[3] { true, false, true };

        string[] names = new string[3] { "Sam", "Joe", "Bob" };

        public void showArray()
        {
            Console.WriteLine(flags[0]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(names[2]);
            Console.WriteLine(numbers[1]);

        }


    }
}
