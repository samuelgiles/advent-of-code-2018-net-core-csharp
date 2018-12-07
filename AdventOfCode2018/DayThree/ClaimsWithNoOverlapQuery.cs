using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.DayThree
{
    public class ClaimsWithNoOverlapQuery
    {
        public ClaimsWithNoOverlapQuery(FabricWithClaims fabricWithClaims)
        {
            FabricWithClaims = fabricWithClaims;
        }

        public List<int> Results(){
            var claimIdsWithoutOverlap = new List<int>();

            var positionsWithClaims = FabricWithClaims.PositionsWithClaims();

            foreach(var claims in positionsWithClaims.Values) {
                foreach(var claim in claims) {
                    claimIdsWithoutOverlap.Add(claim.ClaimId);
                }
            }

            claimIdsWithoutOverlap = claimIdsWithoutOverlap.Distinct().ToList();

            foreach(FabricPosition fabricPosition in positionsWithClaims.Keys){
                var claims = positionsWithClaims[fabricPosition];

                if(claims.Count != 1) {
                    foreach(Claim claimToRemove in claims) {
                        claimIdsWithoutOverlap.Remove(claimToRemove.ClaimId);
                    }
                }
            }

            return claimIdsWithoutOverlap;
        }

        private FabricWithClaims FabricWithClaims { get; }
    }
}
