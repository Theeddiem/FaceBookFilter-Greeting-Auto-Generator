namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    partial class GreetingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreetingsForm));
            this.greetingsListBox = new System.Windows.Forms.ListBox();
            this.greetingPictureBox = new System.Windows.Forms.PictureBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.addMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.selectAFriendlabel = new System.Windows.Forms.Label();
            this.greetingTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.greetingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingsListBox
            // 
            this.greetingsListBox.BackColor = System.Drawing.Color.LightCoral;
            this.greetingsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greetingsListBox.ForeColor = System.Drawing.Color.White;
            this.greetingsListBox.FormattingEnabled = true;
            this.greetingsListBox.ItemHeight = 24;
            this.greetingsListBox.Location = new System.Drawing.Point(282, 69);
            this.greetingsListBox.Name = "greetingsListBox";
            this.greetingsListBox.Size = new System.Drawing.Size(276, 172);
            this.greetingsListBox.TabIndex = 0;
            this.greetingsListBox.SelectedIndexChanged += new System.EventHandler(this.greetingsListBox_SelectedIndexChanged);
            // 
            // greetingPictureBox
            // 
            this.greetingPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greetingPictureBox.Image = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.Greeting_Card_Envelope;
            this.greetingPictureBox.Location = new System.Drawing.Point(600, 62);
            this.greetingPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greetingPictureBox.Name = "greetingPictureBox";
            this.greetingPictureBox.Size = new System.Drawing.Size(422, 267);
            this.greetingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greetingPictureBox.TabIndex = 1;
            this.greetingPictureBox.TabStop = false;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.LightBlue;
            this.sendEmailButton.Enabled = false;
            this.sendEmailButton.Font = new System.Drawing.Font("Miriam Fixed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendEmailButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sendEmailButton.Location = new System.Drawing.Point(752, 363);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(126, 49);
            this.sendEmailButton.TabIndex = 3;
            this.sendEmailButton.Text = "Send to Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // friendsListBox
            // 
            this.friendsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friendsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 22;
            this.friendsListBox.Location = new System.Drawing.Point(27, 69);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.friendsListBox.Size = new System.Drawing.Size(214, 176);
            this.friendsListBox.TabIndex = 4;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // addMsgCheckBox
            // 
            this.addMsgCheckBox.AutoSize = true;
            this.addMsgCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.addMsgCheckBox.Font = new System.Drawing.Font("Miriam Fixed", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addMsgCheckBox.Location = new System.Drawing.Point(12, 315);
            this.addMsgCheckBox.Name = "addMsgCheckBox";
            this.addMsgCheckBox.Size = new System.Drawing.Size(204, 21);
            this.addMsgCheckBox.TabIndex = 6;
            this.addMsgCheckBox.Text = "Add your own text";
            this.addMsgCheckBox.UseVisualStyleBackColor = false;
            this.addMsgCheckBox.CheckedChanged += new System.EventHandler(this.addMsgCheckBox_CheckedChanged);
            // 
            // msgTextBox
            // 
            this.msgTextBox.Enabled = false;
            this.msgTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTextBox.Location = new System.Drawing.Point(12, 345);
            this.msgTextBox.Multiline = true;
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgTextBox.Size = new System.Drawing.Size(310, 66);
            this.msgTextBox.TabIndex = 7;
            // 
            // selectAFriendlabel
            // 
            this.selectAFriendlabel.AutoSize = true;
            this.selectAFriendlabel.BackColor = System.Drawing.Color.Transparent;
            this.selectAFriendlabel.Font = new System.Drawing.Font("Miriam Fixed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.selectAFriendlabel.Location = new System.Drawing.Point(24, 37);
            this.selectAFriendlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectAFriendlabel.Name = "selectAFriendlabel";
            this.selectAFriendlabel.Size = new System.Drawing.Size(148, 17);
            this.selectAFriendlabel.TabIndex = 2;
            this.selectAFriendlabel.Text = "Select Friends";
            // 
            // greetingTypeLabel
            // 
            this.greetingTypeLabel.AutoSize = true;
            this.greetingTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingTypeLabel.Font = new System.Drawing.Font("Miriam Fixed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greetingTypeLabel.Location = new System.Drawing.Point(279, 37);
            this.greetingTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingTypeLabel.Name = "greetingTypeLabel";
            this.greetingTypeLabel.Size = new System.Drawing.Size(158, 17);
            this.greetingTypeLabel.TabIndex = 2;
            this.greetingTypeLabel.Text = "Select Greeting";
            // 
            // GreetingsForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.greeting_Backround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 448);
            this.Controls.Add(this.msgTextBox);
            this.Controls.Add(this.addMsgCheckBox);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.selectAFriendlabel);
            this.Controls.Add(this.greetingTypeLabel);
            this.Controls.Add(this.greetingPictureBox);
            this.Controls.Add(this.greetingsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1056, 478);
            this.Name = "GreetingsForm";
            this.Text = "Greetings";
            ((System.ComponentModel.ISupportInitialize)(this.greetingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox greetingsListBox;
        private System.Windows.Forms.PictureBox greetingPictureBox;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.CheckBox addMsgCheckBox;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.Label selectAFriendlabel;
        private System.Windows.Forms.Label greetingTypeLabel;
    }
}