using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitShare
{
    internal class Class2
    {
        public int Age { get; set; }
        public int Cats { get; set; }


        static void Main(string[] args)
        {
            int hoursOfSleep = 7;

            bool isRested = hoursOfSleep >= 8;

            if (!isRested)
            {
                Console.WriteLine("Czas na spanko!");
            }
        }
    }
}
