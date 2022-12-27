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
            webBrowser1.Url = new Uri(website); // Convert into Url
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            Launch.LaunchGame();
        }
    }
}
