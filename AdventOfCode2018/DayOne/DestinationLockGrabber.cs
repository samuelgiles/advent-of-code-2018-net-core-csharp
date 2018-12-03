using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2018.DayOne
{
    public class DestinationLockGrabber
    {
        public DestinationLockGrabber(string input)
        {
            Input = input;
        }

        public string Input { get; }

        public int ResultingFrequency()
        {
            List<int> inputInts = InputInts();
            int startingFrequency = inputInts.First();
            int finalValue = startingFrequency;
            List<int> remainingFrequenciesToApply = InputInts().GetRange(index: 1, count: inputInts.Count()-1);

            foreach (int frequencyToApply in remainingFrequenciesToApply)
            {
                finalValue += frequencyToApply;
            }

            return finalValue;
        }

        private List<int> InputInts()
        {
            InputParser inputParser = new InputParser(Input);
            return inputParser.AsInts();
        }

        class InputParser
        {
            public InputParser(string inputLines)
            {
                InputLines = inputLines;
            }

            private string InputLines { get; }

            public List<int> AsInts()
            {
                StringReader stringReader = new StringReader(InputLines);
                List<int> parsedInts = new List<int>();

                while (true)
                {
                    string line = stringReader.ReadLine();

                    if (line != null)
                    {
                        InputLine inputLine = new InputLine(line);
                        parsedInts.Add(inputLine.AsInt());
                    }
                    else
                    {
                        break;
                    }
                }

                return parsedInts;
            }
        }

        class InputLine
        {
            public InputLine(string inputLine)
            {
                line = inputLine;
            }

            private string line { get; }

            public int AsInt()
            {
                return int.Parse(line);
            }
        }
    }
}
