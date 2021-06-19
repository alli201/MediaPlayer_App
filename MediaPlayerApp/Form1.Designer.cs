namespace MediaPlayerApp
{
    partial class MediaPlayerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectMedia = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.PicPlayPause = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.pictureBoxMin);
            this.panel1.Controls.Add(this.pictureBoxMax);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Name = "panel1";
            this.panel1.DoubleClick += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMin
            // 
            resources.ApplyResources(this.pictureBoxMin, "pictureBoxMin");
            this.pictureBoxMin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBoxMin.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            this.pictureBoxMin.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            // 
            // pictureBoxMax
            // 
            resources.ApplyResources(this.pictureBoxMax, "pictureBoxMax");
            this.pictureBoxMax.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBoxMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBoxMax.MouseEnter += new System.EventHandler(this.pictureBoxMax_MouseEnter);
            this.pictureBoxMax.MouseLeave += new System.EventHandler(this.pictureBoxMax_MouseLeave);
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(this.pictureBoxClose, "pictureBoxClose");
            this.pictureBoxClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            // 
            // lblLogo
            // 
            resources.ApplyResources(this.lblLogo, "lblLogo");
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblLogo.Name = "lblLogo";
            // 
            // listBoxSongs
            // 
            resources.ApplyResources(this.listBoxSongs, "listBoxSongs");
            this.listBoxSongs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSongs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxSongs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectMedia
            // 
            resources.ApplyResources(this.btnSelectMedia, "btnSelectMedia");
            this.btnSelectMedia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSelectMedia.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectMedia.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectMedia.FlatAppearance.BorderSize = 7;
            this.btnSelectMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSelectMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSelectMedia.Name = "btnSelectMedia";
            this.btnSelectMedia.UseVisualStyleBackColor = false;
            this.btnSelectMedia.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.BorderSize = 7;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picNext);
            this.panel2.Controls.Add(this.picPrevious);
            this.panel2.Controls.Add(this.picStop);
            this.panel2.Controls.Add(this.PicPlayPause);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Name = "panel2";
            // 
            // picNext
            // 
            resources.ApplyResources(this.picNext, "picNext");
            this.picNext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Name = "picNext";
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picPrevious
            // 
            resources.ApplyResources(this.picPrevious, "picPrevious");
            this.picPrevious.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.TabStop = false;
            this.picPrevious.Click += new System.EventHandler(this.picPrevious_Click);
            // 
            // picStop
            // 
            resources.ApplyResources(this.picStop, "picStop");
            this.picStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStop.Name = "picStop";
            this.picStop.TabStop = false;
            this.picStop.Click += new System.EventHandler(this.picStop_Click);
            // 
            // PicPlayPause
            // 
            resources.ApplyResources(this.PicPlayPause, "PicPlayPause");
            this.PicPlayPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicPlayPause.Name = "PicPlayPause";
            this.PicPlayPause.TabStop = false;
            this.PicPlayPause.Click += new System.EventHandler(this.PicPlayPause_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AllowDrop = true;
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // MediaPlayerApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnSelectMedia);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MediaPlayerApp";
            this.Load += new System.EventHandler(this.MediaPlayerApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectMedia;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PicPlayPause;
        private System.Windows.Forms.PictureBox picStop;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPrevious;
    }
}

