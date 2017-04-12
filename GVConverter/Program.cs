using System;
using System.Windows.Forms;
using Npgsql;

namespace GVConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			NpgsqlEventLog.Level = LogLevel.Normal;
			NpgsqlEventLog.LogName = "NpgsqlTests.LogFile";
//			NpgsqlEventLog.EchoMessages = true;

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
