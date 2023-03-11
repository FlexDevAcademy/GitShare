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

        public void Say()
        {
            Console.WriteLine("Hello");
        }


        static void Main(string[] args)
        {
            int hoursOfSleep = 5;

            bool isRested = hoursOfSleep >= 6;

            if (!isRested)
            {
                Console.WriteLine("Czas na spanko!");
            }
         }
    }
}
