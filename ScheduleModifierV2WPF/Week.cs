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

        public Week(List<string> schedule)
        {
            this.Monday = schedule[0];
            this.Tuesday = schedule[1];
            this.Wednesday = schedule[2];
            this.Thursday = schedule[3];
            this.Friday = schedule[4];
            this.Saturday = schedule[5];
            this.Sunday = schedule[6];
        }
    }
}
