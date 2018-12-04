using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.DayThree
{
    public class ClaimsParser
    {
        public ClaimsParser(string input)
        {
            Input = input;
        }

        private string Input { get; }

        public List<Claim> ParsedClaims()
        {
            List<Claim> builtClaims = new List<Claim>();

            foreach (ClaimLineParser parsedLine in ParsedLines())
            {
                Claim claim = new Claim(parsedLine.Left(), parsedLine.Top(), parsedLine.Width(), parsedLine.Height(), parsedLine.ClaimId());
                builtClaims.Add(claim);
            }

            return builtClaims;
        }

        private List<ClaimLineParser> ParsedLines()
        {
            List<ClaimLineParser> parsedLines = new List<ClaimLineParser>();

            foreach (string inputLine in InputLines())
            {
                parsedLines.Add(new ClaimLineParser(inputLine));
            }

            return parsedLines;
        }

        private string[] InputLines()
        {
            return Input.Split('\n');
        }

        class ClaimLineParser
        {
            public ClaimLineParser(string line)
            {
                Line = line;
            }

            private string Line { get; }

            public int ClaimId()
            {
                return intValueFromMatchGroups("id");
            }

            public int Left()
            {
                return intValueFromMatchGroups("left");
            }

            public int Top()
            {
                return intValueFromMatchGroups("top");
            }

            public int Width()
            {
                return intValueFromMatchGroups("width");
            }

            public int Height()
            {
                return intValueFromMatchGroups("height");
            }

            private Regex regex = new Regex("#(?<id>\\d*) @ (?<left>\\d*),(?<top>\\d*): (?<width>\\d*)x(?<height>\\d*)");

            private int intValueFromMatchGroups(string key)
            {
                string stringValue = MatchGroups()[key].Value;
                return int.Parse(stringValue);
            }

            private GroupCollection MatchGroups()
            {
                Match match = regex.Match(Line);

                if (match.Success)
                {
                    return match.Groups;
                }
                else
                {
                    throw new Exception("No matches in claim line");
                }
            }
        }

    }
}
