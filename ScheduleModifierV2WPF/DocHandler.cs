using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ScheduleModifierV2WPF
{
    class DocHandler
    {
        public List<Employee> RunPythonToGetData()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\users\simas\appdata\local\programs\python\python39\python.exe";

            var script = @"C:\Users\simas\OneDrive\Documents\Programavimas\WordHandlerPy\DocHandler.py";

            psi.Arguments = $"\"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;

            var results = "";

            using(var process = Process.Start(psi))
            {
                results = process.StandardOutput.ReadToEnd();
            }
            
            List<Employee> employees = new List<Employee>();
            foreach (var item in results.Split('?').ToList())
            {
                List<string> schedule = item.Split('/').ToList();
                Employee employee = new Employee(schedule[0], schedule.GetRange(1, schedule.Count - 1));
                employees.Add(employee);
            }

            return employees;
        }
    }
}
