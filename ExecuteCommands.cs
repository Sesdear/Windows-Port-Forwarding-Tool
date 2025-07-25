using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Forwarding_Tool
{
    internal class ExecuteCommands
    {
        public static async Task addNetsh(string fromIp, string fromPort, string toIp, string toPort)
        {
            string command = $"netsh interface portproxy add v4tov4 listenaddress={fromIp} listenport={fromPort} connectaddress={toIp} connectport={toPort}";
            await ExecuteCommand(command);
        }

        public static async Task removeNetsh(string fromIp, string fromPort)
        {
            string command = $"netsh interface portproxy delete v4tov4 listenaddress={fromIp} listenport={fromPort}";
            await ExecuteCommand(command);
        }

        public static async Task ExecuteCommand(string command)
        {
            try
            {
                var process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c {command}";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Verb = "runas"; 

                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
}