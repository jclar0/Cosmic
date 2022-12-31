using Cosmic.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Cosmic
{
    public class Launch
    {
        public static void Game()
        {
            string appPath = Path.Combine(Directory.GetCurrentDirectory(), "bin", $"{Config.gameName}.exe");

            // Check if the Game.exe file exists
            if (File.Exists(appPath))
            {
                Process.Start(appPath, Launcher_Options.gameArgs);
                Environment.Exit(0); // Exit with Code 0 (success)
            }
            else
            {
                // Show the end user an error
                MessageBox.Show("Unable to launch game. The file does not exist.", "Failed to Launch", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // For development use
                Console.WriteLine("I'm sorry, but Cosmic was unable to launch your game.");
                Console.WriteLine("Make sure you have structured your folder properly.");
                Console.WriteLine("The file I tried to access: " + appPath);
            }
        }
    }
}
