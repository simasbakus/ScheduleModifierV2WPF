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
            ProcessStartInfo psi = new ProcessStartInfo() { FileName = @"C:\users\simas\appdata\local\programs\python\python39\python.exe" };

            string script = @"C:\Users\simas\OneDrive\Documents\Programavimas\WordHandlerPy\DocHandler.py";

            psi.Arguments = $"\"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;

            string results = "";

            using(Process process = Process.Start(psi))
            {
                results = process.StandardOutput.ReadToEnd();
            }
            
            List<Employee> employees = new List<Employee>();
            foreach (string item in results.Split('?').ToList())
            {
                List<string> schedule = item.Split('/').ToList();
                Employee employee = new Employee(schedule[0], schedule.GetRange(1, schedule.Count - 1));
                employees.Add(employee);
            }

            return employees;
        }
    }
}
