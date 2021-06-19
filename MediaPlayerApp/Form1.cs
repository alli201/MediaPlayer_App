using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Reflection;

namespace MediaPlayerApp
{
    public partial class MediaPlayerApp : Form
    {
        
        public MediaPlayerApp()
        {
            InitializeComponent();
        }
        int maxFlag = 1;   //for maxmize the app

        //for storing the name and the path of the files:
        List<string> filesname = new List<string>();
        List<string> paths = new List<string>();
        private void btnSelectSongs_Click(object sender, EventArgs e)
        {

                OpenFileDialog o = new OpenFileDialog();  //creating a dialog for selecting files
                o.Multiselect = true;             // so that we can select more than one file in the same time

            o.Filter="Media|*.mp4;*.mp3";
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)   //after we select the files
                {
                    filesname.Clear();   //to prevent dublicating files names
                    filesname.AddRange(o.SafeFileNames);

                    paths.AddRange(o.FileNames);

                    for (int i = 0; i < filesname.Count; i++)
                    {
                        listBoxSongs.Items.Add(filesname[i]);       //toadd the files to the listBox
                    }
                }
            }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
         try
            {
            axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];   //to play the media that we select from the listBox
            }

         catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (maxFlag == 1) { 
            WindowState = FormWindowState.Maximized;       //in the bigening if we click it the app will maximize
                maxFlag = 0;
                           }
           else if (maxFlag == 0)
            {
                WindowState = FormWindowState.Normal;      // after it is maximized if we click the app size will back to normal
                maxFlag = 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;        // for minimizzing the app
        }


        private void MediaPlayerApp_Load(object sender, EventArgs e)
        {
            PicPlayPause.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\alikh\Desktop\C# Projects\MediaPlayerApp\pictures\play.png");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();      //for closing the app
        }


        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.Gray;
        }

    

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.CornflowerBlue;
        }

        private void pictureBoxMax_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMax.BackColor = Color.Gray;
        }

        private void pictureBoxMax_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMax.BackColor = Color.CornflowerBlue;
        }

        private void pictureBoxMin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMin.BackColor = Color.Gray;
        }

        private void pictureBoxMin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMin.BackColor = Color.CornflowerBlue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.Items.Count > 0) {    //if the listbox is not empty
                int n = listBoxSongs.Items.Count;  // holding the current number of items in the listbox
            try
            {
                paths.Remove(paths[listBoxSongs.SelectedIndex]);       //to remove the path of the selected item
                listBoxSongs.Items.RemoveAt(listBoxSongs.SelectedIndex);   //to remove the selected item from the listbox                
                //filesname.Remove(filesname[listBoxSongs.SelectedIndex]);   //to remove the file name of the selected item

                }
                catch
            {}
                finally
                {
                    if (listBoxSongs.Items.Count < n)                //if an item have been removed
                        MessageBox.Show("Deleted Successfully!");
                }
                                             }
        }


        private void PicPlayPause_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                PicPlayPause.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\alikh\Desktop\C# Projects\MediaPlayerApp\pictures\play.png");
                PicPlayPause.BackgroundImageLayout = ImageLayout.Stretch;
            }
             else
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                PicPlayPause.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\alikh\Desktop\C# Projects\MediaPlayerApp\pictures\pause.png");

            }
        
        }

        private void picStop_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                picStop.Size = new Size(25, 25);

                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
              if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PicPlayPause.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\alikh\Desktop\C# Projects\MediaPlayerApp\pictures\pause.png");
            }
              if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                PicPlayPause.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\alikh\Desktop\C# Projects\MediaPlayerApp\pictures\play.png");

              if(axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsStopped)
                picStop.Size = new Size(30, 30);
        }

        private void picPrevious_Click(object sender, EventArgs e)
        {
            if(listBoxSongs.SelectedIndex!=listBoxSongs.TopIndex)   // if the pointer is not on the first (top) item.
            try
            {
                axWindowsMediaPlayer1.URL = paths[--listBoxSongs.SelectedIndex];
            }
            catch { }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = paths[++listBoxSongs.SelectedIndex];
            }
            catch { }
        }
    }
}
