using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivestreamerGUI
{
    public partial class MainForm : Form
    {
        string streamName;
        public MainForm()
        {
            InitializeComponent();
        }

        private void myButtonLoadStream_Click(object sender, EventArgs e)
        {
            streamName = myBoxStreamName.Text;
            string quality = "best";

            //Radios for Quality
            if (myRadioAudio.Checked){
                quality = "audio";
            }
            if (myRadioMobile.Checked){
                quality = "mobile";
            }
            if (myRadioLow.Checked){
                quality = "low";
            }
            if (myRadioMedium.Checked){
                quality = "medium";
            }
            if (myRadioHigh.Checked){
                quality = "high";
            }
            if (myRadioSource.Checked){
                quality = "source";
            }

            string liveCommand = "livestreamer twitch.tv/" + streamName + " " + quality;

            //Sets up a new cmd process for livestreamer and executes it
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + liveCommand;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void myButtonAddFav_Click(object sender, EventArgs e)
        {
            streamName = myBoxStreamName.Text;
            myListFavorites.Items.Add(streamName);

            //Writes to file
            try
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("favorites.txt");
                foreach (var item in myListFavorites.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
            }
            catch { MessageBox.Show("Could not read favorites.txt"); }
        }

        private void myButtonRemoveFav_Click(object sender, EventArgs e)
        {
            myListFavorites.Items.Remove(myListFavorites.SelectedItem);

            //Writes to file
            try
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("favorites.txt");
                foreach (var item in myListFavorites.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
            }
            catch { MessageBox.Show("Could not read favorites.txt"); }
        }

        private void myListFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets text in textbox to selected item
            try { myBoxStreamName.Text = myListFavorites.SelectedItem.ToString(); }
            catch { myBoxStreamName.Text = ""; }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            //Loads favorites.txt created from previous sessions
            try
            {
                if (File.Exists("favorites.txt"))
                {
                    foreach (var line in System.IO.File.ReadAllLines("favorites.txt"))
                    { myListFavorites.Items.Add(line); }
                }
                else
                {
                    MessageBox.Show("No favorites.txt found, file will be created");
                }
            }
            catch{ MessageBox.Show("Could not read favorites.txt"); }
        }
    }
}
