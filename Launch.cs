using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic
{
    public class Launch
    {
        public static void LaunchGame()
        {

            // Find the directory that the Launcher is currently in
            String currentDirectory = Directory.GetCurrentDirectory();

            //Get around "Game Name\.exe" by combining the name and .exe
            String gamePath = Config.gameName + ".exe";

            // Create a new string combining the current directory, the "bin" folder and the Game executable
            String appPath = Path.Combine(currentDirectory, "bin", gamePath);

            // Check if the Game.exe file exists
            // Otherwise, print an error
            if (File.Exists(appPath))
            {
                Process.Start(appPath);
            }
            else
            {
                // TODO: Add a Label to the Launcher_Home window that is invisible unless appPath does not exist
                Console.WriteLine("[ERROR] Game.exe not found. Path: " + appPath);
            }
        }
    }
}
