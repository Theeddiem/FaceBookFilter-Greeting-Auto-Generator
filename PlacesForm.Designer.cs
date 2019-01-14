namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    partial class PlacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacesForm));
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.getPopularPlacesButton = new System.Windows.Forms.Button();
            this.popularPlacesListBox = new System.Windows.Forms.ListBox();
            this.maps = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.friendsWithCommonPlacesButton = new System.Windows.Forms.Button();
            this.friendsWithCommonPlacesListBox = new System.Windows.Forms.ListBox();
            this.placeGoogleSearchLabel = new System.Windows.Forms.Label();
            this.friendPictureBox = new System.Windows.Forms.PictureBox();
            this.commonPlacesListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonGoogle = new System.Windows.Forms.RadioButton();
            this.radioButtonBing = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDuckDuckGo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.friendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // friendsListBox
            // 
            this.friendsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsListBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 22;
            this.friendsListBox.Location = new System.Drawing.Point(4, 168);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(259, 92);
            this.friendsListBox.TabIndex = 5;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged_1);
            // 
            // getPopularPlacesButton
            // 
            this.getPopularPlacesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.getPopularPlacesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getPopularPlacesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.getPopularPlacesButton.Location = new System.Drawing.Point(4, 418);
            this.getPopularPlacesButton.Name = "getPopularPlacesButton";
            this.getPopularPlacesButton.Size = new System.Drawing.Size(386, 43);
            this.getPopularPlacesButton.TabIndex = 6;
            this.getPopularPlacesButton.Text = "Popular places among friends";
            this.getPopularPlacesButton.UseVisualStyleBackColor = false;
            this.getPopularPlacesButton.Click += new System.EventHandler(this.getPopularPlacesButton_Click);
            // 
            // popularPlacesListBox
            // 
            this.popularPlacesListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.popularPlacesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.popularPlacesListBox.FormattingEnabled = true;
            this.popularPlacesListBox.ItemHeight = 22;
            this.popularPlacesListBox.Location = new System.Drawing.Point(4, 466);
            this.popularPlacesListBox.Name = "popularPlacesListBox";
            this.popularPlacesListBox.Size = new System.Drawing.Size(436, 114);
            this.popularPlacesListBox.TabIndex = 7;
            this.popularPlacesListBox.SelectedIndexChanged += new System.EventHandler(this.popularPlacesListBox_SelectedIndexChanged);
            // 
            // maps
            // 
            this.maps.Location = new System.Drawing.Point(446, 12);
            this.maps.MinimumSize = new System.Drawing.Size(20, 20);
            this.maps.Name = "maps";
            this.maps.Size = new System.Drawing.Size(1076, 702);
            this.maps.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selcet a friend to see your common places";
            // 
            // friendsLabel
            // 
            this.friendsLabel.AutoSize = true;
            this.friendsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.friendsLabel.Location = new System.Drawing.Point(-2, 120);
            this.friendsLabel.Name = "friendsLabel";
            this.friendsLabel.Size = new System.Drawing.Size(84, 25);
            this.friendsLabel.TabIndex = 11;
            this.friendsLabel.Text = "Friends";
            // 
            // friendsWithCommonPlacesButton
            // 
            this.friendsWithCommonPlacesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.friendsWithCommonPlacesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsWithCommonPlacesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.friendsWithCommonPlacesButton.Location = new System.Drawing.Point(4, 606);
            this.friendsWithCommonPlacesButton.Name = "friendsWithCommonPlacesButton";
            this.friendsWithCommonPlacesButton.Size = new System.Drawing.Size(412, 48);
            this.friendsWithCommonPlacesButton.TabIndex = 12;
            this.friendsWithCommonPlacesButton.Text = "Friends you have the most common places with";
            this.friendsWithCommonPlacesButton.UseVisualStyleBackColor = false;
            this.friendsWithCommonPlacesButton.Click += new System.EventHandler(this.getPotentialFriendsButton_Click);
            // 
            // friendsWithCommonPlacesListBox
            // 
            this.friendsWithCommonPlacesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsWithCommonPlacesListBox.FormattingEnabled = true;
            this.friendsWithCommonPlacesListBox.ItemHeight = 22;
            this.friendsWithCommonPlacesListBox.Location = new System.Drawing.Point(4, 658);
            this.friendsWithCommonPlacesListBox.Name = "friendsWithCommonPlacesListBox";
            this.friendsWithCommonPlacesListBox.Size = new System.Drawing.Size(436, 70);
            this.friendsWithCommonPlacesListBox.TabIndex = 13;
            // 
            // placeGoogleSearchLabel
            // 
            this.placeGoogleSearchLabel.AutoSize = true;
            this.placeGoogleSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeGoogleSearchLabel.Location = new System.Drawing.Point(0, 294);
            this.placeGoogleSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeGoogleSearchLabel.Name = "placeGoogleSearchLabel";
            this.placeGoogleSearchLabel.Size = new System.Drawing.Size(328, 20);
            this.placeGoogleSearchLabel.TabIndex = 15;
            this.placeGoogleSearchLabel.Text = "Select a place to see it\'s Google search";
            // 
            // friendPictureBox
            // 
            this.friendPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.friendPictureBox.Location = new System.Drawing.Point(280, 168);
            this.friendPictureBox.Name = "friendPictureBox";
            this.friendPictureBox.Size = new System.Drawing.Size(152, 122);
            this.friendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendPictureBox.TabIndex = 8;
            this.friendPictureBox.TabStop = false;
            // 
            // commonPlacesListBox
            // 
            this.commonPlacesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.commonPlacesListBox.FormattingEnabled = true;
            this.commonPlacesListBox.ItemHeight = 22;
            this.commonPlacesListBox.Location = new System.Drawing.Point(4, 317);
            this.commonPlacesListBox.Name = "commonPlacesListBox";
            this.commonPlacesListBox.Size = new System.Drawing.Size(436, 70);
            this.commonPlacesListBox.TabIndex = 16;
            this.commonPlacesListBox.SelectedIndexChanged += new System.EventHandler(this.commonPlacesListBox_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.placesForm;
            this.pictureBox1.Location = new System.Drawing.Point(123, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonGoogle
            // 
            this.radioButtonGoogle.AutoSize = true;
            this.radioButtonGoogle.Checked = true;
            this.radioButtonGoogle.Location = new System.Drawing.Point(6, 25);
            this.radioButtonGoogle.Name = "radioButtonGoogle";
            this.radioButtonGoogle.Size = new System.Drawing.Size(86, 24);
            this.radioButtonGoogle.TabIndex = 18;
            this.radioButtonGoogle.TabStop = true;
            this.radioButtonGoogle.Text = "Google";
            this.radioButtonGoogle.UseVisualStyleBackColor = true;
            this.radioButtonGoogle.CheckedChanged += new System.EventHandler(this.radioButtonSearch_CheckedChanged);
            // 
            // radioButtonBing
            // 
            this.radioButtonBing.AutoSize = true;
            this.radioButtonBing.Location = new System.Drawing.Point(6, 55);
            this.radioButtonBing.Name = "radioButtonBing";
            this.radioButtonBing.Size = new System.Drawing.Size(66, 24);
            this.radioButtonBing.TabIndex = 19;
            this.radioButtonBing.Text = "Bing";
            this.radioButtonBing.UseVisualStyleBackColor = true;
            this.radioButtonBing.CheckedChanged += new System.EventHandler(this.radioButtonSearch_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDuckDuckGo);
            this.groupBox1.Controls.Add(this.radioButtonGoogle);
            this.groupBox1.Controls.Add(this.radioButtonBing);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 121);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search engine";
            // 
            // radioButtonDuckDuckGo
            // 
            this.radioButtonDuckDuckGo.AutoSize = true;
            this.radioButtonDuckDuckGo.Location = new System.Drawing.Point(7, 88);
            this.radioButtonDuckDuckGo.Name = "radioButtonDuckDuckGo";
            this.radioButtonDuckDuckGo.Size = new System.Drawing.Size(130, 24);
            this.radioButtonDuckDuckGo.TabIndex = 21;
            this.radioButtonDuckDuckGo.TabStop = true;
            this.radioButtonDuckDuckGo.Text = "DuckDuckGo";
            this.radioButtonDuckDuckGo.UseVisualStyleBackColor = true;
            this.radioButtonDuckDuckGo.CheckedChanged += new System.EventHandler(this.radioButtonSearch_CheckedChanged);
            // 
            // PlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.commonPlacesListBox);
            this.Controls.Add(this.placeGoogleSearchLabel);
            this.Controls.Add(this.friendsWithCommonPlacesListBox);
            this.Controls.Add(this.friendsWithCommonPlacesButton);
            this.Controls.Add(this.friendsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maps);
            this.Controls.Add(this.friendPictureBox);
            this.Controls.Add(this.popularPlacesListBox);
            this.Controls.Add(this.getPopularPlacesButton);
            this.Controls.Add(this.friendsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Places";
            ((System.ComponentModel.ISupportInitialize)(this.friendPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button getPopularPlacesButton;
        private System.Windows.Forms.ListBox popularPlacesListBox;
        private System.Windows.Forms.PictureBox friendPictureBox;
        private System.Windows.Forms.WebBrowser maps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label friendsLabel;
        private System.Windows.Forms.Button friendsWithCommonPlacesButton;
        private System.Windows.Forms.ListBox friendsWithCommonPlacesListBox;
        private System.Windows.Forms.Label placeGoogleSearchLabel;
        private System.Windows.Forms.ListBox commonPlacesListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonGoogle;
        private System.Windows.Forms.RadioButton radioButtonBing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDuckDuckGo;
    }
}