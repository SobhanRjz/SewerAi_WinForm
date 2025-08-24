using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AISewerPipes
{
	internal static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(int dwProcessId);
        const int ATTACH_PARENT_PROCESS = -1;

        // Use CreateFile to bind to the console device explicitly
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeFileHandle CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const uint FILE_SHARE_READ = 0x00000001;
        const uint FILE_SHARE_WRITE = 0x00000002;
        const uint OPEN_EXISTING = 3;


        [STAThread]
		static void Main()
		{
            //EnsureConsoleBound();            // <-- Do this BEFORE creating any forms
            
            //Console.Title = "My WinForms Console";
            //Console.ForegroundColor = ConsoleColor.Gray;     // avoid black-on-black
            //Console.Write("Hello from WinForms!");
            //Console.WriteLine("Console ready.");
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
        static void EnsureConsoleBound()
        {
            // 1) Attach to parent or allocate a fresh console
            if (!AttachConsole(ATTACH_PARENT_PROCESS))
                AllocConsole();

            // 2) Bind StdOut/StdErr explicitly to CONOUT$ and StdIn to CONIN$
            var outHandle = CreateFile("CONOUT$", GENERIC_WRITE | GENERIC_READ,
                                       FILE_SHARE_WRITE | FILE_SHARE_READ,
                                       IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
            var inHandle = CreateFile("CONIN$", GENERIC_READ | GENERIC_WRITE,
                                       FILE_SHARE_READ | FILE_SHARE_WRITE,
                                       IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);

            if (!outHandle.IsInvalid)
            {
                var outStream = new FileStream(outHandle, FileAccess.Write);
                var writer = new StreamWriter(outStream, Encoding.UTF8) { AutoFlush = true };
                Console.SetOut(TextWriter.Synchronized(writer));
                Console.SetError(TextWriter.Synchronized(writer));
            }

            if (!inHandle.IsInvalid)
            {
                var inStream = new FileStream(inHandle, FileAccess.Read);
                var reader = new StreamReader(inStream, Encoding.UTF8);
                Console.SetIn(reader);
            }
        }
    }
}
