using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmic
{
    public partial class Launcher_Home : Form
    {
        public Launcher_Home()
        {
            InitializeComponent();
            Config.Read();

            string website = Config.website;
            try
            {
                webBrowser1.Url = new Uri(website); // Convert into Url
            }
            catch (UriFormatException)
            {
                webBrowser1.Url = null; // Allow the app to keep running by displaying a "Null" page
                Console.WriteLine("[ERROR] The webpage failed to load. Ensure the launcher is configured properly.");
            }
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            Launch.LaunchGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Launch the Launcher_About form
            Launcher_About launcher_About = new Launcher_About();
            launcher_About.ShowDialog(); // Prevents the user from using the main window until closed
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
