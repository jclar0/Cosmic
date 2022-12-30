using System.IO;

namespace Cosmic
{
    class Config
    {
        // Declare string
        public static string gameName;
        public static string gameVersion;
        public static string gameWebsite;

        public static void Read()
        {
            // Define the path of the configuration text file
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "config.txt");

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the file into a string array
                string[] lines = File.ReadAllLines(filePath);

                // Set the values according to options in the file
                gameName = lines[0];
                gameVersion = lines[1];
                gameWebsite = lines[2];
            }
            else
            {
                // Create the file and fill it with some default variables
                gameName = "My Game";
                gameVersion = "1.0.0";
                gameWebsite = "https://www.example.com";

                Write();
            }
        }

        public static void Write()
        {
            // Define the path of the configuration text file
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "config.txt");

            // Now write to the file, looks messy but it should work
            File.WriteAllLines(filePath, new string[] { gameName, gameVersion, gameWebsite });
        }
    }
}
