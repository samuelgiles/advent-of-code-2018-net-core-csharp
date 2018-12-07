using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.DayFour
{
    public class Guard
    {
        public Guard(int guardId)
        {
            GuardId = guardId;
            Days = new Dictionary<DayInYear, Day>();
        }

        public int GuardId { get; }
        public Dictionary<DayInYear, Day> Days { get; }
    }
}
