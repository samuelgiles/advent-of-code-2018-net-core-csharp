using System;
using System.Collections.Generic;

namespace AdventOfCode2018.DayThree
{
    public class FabricWithClaims
    {
        public FabricWithClaims(Fabric fabric, List<Claim> claims)
        {
            Fabric = fabric;
            Claims = claims;
        }

        public Dictionary<FabricPosition, List<Claim>> PositionsWithClaims() {
            SquareInches = new Dictionary<FabricPosition, List<Claim>>();

            GenerateEmptySquares();
            PlotClaimOntoSquares();

            return SquareInches;
        }

        private void GenerateEmptySquares() {

            for (int x = 0; x <= Fabric.Width; x++)
            {
                for(int y = 0; y <= Fabric.Height; y++) {
                    FabricPosition fabricPosition = new FabricPosition(x, y);
                    SquareInches.Add(fabricPosition, new List<Claim>());
                }
            }
        }

        private void PlotClaimOntoSquares() {
            foreach(Claim claim in Claims) {
                foreach(FabricPosition fabricPosition in claim.Positions()) {
                    SquareInches[fabricPosition].Add(claim);
                }
            }
        }

        private Fabric Fabric { get; }
        private List<Claim> Claims { get; }
        private Dictionary<FabricPosition, List<Claim>> SquareInches { get; set; }
    }
}
