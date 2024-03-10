using System;
using System.Linq;

namespace WorkHourCalculator
{
    public class StartEndRange
    {
        public string Start { get; set; } = string.Empty;
        public string End { get; set; } = string.Empty;

        public TimeSpan? Calculate()
        {
            var hh = Start.Split(':');
            var hh2 = End.Split(':');
            try
            {
                if (hh.Count() == 2 && hh2.Count() == 2)
                {
                    TimeSpan startTime = TimeSpan.Parse(Start.ToString());
                    TimeSpan endTime = TimeSpan.Parse(End.ToString());
                    // Calculate the duration
                    TimeSpan duration = endTime - startTime;

                    return duration;
                }
              
            }
            catch (Exception)
            {
            }

            return null;
        }

    }

}
