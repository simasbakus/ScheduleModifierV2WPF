using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleModifierV2WPF
{
    class Employee
    {
        public string Name { get; set; }

        //temp
        public List<string> Schedule { get; set; }
        /*public List<Week> Schedule { get; set; }*/

        public Employee(string name, List<string> schedule)
        {
            this.Name = name;

            //temp
            this.Schedule = schedule;

            //Needs to be adapted not fill first and last Week classes completely!!!!
            /*this.Schedule = new List<Week>();
            for (int i = 0; i < schedule.Count; i+=7)
            {
                this.Schedule.Add(new Week(schedule.GetRange(i, 7)));
            }*/
        }
    }
}
