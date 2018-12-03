using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.DayTwo
{
    public class CommonBoxIdCalculator
    {
        public CommonBoxIdCalculator(string input)
        {
            Input = input;
            DesiredLength = InputLines().First().Length -1;
        }

        private string Input { get; }
        private int DesiredLength { get; }

        public string CommonLettersOnCorrectBoxId()
        {
            string[] inputLines = InputLines();

            for (int i = 0; i < (inputLines.Length -1); i++) {
                string currentLine = inputLines[i];

                for (int inner = 0; inner < (inputLines.Length - 1); inner++)
                {
                    if(inner == i) { continue; }

                    string otherLine = inputLines[inner];
                    CommonCharacters commonCharacters = new CommonCharacters(currentLine, otherLine);
                    string calculatedCommonCharacters = commonCharacters.Calculate();

                    if(calculatedCommonCharacters.Length == DesiredLength)
                    {
                        return calculatedCommonCharacters;
                    }
                }
            }

            return "";
        }

        private string[] InputLines()
        {
            return Input.Split('\n');
        }

        class CommonCharacters {
            public CommonCharacters(string inputA, string inputB)
            {
                InputA = inputA;
                InputB = inputB;
            }

            private string InputA { get; }
            private string InputB { get; }

            public string Calculate()
            {
                string commonCharacters = "";

                for (int i = 0; i < InputA.Length; i++)
                {
                    char inputACharacter = InputA[i];
                    char inputBCharacter = InputB[i];

                    if(inputACharacter == inputBCharacter)
                    {
                        commonCharacters += inputACharacter;
                    }
                }

                return commonCharacters;
            }
        }
    }
}
