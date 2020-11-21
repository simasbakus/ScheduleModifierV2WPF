using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ScheduleModifierV2WPF
{
    class DataParser
    {
        readonly DocHandler doc = new DocHandler();
        public string Date { get; set; }
        private string Data { get; set; }

        public DataParser()
        {
            string[] text = doc.RunPythonToGetData().Split('%');
            this.Date = text[0];
            this.Data = text[1];
        }

        public List<Employee> ParseDataToList()
        {
            List<Employee> employees = new List<Employee>();
            foreach (string item in this.Data.Split('?').ToList())
            {
                List<string> schedule = item.Split('/').ToList();
                Employee employee = new Employee(schedule[0], schedule.GetRange(1, schedule.Count - 1), getFirstWeekday());
                employees.Add(employee);
            }

            return employees;
        }

        public int getFirstWeekday()
        {
            int year = int.Parse(this.Date.Substring(0, 4));
            int month = int.Parse(this.Date.Substring(5, 2));
            DateTime dateTime = new DateTime(year, month, 1);

            // returns zero based integer starting from monday
            return ((int)dateTime.DayOfWeek == 0) ? 6 : (int)dateTime.DayOfWeek - 1;
        }
    }
}
