using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleModifierV2WPF
{
    class Week
    {
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

        public Week(List<string> weekdays)
        {
            this.Monday = weekdays[0];
            this.Tuesday = weekdays[1];
            this.Wednesday = weekdays[2];
            this.Thursday = weekdays[3];
            this.Friday = weekdays[4];
            this.Saturday = weekdays[5];
            this.Sunday = weekdays[6];
        }
    }
}
