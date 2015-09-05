using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Tests.Helpers
{
    public class IISExpress
    {
        private const string IIS_EXPRESS = @"C:\Program Files\IIS Express\iisexpress.exe";
        private Process process;

        public static IISExpress Start(string config, string site, string apppool)
        {
            return new IISExpress(config, site, apppool);
        }

        private IISExpress(string config, string site, string apppool)
        {
            var arguments = new StringBuilder();
            arguments.AppendFormat("/{0}:{1} ", "config", config);
            arguments.AppendFormat("/{0}:{1} ", "site", site);
            arguments.AppendFormat("/{0}:{1} ", "apppool", apppool);

            process = Process.Start(new ProcessStartInfo
            {
                FileName = IIS_EXPRESS,
                Arguments = arguments.ToString(),
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            });
        }

        public void Stop()
        {
            SendStopMessageToProcess(process.Id);
            process.Close();
        }

        private static void SendStopMessageToProcess(int pidToStop)
        {
            for (var ptr = NativeMethods.GetTopWindow(IntPtr.Zero); ptr != IntPtr.Zero; ptr = NativeMethods.GetWindow(ptr, 2))
            {
                uint pid;
                NativeMethods.GetWindowThreadProcessId(ptr, out pid);
                if (pidToStop == pid)
                {
                    var hWnd = new HandleRef(null, ptr);
                    NativeMethods.PostMessage(hWnd, 0x12, IntPtr.Zero, IntPtr.Zero);
                    return;
                }
            }
        }

        private static class NativeMethods
        {
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern IntPtr GetTopWindow(IntPtr hWnd);
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern uint GetWindowThreadProcessId(IntPtr hwnd, out uint lpdwProcessId);
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern bool PostMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        }
    }
}
