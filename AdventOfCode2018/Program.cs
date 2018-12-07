using System;
using System.Collections.Generic;
using AdventOfCode2018.DayOne;
using AdventOfCode2018.DayThree;
using AdventOfCode2018.DayTwo;

namespace AdventOfCode2018
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day you'd like to run (e.g 1):");
            string keyPressed = Console.ReadKey(true).Key.ToString();

            if (keyPressed == "D1")
            {
                Console.WriteLine("Running day one...");
                runDayOne();
            }
            else if (keyPressed == "D2")
            {
                Console.WriteLine("Running day two...");
                runDayTwo();
            }
            else if (keyPressed == "D3")
            {
                Console.WriteLine("Running day three...");
                runDayThree();
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

        private static void runDayTwo()
        {
            string input = System.IO.File.ReadAllText("./DayTwo/DayTwoInput.txt");

            BoxChecksumCalculator boxChecksumCalculator = new BoxChecksumCalculator(input);
            Console.WriteLine("Checksum for box IDs:" + boxChecksumCalculator.Checksum().ToString());

            CommonBoxIdCalculator commonBoxIdCalculator = new CommonBoxIdCalculator(input);
            Console.WriteLine("Common box ID characters:" + commonBoxIdCalculator.CommonLettersOnCorrectBoxId());
        }

        private static void runDayThree()
        {
            string input = System.IO.File.ReadAllText("./DayThree/Input.txt");
            int claimsCount = 2;

            ClaimsParser claimsParser = new ClaimsParser(input);
            List<Claim> claims = claimsParser.ParsedClaims();
            Fabric fabric = new Fabric(1000, 1000);
            FabricWithClaims fabricWithClaims = new FabricWithClaims(fabric, claims);
            FabricWithAtleastClaimsQuery fabricWithAtleastClaimsQuery = new FabricWithAtleastClaimsQuery(fabricWithClaims, claimsCount);

            Console.WriteLine($"Square inches with at-least {claimsCount.ToString()} claims: {fabricWithAtleastClaimsQuery.Results().ToString()}");

            ClaimsWithNoOverlapQuery claimsWithNoOverlapQuery = new ClaimsWithNoOverlapQuery(fabricWithClaims);
            int foundClaimId = claimsWithNoOverlapQuery.Results()[0];
            Console.WriteLine($"ID of only claim that doesn't overlap: {foundClaimId.ToString()}");
        }
    }
}