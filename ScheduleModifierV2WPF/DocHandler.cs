using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ScheduleModifierV2WPF
{
    class DocHandler
    {
        public string RunPythonToGetData()
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

            return results;
        }
    }
}
