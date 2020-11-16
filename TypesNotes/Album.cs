using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesNotes
{
    public class Album
    {
        public string Artist;
        public string Title;
        public string Genre;

        public void DiscJockey()
        {
            Console.WriteLine("You're listening to " + Title + " by " + Artist + ". Some smooth " + Genre);
        }

    }
}
