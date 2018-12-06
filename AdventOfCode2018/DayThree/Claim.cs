using System;
using System.Collections.Generic;

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

        public List<FabricPosition> Positions() {
            List<FabricPosition> positions = new List<FabricPosition>();

            for(var x = 0; x < Width; x++) {
                for(var y = 0; y < Height; y++) {
                    int calculatedX = x + InchesFromLeft;
                    int calculatedY = y + InchesFromTop;

                    positions.Add(new FabricPosition(calculatedX, calculatedY));
                }
            }

            return positions;
        }

        private int ClaimId { get; }
        private int InchesFromLeft { get; }
        private int InchesFromTop { get; }
        private int Width { get; }
        private int Height { get; }
    }
}
