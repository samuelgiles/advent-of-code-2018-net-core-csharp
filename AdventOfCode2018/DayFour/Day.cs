using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.DayFour
{
    public class Day
    {
        public Day(DayInYear dayInYear)
        {
            DayInYear = dayInYear;
            Minutes = GenerateEmptyDayMinutes();
        }

        private Dictionary<MinuteInDay, Minute> GenerateEmptyDayMinutes() {
            var generatedMinutes = new Dictionary<MinuteInDay, Minute>();

            for(var h = 0; h <= 23; h++) {
                for(var m = 0; m <= 59; m++) {
                    MinuteInDay minuteInDay = new MinuteInDay(h, m);
                    Minute minute = new Minute(minuteInDay, Minute.Awakeness.NotSpecified);
                    generatedMinutes.Add(minuteInDay, minute);
                }
            }

            return generatedMinutes;
        }

        public Dictionary<MinuteInDay, Minute> Minutes { get; }

        public DayInYear DayInYear { get; }
    }
}
