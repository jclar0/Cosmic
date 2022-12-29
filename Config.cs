using System;
using System.Configuration;
using System.IO;
using System.Linq;

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
            string configPath = Path.Combine(configDir, "LAUNCHER_CONFIG.ini");

            if (!Directory.Exists(configDir))
            {
                // Fix for System.IO.DirectoryNotFoundException 
                Directory.CreateDirectory(configDir);
            }

            var MyIni = new IniFile(configPath); // Specify the .ini file we're using

            // Hack
            using (FileStream stream = File.Open(configPath, FileMode.Open, FileAccess.Read))
            {
                // Check if empty
                if (stream.Length == 0)
                {
                    // Write values
                    MyIni.Write("GameName", gameName);
                    MyIni.Write("Version", version);
                    MyIni.Write("WebsiteDir", website);
                }
            }

            // Read values
            gameName = MyIni.Read("GameName");
            version = MyIni.Read("Version");
            website = MyIni.Read("WebsiteDir");

            // Statements
            Console.WriteLine("Game Name: " + gameName);
            Console.WriteLine("Loaded Webpage: " + website);
        }
    }
}
