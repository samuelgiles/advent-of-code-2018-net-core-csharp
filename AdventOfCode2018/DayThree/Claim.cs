using System;
namespace AdventOfCode2018.DayThree
{
    public class Claim
    {
        public Claim(int inchesFromLeft, int inchesFromTop, int width, int height, int claimId)
        {
            InchesFromLeft = inchesFromLeft;
            InchesFromTop = inchesFromTop;
            Width = width;
            Height = height;
            ClaimId = claimId;
        }

        private int ClaimId { get; }
        private int InchesFromLeft { get; }
        private int InchesFromTop { get; }
        private int Width { get; }
        private int Height { get; }
    }
}
