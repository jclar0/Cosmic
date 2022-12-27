using System;
using System.IO;
using System.Linq;

namespace Cosmic
{
    class Config
    {
        // Set the default values for the options
        public static string gameName = "";
        public static string version = "1.0";

        public static void Read()
        {
            // Check if the config file exists
            string configPath = "LAUNCHER_CONFIG.txt";

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
                    }
                }
            }
            else
            {
                // Create the config file with the default options
                string[] lines = {
                    "gameName = " + gameName,
                    "version = " + version
                };
                File.WriteAllLines(configPath, lines);
            }

            // Print the options
            Console.WriteLine("Game name: " + gameName);
            Console.WriteLine("Version: " + version);
        }
    }
}
