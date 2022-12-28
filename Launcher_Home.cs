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
            catch (UriFormatException ex)
            {
                // Catch an exception if the line is left blank, or otherwise not formatted correctly
                webBrowser1.Url = null; // Allow the app to keep running by displaying a "Null" page
                // Display an error box to end user
                MessageBox.Show("The webpage failed to load. Ensure launcher is configured properly. Forward this error to the game developer.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
