using System;
using AdventOfCode2018.DayOne;

namespace AdventOfCode2018
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day you'd like to run (e.g 1):");
            string keyPressed = Console.ReadKey(true).Key.ToString();

            if(keyPressed == "D1")
            {
                Console.WriteLine("Running day one...");
                runDayOne();
            }
            else
            {
                Console.WriteLine("No exercise specified for given day.");
            }
        }

        private static void runDayOne()
        {
            string input = System.IO.File.ReadAllText("./DayOne/DayOneInput.txt");
            DestinationLockGrabber destinationLockGrabber = new DestinationLockGrabber(input);

            int resultingFrequency = destinationLockGrabber.ResultingFrequency();
            int firstDuplicateValue = destinationLockGrabber.FirstDuplicateValue();

            Console.WriteLine("Resulting frequency:" + resultingFrequency.ToString());
            Console.WriteLine("First duplicate value:" + firstDuplicateValue.ToString());
        }
    }
}
