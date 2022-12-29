﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

            string binPath = Path.Combine(currentDirectory, "bin");

            // Create a new string combining the current directory, the "bin" folder and the Game executable
            String appPath = Path.Combine(binPath, gamePath);

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
