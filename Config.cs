using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cosmic
{
    class Config
    {
        // Set the default values for the options
        public static string gameName = "";
        public static string version = "";
        public static string website = "";

        public static void Read()
        {
            string configDir = Directory.GetCurrentDirectory() + "\\config";
            string configPath = Path.Combine(configDir, "Launcher_Config.ini");

            if (!Directory.Exists(configDir))
            {
                // Fix for System.IO.DirectoryNotFoundException 
                Directory.CreateDirectory(configDir);
            }

            try
            {
                var MyIni = new IniFile(configPath); // Specify the .ini file we're using

                // Read values
                gameName = MyIni.Read("GameName");
                version = MyIni.Read("Version");
                website = MyIni.Read("WebsiteDir");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Missing configuration file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
