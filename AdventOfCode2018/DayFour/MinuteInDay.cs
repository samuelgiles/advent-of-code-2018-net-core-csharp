using System;
namespace AdventOfCode2018.DayFour
{
    public class MinuteInDay : Tuple<int, int>
    {
        public MinuteInDay(int hour, int minute) : base(hour, minute)
        {
        }
    }
}
