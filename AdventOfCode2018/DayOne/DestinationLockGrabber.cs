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
            return InputInts().Sum();
        }

        public int FirstDuplicateValue()
        {
            List<int> inputInts = InputInts();
            HashSet<int> seenFrequences = new HashSet<int>();
            int finalValue = 0;

            while (true)
            {
                foreach (int frequencyToApply in InputInts())
                {
                    finalValue = finalValue + frequencyToApply;

                    if (seenFrequences.Contains(finalValue))
                    {
                        return finalValue;
                    }

                    seenFrequences.Add(finalValue);
                }
            }
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
                Line = inputLine;
            }

            private string Line { get; }

            public int AsInt()
            {
                return int.Parse(Line);
            }
        }
    }
}
