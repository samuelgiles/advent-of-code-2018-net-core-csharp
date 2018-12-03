using System;

namespace AdventOfCode2018.DayOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("./DayOne/DayOneInput.txt");
            DestinationLockGrabber destinationLockGrabber = new DestinationLockGrabber(input);

            string resultingFrequency = destinationLockGrabber.ResultingFrequency().ToString();

            Console.WriteLine(resultingFrequency);
        }
    }
}
