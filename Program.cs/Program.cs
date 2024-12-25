using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number (x): ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number (y): ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation (+, -, *, /, %): ");
        string operation = Console.ReadLine();

        // Specify the full path to python.exe if necessary
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = @"C:\Users\Hp\AppData\Local\Microsoft\WindowsApps\python3.exe";
        start.Arguments = $"D:\\COMP 2210\\PythonCalc\\calculator.py {operation} {x} {y}"; // Pass arguments to the script
        start.UseShellExecute = false; // Do not use OS shell
        start.RedirectStandardOutput = true; // Redirect output
        start.RedirectStandardError = true; // Redirect error output
        start.CreateNoWindow = true; // Do not create a window

        try
        {
            using (Process process = Process.Start(start))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine("Result: " + result);
                }

                // Read any errors from the process
                string error = process.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine("Error: " + error);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
