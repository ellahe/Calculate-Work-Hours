using System;

namespace WorkHourCalculator
{
    public class WeekDayHour
    {
        public string WeekDay { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now.Date;
        public StartEndRange Start1 { get; set; } = new StartEndRange();
        public StartEndRange Start2 { get; set; } = new StartEndRange();
        public StartEndRange Start3 { get; set; } = new StartEndRange();
        public string CalculateHours { get => Calculate().ToString(); }
        public string CalculateMinutes { get => Calculate().TotalMinutes.ToString(); }
        public TimeSpan Calculate()
        {
            var timeSpan = new TimeSpan();
            if (Start1.Calculate() != null)
                timeSpan = Start1.Calculate().Value;
            if (Start2.Calculate() != null)
                timeSpan = timeSpan.Add(Start2.Calculate().Value);
            if (Start3.Calculate() != null)
                timeSpan = timeSpan.Add(Start3.Calculate().Value);

            return timeSpan;
        }
    }

}
