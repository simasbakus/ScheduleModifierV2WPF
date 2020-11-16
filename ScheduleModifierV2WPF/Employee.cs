using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleModifierV2WPF
{
    class Employee
    {
        public string Name { get; set; }
        public List<string> Schedule { get; set; }

        public Employee(string name, List<string> schedule)
        {
            this.Name = name;
            this.Schedule = schedule;
        }
    }
}
