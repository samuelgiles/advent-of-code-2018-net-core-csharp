using System;
using System.Collections.Generic;

namespace AdventOfCode2018.DayThree
{
    public class FabricWithAtleastClaimsQuery
    {
        public FabricWithAtleastClaimsQuery(FabricWithClaims fabricWithClaims, int claimsCount)
        {
            FabricWithClaims = fabricWithClaims;
            ClaimsCount = claimsCount;
        }

        public int Results(){
            int squareInchesWithClaims = 0;

            var positionsWithClaims = FabricWithClaims.PositionsWithClaims();

            foreach(FabricPosition fabricPosition in positionsWithClaims.Keys){
                var claims = positionsWithClaims[fabricPosition];

                if(claims.Count >= ClaimsCount) {
                    squareInchesWithClaims++;
                }
            }

            return squareInchesWithClaims;
        }

        private FabricWithClaims FabricWithClaims { get; }
        private int ClaimsCount { get; }
    }
}
