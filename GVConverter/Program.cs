using System;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;
using GVConverter.Froms;

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


        private static void EncryptConfigSection(string sectionKey)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); 
            ConfigurationSection section = config.GetSection(sectionKey);
            if (section != null)
            {
                if (!section.SectionInformation.IsProtected)
                {
                    if (!section.ElementInformation.IsLocked)
                    {
                        section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                        section.SectionInformation.ForceSave = true;
                        config.Save(ConfigurationSaveMode.Full);
                    }
                }
            }
        }


    }
    /// <summary>
    /// for delegate parameters between forms
    /// </summary>
    public static class CallBackMy
    {
        public delegate void callbackEvent(string what);
        public static callbackEvent callbackEventHandler;

        public delegate void callbackClearmessage(string what);
        public static callbackClearmessage callbackClearHandler;

    }





}
