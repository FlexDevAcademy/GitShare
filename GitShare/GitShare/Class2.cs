﻿namespace GitShare
{
    internal class Class2
    {
        public string Dogs { get; set; }
        public int Cats { get; set; }

        private string NewString { get; set; }

        public void Say()
        {
            Console.WriteLine(NewString);
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
