using System;
using System.Collections.Generic;

namespace AdventOfCode2018.DayTwo
{
    public class BoxChecksumCalculator
    {
        public BoxChecksumCalculator(string input)
        {
            Input = input;
        }

        public int Checksum()
        {
            int twoTimesCount = 0;
            int threeTimesCount = 0;

            foreach(string inputLine in InputLines())
            {
                CharacterSummariser characterSummariser = new CharacterSummariser(inputLine);

                if (characterSummariser.ContainsALetterThatAppears(times: 2))
                {
                    twoTimesCount++;
                }

                if (characterSummariser.ContainsALetterThatAppears(times: 3))
                {
                    threeTimesCount++;
                }
            }

            return twoTimesCount * threeTimesCount;
        }

        private string Input { get; }

        private string[] InputLines()
        {
            return Input.Split('\n');
        }

        class CharacterSummariser
        {
            public CharacterSummariser(string input)
            {
                Input = input;
            }

            private string Input { get; }

            public bool ContainsALetterThatAppears(int times)
            {
                return CounterCharacters().ContainsValue(times);
            }

            private Dictionary<char, int> CounterCharacters()
            {
                CharacterCounter characterCounter = new CharacterCounter(Input);
                return characterCounter.Assess();
            }
        }

        class CharacterCounter
        {
            public CharacterCounter(string input)
            {
                Input = input;
            }

            private string Input { get; }

            public Dictionary<char, int> Assess()
            {
                Dictionary<char, int> lettersSeen = new Dictionary<char, int>();
                foreach (char character in Input)
                {
                    if (lettersSeen.ContainsKey(character))
                    {
                        lettersSeen[character] += 1;
                    }
                    else
                    {
                        lettersSeen.Add(character, 1);
                    }
                }
                return lettersSeen;
            }

        }
    }
}
