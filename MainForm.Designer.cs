namespace LivestreamerGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.myButtonLoadStream = new System.Windows.Forms.Button();
            this.myBoxStreamName = new System.Windows.Forms.TextBox();
            this.myUserLabel = new System.Windows.Forms.Label();
            this.myGroupQuality = new System.Windows.Forms.GroupBox();
            this.myRadioSource = new System.Windows.Forms.RadioButton();
            this.myRadioHigh = new System.Windows.Forms.RadioButton();
            this.myRadioMedium = new System.Windows.Forms.RadioButton();
            this.myRadioLow = new System.Windows.Forms.RadioButton();
            this.myRadioMobile = new System.Windows.Forms.RadioButton();
            this.myRadioAudio = new System.Windows.Forms.RadioButton();
            this.myListFavorites = new System.Windows.Forms.ListBox();
            this.myLabelFavorites = new System.Windows.Forms.Label();
            this.myButtonAddFav = new System.Windows.Forms.Button();
            this.myButtonRemoveFav = new System.Windows.Forms.Button();
            this.myGroupQuality.SuspendLayout();
            this.SuspendLayout();
            // 
            // myButtonLoadStream
            // 
            this.myButtonLoadStream.Location = new System.Drawing.Point(189, 23);
            this.myButtonLoadStream.Name = "myButtonLoadStream";
            this.myButtonLoadStream.Size = new System.Drawing.Size(87, 23);
            this.myButtonLoadStream.TabIndex = 1;
            this.myButtonLoadStream.Text = "Open Stream";
            this.myButtonLoadStream.UseVisualStyleBackColor = true;
            this.myButtonLoadStream.Click += new System.EventHandler(this.myButtonLoadStream_Click);
            // 
            // myBoxStreamName
            // 
            this.myBoxStreamName.Location = new System.Drawing.Point(12, 25);
            this.myBoxStreamName.Name = "myBoxStreamName";
            this.myBoxStreamName.Size = new System.Drawing.Size(166, 20);
            this.myBoxStreamName.TabIndex = 0;
            // 
            // myUserLabel
            // 
            this.myUserLabel.AutoSize = true;
            this.myUserLabel.Location = new System.Drawing.Point(9, 9);
            this.myUserLabel.Name = "myUserLabel";
            this.myUserLabel.Size = new System.Drawing.Size(93, 13);
            this.myUserLabel.TabIndex = 2;
            this.myUserLabel.Text = "Twitch Username:";
            // 
            // myGroupQuality
            // 
            this.myGroupQuality.Controls.Add(this.myRadioSource);
            this.myGroupQuality.Controls.Add(this.myRadioHigh);
            this.myGroupQuality.Controls.Add(this.myRadioMedium);
            this.myGroupQuality.Controls.Add(this.myRadioLow);
            this.myGroupQuality.Controls.Add(this.myRadioMobile);
            this.myGroupQuality.Controls.Add(this.myRadioAudio);
            this.myGroupQuality.Location = new System.Drawing.Point(189, 69);
            this.myGroupQuality.Name = "myGroupQuality";
            this.myGroupQuality.Size = new System.Drawing.Size(87, 161);
            this.myGroupQuality.TabIndex = 3;
            this.myGroupQuality.TabStop = false;
            this.myGroupQuality.Text = "Quality";
            // 
            // myRadioSource
            // 
            this.myRadioSource.AutoSize = true;
            this.myRadioSource.Checked = true;
            this.myRadioSource.Location = new System.Drawing.Point(7, 135);
            this.myRadioSource.Name = "myRadioSource";
            this.myRadioSource.Size = new System.Drawing.Size(59, 17);
            this.myRadioSource.TabIndex = 10;
            this.myRadioSource.TabStop = true;
            this.myRadioSource.Text = "Source";
            this.myRadioSource.UseVisualStyleBackColor = true;
            // 
            // myRadioHigh
            // 
            this.myRadioHigh.AutoSize = true;
            this.myRadioHigh.Location = new System.Drawing.Point(7, 112);
            this.myRadioHigh.Name = "myRadioHigh";
            this.myRadioHigh.Size = new System.Drawing.Size(47, 17);
            this.myRadioHigh.TabIndex = 9;
            this.myRadioHigh.Text = "High";
            this.myRadioHigh.UseVisualStyleBackColor = true;
            // 
            // myRadioMedium
            // 
            this.myRadioMedium.AutoSize = true;
            this.myRadioMedium.Location = new System.Drawing.Point(7, 89);
            this.myRadioMedium.Name = "myRadioMedium";
            this.myRadioMedium.Size = new System.Drawing.Size(62, 17);
            this.myRadioMedium.TabIndex = 8;
            this.myRadioMedium.Text = "Medium";
            this.myRadioMedium.UseVisualStyleBackColor = true;
            // 
            // myRadioLow
            // 
            this.myRadioLow.AutoSize = true;
            this.myRadioLow.Location = new System.Drawing.Point(7, 66);
            this.myRadioLow.Name = "myRadioLow";
            this.myRadioLow.Size = new System.Drawing.Size(45, 17);
            this.myRadioLow.TabIndex = 7;
            this.myRadioLow.Text = "Low";
            this.myRadioLow.UseVisualStyleBackColor = true;
            // 
            // myRadioMobile
            // 
            this.myRadioMobile.AutoSize = true;
            this.myRadioMobile.Location = new System.Drawing.Point(7, 43);
            this.myRadioMobile.Name = "myRadioMobile";
            this.myRadioMobile.Size = new System.Drawing.Size(56, 17);
            this.myRadioMobile.TabIndex = 6;
            this.myRadioMobile.Text = "Mobile";
            this.myRadioMobile.UseVisualStyleBackColor = true;
            // 
            // myRadioAudio
            // 
            this.myRadioAudio.AutoSize = true;
            this.myRadioAudio.Location = new System.Drawing.Point(7, 20);
            this.myRadioAudio.Name = "myRadioAudio";
            this.myRadioAudio.Size = new System.Drawing.Size(76, 17);
            this.myRadioAudio.TabIndex = 5;
            this.myRadioAudio.Text = "Audio Only";
            this.myRadioAudio.UseVisualStyleBackColor = true;
            // 
            // myListFavorites
            // 
            this.myListFavorites.FormattingEnabled = true;
            this.myListFavorites.Location = new System.Drawing.Point(12, 73);
            this.myListFavorites.Name = "myListFavorites";
            this.myListFavorites.Size = new System.Drawing.Size(166, 121);
            this.myListFavorites.TabIndex = 2;
            this.myListFavorites.SelectedIndexChanged += new System.EventHandler(this.myListFavorites_SelectedIndexChanged);
            // 
            // myLabelFavorites
            // 
            this.myLabelFavorites.AutoSize = true;
            this.myLabelFavorites.Location = new System.Drawing.Point(9, 57);
            this.myLabelFavorites.Name = "myLabelFavorites";
            this.myLabelFavorites.Size = new System.Drawing.Size(53, 13);
            this.myLabelFavorites.TabIndex = 5;
            this.myLabelFavorites.Text = "Favorites:";
            // 
            // myButtonAddFav
            // 
            this.myButtonAddFav.Location = new System.Drawing.Point(12, 207);
            this.myButtonAddFav.Name = "myButtonAddFav";
            this.myButtonAddFav.Size = new System.Drawing.Size(75, 23);
            this.myButtonAddFav.TabIndex = 3;
            this.myButtonAddFav.Text = "Add";
            this.myButtonAddFav.UseVisualStyleBackColor = true;
            this.myButtonAddFav.Click += new System.EventHandler(this.myButtonAddFav_Click);
            // 
            // myButtonRemoveFav
            // 
            this.myButtonRemoveFav.Location = new System.Drawing.Point(93, 207);
            this.myButtonRemoveFav.Name = "myButtonRemoveFav";
            this.myButtonRemoveFav.Size = new System.Drawing.Size(85, 23);
            this.myButtonRemoveFav.TabIndex = 4;
            this.myButtonRemoveFav.Text = "Remove";
            this.myButtonRemoveFav.UseVisualStyleBackColor = true;
            this.myButtonRemoveFav.Click += new System.EventHandler(this.myButtonRemoveFav_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 242);
            this.Controls.Add(this.myButtonRemoveFav);
            this.Controls.Add(this.myButtonAddFav);
            this.Controls.Add(this.myLabelFavorites);
            this.Controls.Add(this.myListFavorites);
            this.Controls.Add(this.myGroupQuality);
            this.Controls.Add(this.myUserLabel);
            this.Controls.Add(this.myBoxStreamName);
            this.Controls.Add(this.myButtonLoadStream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Livestreamer GUI";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.myGroupQuality.ResumeLayout(false);
            this.myGroupQuality.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myButtonLoadStream;
        private System.Windows.Forms.TextBox myBoxStreamName;
        private System.Windows.Forms.Label myUserLabel;
        private System.Windows.Forms.GroupBox myGroupQuality;
        private System.Windows.Forms.RadioButton myRadioSource;
        private System.Windows.Forms.RadioButton myRadioHigh;
        private System.Windows.Forms.RadioButton myRadioMedium;
        private System.Windows.Forms.RadioButton myRadioLow;
        private System.Windows.Forms.RadioButton myRadioMobile;
        private System.Windows.Forms.RadioButton myRadioAudio;
        private System.Windows.Forms.ListBox myListFavorites;
        private System.Windows.Forms.Label myLabelFavorites;
        private System.Windows.Forms.Button myButtonAddFav;
        private System.Windows.Forms.Button myButtonRemoveFav;
    }
}

