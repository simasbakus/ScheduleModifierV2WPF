using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleModifierV2WPF
{
    class Employee
    {
        public string Name { get; set; }
        public List<Week> Schedule { get; set; }

        public Employee(string name, List<string> schedule, int firstDay)
        {
            this.Name = name;
            this.Schedule = new List<Week>();

            // Calculations to get max number of iterations needed
            int iterCount = schedule.Count + firstDay;
            int rowCount = iterCount % 7 == 0 ? iterCount / 7 : (int)(iterCount / 7 + 1);
            iterCount = rowCount * 7;
            
            List<string> tempList = new List<string>();
            for (int i = 0; i <= iterCount; i++)
            {
                if ((i % 7) == 0 && i > 0)
                {
                    this.Schedule.Add(new Week(tempList));
                    tempList.Clear();
                }

                if (i < firstDay || i >= schedule.Count + firstDay)
                {
                    tempList.Add(null);
                }
                else
                {
                    tempList.Add(schedule[i - firstDay]);
                }
            }
        }
    }
}
