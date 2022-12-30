using System.Windows.Forms;

namespace Cosmic
{
    public partial class Launcher_About : Form
    {
        public Launcher_About()
        {
            InitializeComponent();

            // Change the label1 text to match the game being played
            label1.Text = Config.gameName + " Launcher";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When we click the link, open the Github page :)
            System.Diagnostics.Process.Start("https://github.com/jclar0/Cosmic");
        }
    }
}
