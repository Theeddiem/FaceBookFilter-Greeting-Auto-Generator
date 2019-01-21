namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.findPlacesButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.getPostsButton = new System.Windows.Forms.Button();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.sendGreetingButton = new System.Windows.Forms.Button();
            this.getLikedPagesButton = new System.Windows.Forms.Button();
            this.likedPagesListBox = new System.Windows.Forms.ListBox();
            this.likedPagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.friendsButton = new System.Windows.Forms.Button();
            this.amountFriendsLabel = new System.Windows.Forms.Label();
            this.photosButton = new System.Windows.Forms.Button();
            this.photosFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.placesPictureBox = new System.Windows.Forms.PictureBox();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.friendPictureBox = new System.Windows.Forms.PictureBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.friendBirthdayLabel = new System.Windows.Forms.Label();
            this.catchPageLabel = new System.Windows.Forms.Label();
            this.photosFlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.friendsListBox2 = new System.Windows.Forms.ListBox();
            this.postsListBox2 = new System.Windows.Forms.ListBox();
            this.likedPagesListBox2 = new System.Windows.Forms.ListBox();
            this.profilePictureBox = new A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.OvalPictureBox();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AllowDrop = true;
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(114, 54);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 52);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login With FaceBook";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // findPlacesButton
            // 
            this.findPlacesButton.BackColor = System.Drawing.Color.White;
            this.findPlacesButton.Enabled = false;
            this.findPlacesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.findPlacesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.findPlacesButton.Location = new System.Drawing.Point(44, 225);
            this.findPlacesButton.Margin = new System.Windows.Forms.Padding(2);
            this.findPlacesButton.Name = "findPlacesButton";
            this.findPlacesButton.Size = new System.Drawing.Size(143, 36);
            this.findPlacesButton.TabIndex = 3;
            this.findPlacesButton.Text = "Find Places";
            this.findPlacesButton.UseVisualStyleBackColor = false;
            this.findPlacesButton.Click += new System.EventHandler(this.getPlacesFeatureButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nameLabel.Location = new System.Drawing.Point(4, 146);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.Visible = false;
            // 
            // getPostsButton
            // 
            this.getPostsButton.BackColor = System.Drawing.Color.White;
            this.getPostsButton.Enabled = false;
            this.getPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getPostsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.getPostsButton.Location = new System.Drawing.Point(215, 218);
            this.getPostsButton.Margin = new System.Windows.Forms.Padding(2);
            this.getPostsButton.Name = "getPostsButton";
            this.getPostsButton.Size = new System.Drawing.Size(93, 34);
            this.getPostsButton.TabIndex = 5;
            this.getPostsButton.Text = "Posts";
            this.getPostsButton.UseVisualStyleBackColor = false;
            this.getPostsButton.Click += new System.EventHandler(this.getPostsButton_Click);
            // 
            // postsListBox
            // 
            this.postsListBox.DataSource = this.postsBindingSource;
            this.postsListBox.DisplayMember = "Message";
            this.postsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 15;
            this.postsListBox.Location = new System.Drawing.Point(215, 264);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(282, 79);
            this.postsListBox.TabIndex = 6;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.userBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userInfoLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.userInfoLabel.Location = new System.Drawing.Point(5, 168);
            this.userInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(92, 13);
            this.userInfoLabel.TabIndex = 7;
            this.userInfoLabel.Text = "user Info Label";
            this.userInfoLabel.Visible = false;
            // 
            // sendGreetingButton
            // 
            this.sendGreetingButton.BackColor = System.Drawing.Color.White;
            this.sendGreetingButton.Enabled = false;
            this.sendGreetingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendGreetingButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.sendGreetingButton.Location = new System.Drawing.Point(44, 275);
            this.sendGreetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendGreetingButton.Name = "sendGreetingButton";
            this.sendGreetingButton.Size = new System.Drawing.Size(143, 37);
            this.sendGreetingButton.TabIndex = 9;
            this.sendGreetingButton.Text = "Send Greeting";
            this.sendGreetingButton.UseVisualStyleBackColor = false;
            this.sendGreetingButton.Click += new System.EventHandler(this.greetingFeatureButton_Click);
            // 
            // getLikedPagesButton
            // 
            this.getLikedPagesButton.BackColor = System.Drawing.Color.White;
            this.getLikedPagesButton.Enabled = false;
            this.getLikedPagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getLikedPagesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.getLikedPagesButton.Location = new System.Drawing.Point(560, 245);
            this.getLikedPagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.getLikedPagesButton.Name = "getLikedPagesButton";
            this.getLikedPagesButton.Size = new System.Drawing.Size(93, 35);
            this.getLikedPagesButton.TabIndex = 10;
            this.getLikedPagesButton.Text = "Pages";
            this.getLikedPagesButton.UseVisualStyleBackColor = false;
            this.getLikedPagesButton.Click += new System.EventHandler(this.getLikedPages_Click);
            // 
            // likedPagesListBox
            // 
            this.likedPagesListBox.DataSource = this.likedPagesBindingSource;
            this.likedPagesListBox.DisplayMember = "Name";
            this.likedPagesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likedPagesListBox.FormattingEnabled = true;
            this.likedPagesListBox.ItemHeight = 15;
            this.likedPagesListBox.Location = new System.Drawing.Point(560, 292);
            this.likedPagesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(309, 49);
            this.likedPagesListBox.TabIndex = 11;
            this.likedPagesListBox.ValueMember = "Albums";
            // 
            // likedPagesBindingSource
            // 
            this.likedPagesBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // friendsListBox
            // 
            this.friendsListBox.DataSource = this.userBindingSource;
            this.friendsListBox.DisplayMember = "Name";
            this.friendsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 15;
            this.friendsListBox.Location = new System.Drawing.Point(218, 73);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(185, 64);
            this.friendsListBox.TabIndex = 12;
            // 
            // friendsButton
            // 
            this.friendsButton.BackColor = System.Drawing.Color.White;
            this.friendsButton.Enabled = false;
            this.friendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.friendsButton.Location = new System.Drawing.Point(218, 32);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(93, 35);
            this.friendsButton.TabIndex = 13;
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = false;
            this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // amountFriendsLabel
            // 
            this.amountFriendsLabel.AutoSize = true;
            this.amountFriendsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amountFriendsLabel.ForeColor = System.Drawing.Color.Gray;
            this.amountFriendsLabel.Location = new System.Drawing.Point(317, 43);
            this.amountFriendsLabel.Name = "amountFriendsLabel";
            this.amountFriendsLabel.Size = new System.Drawing.Size(14, 13);
            this.amountFriendsLabel.TabIndex = 17;
            this.amountFriendsLabel.Text = "0";
            this.amountFriendsLabel.Visible = false;
            // 
            // photosButton
            // 
            this.photosButton.BackColor = System.Drawing.Color.White;
            this.photosButton.Enabled = false;
            this.photosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.photosButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.photosButton.Location = new System.Drawing.Point(560, 32);
            this.photosButton.Name = "photosButton";
            this.photosButton.Size = new System.Drawing.Size(93, 34);
            this.photosButton.TabIndex = 21;
            this.photosButton.Text = "Photos";
            this.photosButton.UseVisualStyleBackColor = false;
            this.photosButton.Click += new System.EventHandler(this.photosButton_Click);
            // 
            // photosFlowLayoutPanel
            // 
            this.photosFlowLayoutPanel.AutoScroll = true;
            this.photosFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.photosFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photosFlowLayoutPanel.Location = new System.Drawing.Point(560, 72);
            this.photosFlowLayoutPanel.Name = "photosFlowLayoutPanel";
            this.photosFlowLayoutPanel.Size = new System.Drawing.Size(320, 160);
            this.photosFlowLayoutPanel.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // placesPictureBox
            // 
            this.placesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.placesPictureBox.Image = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.favourite_places;
            this.placesPictureBox.Location = new System.Drawing.Point(1, 224);
            this.placesPictureBox.Name = "placesPictureBox";
            this.placesPictureBox.Size = new System.Drawing.Size(38, 36);
            this.placesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.placesPictureBox.TabIndex = 15;
            this.placesPictureBox.TabStop = false;
            // 
            // facebookLogoPictureBox
            // 
            this.facebookLogoPictureBox.BackColor = System.Drawing.Color.SandyBrown;
            this.facebookLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.facebookLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.facebookLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("facebookLogoPictureBox.Image")));
            this.facebookLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(913, 26);
            this.facebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogoPictureBox.TabIndex = 14;
            this.facebookLogoPictureBox.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.logOutButton.BackgroundImage = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.user_exit_logout_sign_out_icon;
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOutButton.Location = new System.Drawing.Point(1, 334);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(59, 54);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Visible = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // friendPictureBox
            // 
            this.friendPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.friendPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.friendPictureBox.Location = new System.Drawing.Point(415, 73);
            this.friendPictureBox.Name = "friendPictureBox";
            this.friendPictureBox.Size = new System.Drawing.Size(100, 88);
            this.friendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendPictureBox.TabIndex = 24;
            this.friendPictureBox.TabStop = false;
            this.friendPictureBox.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.birthdayLabel.Location = new System.Drawing.Point(416, 176);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(55, 15);
            this.birthdayLabel.TabIndex = 24;
            this.birthdayLabel.Text = "Birthday:";
            this.birthdayLabel.Visible = false;
            // 
            // friendBirthdayLabel
            // 
            this.friendBirthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.friendBirthdayLabel.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.friendBirthdayLabel.Location = new System.Drawing.Point(469, 176);
            this.friendBirthdayLabel.Name = "friendBirthdayLabel";
            this.friendBirthdayLabel.Size = new System.Drawing.Size(89, 24);
            this.friendBirthdayLabel.TabIndex = 25;
            this.friendBirthdayLabel.Text = "friend birthday";
            this.friendBirthdayLabel.Visible = false;
            // 
            // catchPageLabel
            // 
            this.catchPageLabel.AutoSize = true;
            this.catchPageLabel.Location = new System.Drawing.Point(568, 299);
            this.catchPageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.catchPageLabel.Name = "catchPageLabel";
            this.catchPageLabel.Size = new System.Drawing.Size(27, 13);
            this.catchPageLabel.TabIndex = 26;
            this.catchPageLabel.Text = "N/A";
            this.catchPageLabel.Visible = false;
            // 
            // photosFlowLayoutPanel2
            // 
            this.photosFlowLayoutPanel2.AutoScroll = true;
            this.photosFlowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.photosFlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photosFlowLayoutPanel2.Location = new System.Drawing.Point(560, 72);
            this.photosFlowLayoutPanel2.Name = "photosFlowLayoutPanel2";
            this.photosFlowLayoutPanel2.Size = new System.Drawing.Size(320, 160);
            this.photosFlowLayoutPanel2.TabIndex = 23;
            this.photosFlowLayoutPanel2.Visible = false;
            // 
            // friendsListBox2
            // 
            this.friendsListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsListBox2.FormattingEnabled = true;
            this.friendsListBox2.ItemHeight = 15;
            this.friendsListBox2.Location = new System.Drawing.Point(218, 73);
            this.friendsListBox2.Name = "friendsListBox2";
            this.friendsListBox2.Size = new System.Drawing.Size(185, 64);
            this.friendsListBox2.TabIndex = 27;
            this.friendsListBox2.Visible = false;
            // 
            // postsListBox2
            // 
            this.postsListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsListBox2.FormattingEnabled = true;
            this.postsListBox2.ItemHeight = 15;
            this.postsListBox2.Location = new System.Drawing.Point(215, 263);
            this.postsListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.postsListBox2.Name = "postsListBox2";
            this.postsListBox2.Size = new System.Drawing.Size(282, 79);
            this.postsListBox2.TabIndex = 28;
            this.postsListBox2.Visible = false;
            // 
            // likedPagesListBox2
            // 
            this.likedPagesListBox2.DisplayMember = "Albums";
            this.likedPagesListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likedPagesListBox2.FormattingEnabled = true;
            this.likedPagesListBox2.ItemHeight = 15;
            this.likedPagesListBox2.Location = new System.Drawing.Point(560, 292);
            this.likedPagesListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.likedPagesListBox2.Name = "likedPagesListBox2";
            this.likedPagesListBox2.Size = new System.Drawing.Size(309, 49);
            this.likedPagesListBox2.TabIndex = 29;
            this.likedPagesListBox2.ValueMember = "Albums";
            this.likedPagesListBox2.Visible = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.profilePictureBox.Image = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.unknow;
            this.profilePictureBox.Location = new System.Drawing.Point(7, 43);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(103, 101);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 23;
            this.profilePictureBox.TabStop = false;
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 15;
            this.HistoryListBox.Location = new System.Drawing.Point(356, 364);
            this.HistoryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(269, 124);
            this.HistoryListBox.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 499);
            this.Controls.Add(this.HistoryListBox);
            this.Controls.Add(this.likedPagesListBox2);
            this.Controls.Add(this.postsListBox2);
            this.Controls.Add(this.friendsListBox2);
            this.Controls.Add(this.photosFlowLayoutPanel2);
            this.Controls.Add(this.catchPageLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.friendPictureBox);
            this.Controls.Add(this.friendBirthdayLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.likedPagesListBox);
            this.Controls.Add(this.photosFlowLayoutPanel);
            this.Controls.Add(this.photosButton);
            this.Controls.Add(this.amountFriendsLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.placesPictureBox);
            this.Controls.Add(this.facebookLogoPictureBox);
            this.Controls.Add(this.friendsButton);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.getLikedPagesButton);
            this.Controls.Add(this.sendGreetingButton);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.getPostsButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.findPlacesButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(909, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button findPlacesButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button getPostsButton;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Button sendGreetingButton;
        private System.Windows.Forms.Button getLikedPagesButton;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
        private System.Windows.Forms.PictureBox placesPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label amountFriendsLabel;
        private System.Windows.Forms.Button photosButton;
        private System.Windows.Forms.FlowLayoutPanel photosFlowLayoutPanel;
        private OvalPictureBox profilePictureBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.PictureBox friendPictureBox;
        private System.Windows.Forms.Label friendBirthdayLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.BindingSource likedPagesBindingSource;
        private System.Windows.Forms.Label catchPageLabel;
        private System.Windows.Forms.FlowLayoutPanel photosFlowLayoutPanel2;
        private System.Windows.Forms.ListBox friendsListBox2;
        private System.Windows.Forms.ListBox postsListBox2;
        private System.Windows.Forms.ListBox likedPagesListBox2;
        private System.Windows.Forms.ListBox HistoryListBox;
    }
}