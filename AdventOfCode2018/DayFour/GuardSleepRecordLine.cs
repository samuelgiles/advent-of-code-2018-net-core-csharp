using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.DayFour
{
    public class GuardSleepRecordRecordLine
    {
        private readonly Regex ParseRegex = new Regex(@"\[(?<year>\d*)-(?<month>\d*)-(?<day>\d*) (?<hour>\d*):(?<minute>\d*)\] (?<purpose>.*)");
        private readonly Regex GuardIdRegex = new Regex(@"Guard #(?<guardid>\d*) begins shift");
        private readonly string FallsAsleep = "falls asleep";
        private readonly string WakesUp = "wakes up";
        public enum RecordPurpose { BeginsShift, FallsAsleep, WakesUp }
        public GuardSleepRecordRecordLine(string line)
        {
            Line = line;
        }

        public RecordPurpose Purpose {
            get
            {
                return RecordPurpose.BeginsShift;
            }
        }

        public int? GuardId {
            get
            {
                return 1;
            }
        }

        public int Hour {
            get
            {
                return 1;
            }
        }

        public int Minute {
            get
            {
                return 1;
            }
        }

        // TODO: Parse out of line
        public int Day {
            get
            {
                return 1;
            }
        }

        public int Month {
            get
            {
                return 11;
            }
        }

        public int Year {
            get
            {
                return 1518;
            }
        }

        public string Line { get; }
    }
}
