using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Cosmic
{
    public class Launch
    {
        public static void LaunchGame()
        {
            // Find the directory that the Launcher is currently in
            string currentDirectory = Directory.GetCurrentDirectory();

            //Get around "Game Name\.exe" by combining the name and .exe
            string gamePath = Config.gameName + ".exe";

            string binPath = Path.Combine(currentDirectory, "bin");

            // Create a new string combining the current directory, the "bin" folder and the Game executable
            string appPath = Path.Combine(binPath, gamePath);

            // Check if the Game.exe file exists
            // Otherwise, print an error
            if (File.Exists(appPath))
            {
                Process.Start(appPath);

                Console.WriteLine("[INFO] Successfully launched " + Config.gameName + " ... ... Exiting app in 7 seconds.");
                Thread.Sleep(7000);
                Environment.Exit(0); // Exit with Code 0 (success)
            }
            else
            {
                // If the "bin" folder doesn't exist, we create it
                if (!Directory.Exists(binPath))
                {
                    Directory.CreateDirectory(binPath);
                }


                Console.WriteLine("[ERROR] Game.exe not found. Path: " + appPath);
            }
        }
    }
}
