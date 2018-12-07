using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.DayFour
{
    public class Minute
    {
        public enum Awakeness { Awake, Asleep, NotSpecified };

        public Minute(MinuteInDay index, Awakeness state)
        {
            Index = index;
            State = state;
        }

        public MinuteInDay Index { get; }
        public Awakeness State { get; }
    }
}
