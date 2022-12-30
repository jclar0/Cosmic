using System.Windows.Forms;

namespace Cosmic
{
    public partial class Launcher_About : Form
    {
        public Launcher_About()
        {
            InitializeComponent();

            // Update this text to match config
            label1.Text = Config.gameName + " Launcher";
            label3.Text = "Game Version " + Config.gameVersion;

            // Check if the developer wants the Cosmic link to show, if not, hide it :(
            if (Config.showCosmicLink == false)
            {
                linkLabel1.Enabled = false;
                linkLabel1.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When we click the link, open the Github page :)
            System.Diagnostics.Process.Start("https://github.com/jclar0/Cosmic");
        }
    }
}
