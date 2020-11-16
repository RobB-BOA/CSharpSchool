using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypesNotes.Math;
using TypesNotes.ArrayNotes;

namespace TypesNotes
{
    //enums need to be at the namespace level. Can't be within a class. 
    public enum ShippingMethod
    {
        Regular = 1,
        Registered = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calc = new Calculator();
            var result = calc.Add(12, 4);
            Console.WriteLine(result);

            var record = new Album();
            record.Artist = "The Smiths";
            record.Title = "Some whiney stuff";
            record.Genre = "Sad Bastard Music";
            record.DiscJockey();

            var numbs = new ArrayLessonOne();
            numbs.showArray();


            //String notes
            var first = "Bob";
            var last = "Bobbert";

            // Verbatim string: prefix string with the @ sign to easily deal with escape characters. Works with new line as well.
            var url = @"C:\stuff\things.exe
and
C:\weirdstuff\andthings.exe";

            // use string.Format instead of concat (+) to clean up code. 
            string name = string.Format("My name is {0} {1}. You can find my cool file in {2}", first, last, url);
            Console.WriteLine(name);


            //use string.Join to join multiple indexes of an array. 
            var numeros = new int[3] { 1, 2, 3 };
            string list = string.Join(", ", numeros);
            Console.WriteLine(list);

            //Strings are immutable (can't change them once set). 
            //Strings work like arrays, you can index the chars. 
            Console.WriteLine(name[7]);

            //Using enums

            //convert an enum to an integer with type conversion.
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //or if you have an int you can convert it to an enum
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //orrrr convert a string to an enum value
            var methodName = "Express";
            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

        }
    }
}
