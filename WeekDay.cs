﻿using System.ComponentModel;

namespace WorkHourCalculator
{
    public enum WeekDay
    {
        [Description("شنبه")]
        Saturday = 0,
        [Description("یکشنبه")]
        Sunday = 1,
        [Description("دوشنبه")]
        Monday = 2,
        [Description("سه شنبه")]
        Tuesday = 3,
        [Description("چهارشنبه")]
        Wednesday = 4,
        [Description("پنجشنبه")]
        Thursday = 5,
        [Description("جمعه")]
        Friday = 6
    }

}
