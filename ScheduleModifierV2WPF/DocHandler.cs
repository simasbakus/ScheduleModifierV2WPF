﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using IronPython.Hosting;
using System.Diagnostics;

namespace ScheduleModifierV2WPF
{
    class DocHandler
    {
        public string runPythonToGetData()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\users\simas\appdata\local\programs\python\python39\python.exe";

            var script = @"C:\Users\simas\OneDrive\Documents\Programavimas\WordHandlerPy\DocHandler.py";

            psi.Arguments = $"\"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var results = "";

            using(var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            if (errors == "")
            {
                List<List<string>> y = new List<List<string>>();
                foreach (var item in results.Split(']').ToList())
                {
                    List<string> x = item.Split(',').ToList();
                    y.Add(x);
                }
                return y[0][3];
            }
            else
            {
                return errors;
            }
        }
    }
}