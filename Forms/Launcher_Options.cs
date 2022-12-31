using System;
using System.Windows.Forms;

namespace Cosmic.Forms
{
    public partial class Launcher_Options : Form
    {
        // The string containing the launch arguments
        public static string gameArgs = "";

        public Launcher_Options()
        {
            InitializeComponent();

            gameArgs = Properties.Settings.Default.gameArgs;
            textBox1.Text = gameArgs;
        }

        private void Launcher_Options_Load(object sender, EventArgs e)
        {

        }

        private void confirmOpt_Click(object sender, EventArgs e)
        {
            // Save the contents of the text box to the gameArgs string
            gameArgs = textBox1.Text;

            Properties.Settings.Default.gameArgs = gameArgs;
            Properties.Settings.Default.Save();

            this.Close(); // close form

            Console.WriteLine("Okay, I've saved the following arguments: " + gameArgs);
        }
    }
}
