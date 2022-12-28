using System;
using System.IO;
using System.Linq;

namespace Cosmic
{
    class Config
    {
        // Set the default values for the options
        public static string gameName = "";
        public static string version = "0.3";
        public static string website = "https://www.github.com/jclar0/Cosmic/";

        public static void Read()
        {
            // Workaround
            string configDir = Directory.GetCurrentDirectory() + "\\config";
            string configPath = Path.Combine(configDir, "LAUNCHER_CONFIG.txt");

            if (!Directory.Exists(configPath))
            {
                // Fix for System.IO.DirectoryNotFoundException 
                Directory.CreateDirectory(configDir);
            }

            // Check if the config file exists
            if (File.Exists(configPath))
            {
                // Read the options from the config file
                string[] lines = File.ReadAllLines(configPath);
                foreach (string line in lines)
                {
                    // Split the line into key-value pairs
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        // Trim any leading or trailing whitespace
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        // Set the option based on the key
                        if (key == "gameName")
                        {
                            gameName = value;
                        }
                        else if (key == "version")
                        {
                            version = value;
                        }
                        else if (key == "website")
                        {
                            website = value;
                        }
                    }
                }
            }
            else
            {
                // Create the config file with the default options
                string[] lines = {
                    "gameName = " + gameName,
                    "version = " + version,
                    "website = " + website
                };
                File.WriteAllLines(configPath, lines);
            }

            // Print some information that could be useful
            Console.WriteLine("[INFO] Directory: " + Directory.GetCurrentDirectory()) ;
            Console.WriteLine("[INFO] Configuration File Directory: " + configPath);
            Console.WriteLine("[INFO] Game Name: " + gameName);
            Console.WriteLine("[INFO] Game Version: " + version);
            Console.WriteLine("[INFO] Selected Website: " + website);
        }
    }
}
