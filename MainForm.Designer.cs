﻿namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
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
            this.historyLabel = new System.Windows.Forms.Label();
            this.saveAsFileBtn = new System.Windows.Forms.Button();
            this.radioButtonXml = new System.Windows.Forms.RadioButton();
            this.radioButtonTxt = new System.Windows.Forms.RadioButton();
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
            this.loginButton.Location = new System.Drawing.Point(171, 83);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 80);
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
            this.findPlacesButton.Location = new System.Drawing.Point(66, 346);
            this.findPlacesButton.Name = "findPlacesButton";
            this.findPlacesButton.Size = new System.Drawing.Size(214, 55);
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
            this.nameLabel.Location = new System.Drawing.Point(6, 225);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 29);
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
            this.getPostsButton.Location = new System.Drawing.Point(322, 305);
            this.getPostsButton.Name = "getPostsButton";
            this.getPostsButton.Size = new System.Drawing.Size(140, 52);
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
            this.postsListBox.ItemHeight = 22;
            this.postsListBox.Location = new System.Drawing.Point(322, 363);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(421, 114);
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
            this.userInfoLabel.Location = new System.Drawing.Point(8, 258);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(135, 20);
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
            this.sendGreetingButton.Location = new System.Drawing.Point(66, 423);
            this.sendGreetingButton.Name = "sendGreetingButton";
            this.sendGreetingButton.Size = new System.Drawing.Size(214, 57);
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
            this.getLikedPagesButton.Location = new System.Drawing.Point(856, 415);
            this.getLikedPagesButton.Name = "getLikedPagesButton";
            this.getLikedPagesButton.Size = new System.Drawing.Size(140, 54);
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
            this.likedPagesListBox.ItemHeight = 22;
            this.likedPagesListBox.Location = new System.Drawing.Point(856, 482);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(462, 224);
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
            this.friendsListBox.ItemHeight = 22;
            this.friendsListBox.Location = new System.Drawing.Point(327, 112);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(276, 136);
            this.friendsListBox.TabIndex = 12;
            // 
            // friendsButton
            // 
            this.friendsButton.BackColor = System.Drawing.Color.White;
            this.friendsButton.Enabled = false;
            this.friendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.friendsButton.Location = new System.Drawing.Point(327, 49);
            this.friendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(140, 54);
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
            this.amountFriendsLabel.Location = new System.Drawing.Point(476, 66);
            this.amountFriendsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountFriendsLabel.Name = "amountFriendsLabel";
            this.amountFriendsLabel.Size = new System.Drawing.Size(19, 20);
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
            this.photosButton.Location = new System.Drawing.Point(856, 49);
            this.photosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.photosButton.Name = "photosButton";
            this.photosButton.Size = new System.Drawing.Size(140, 52);
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
            this.photosFlowLayoutPanel.Location = new System.Drawing.Point(856, 112);
            this.photosFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.photosFlowLayoutPanel.Name = "photosFlowLayoutPanel";
            this.photosFlowLayoutPanel.Size = new System.Drawing.Size(479, 271);
            this.photosFlowLayoutPanel.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 423);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // placesPictureBox
            // 
            this.placesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.placesPictureBox.Image = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.favourite_places;
            this.placesPictureBox.Location = new System.Drawing.Point(2, 345);
            this.placesPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placesPictureBox.Name = "placesPictureBox";
            this.placesPictureBox.Size = new System.Drawing.Size(57, 55);
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
            this.facebookLogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(1924, 39);
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
            this.logOutButton.Location = new System.Drawing.Point(2, 668);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(88, 83);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Visible = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // friendPictureBox
            // 
            this.friendPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.friendPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.friendPictureBox.Location = new System.Drawing.Point(646, 112);
            this.friendPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendPictureBox.Name = "friendPictureBox";
            this.friendPictureBox.Size = new System.Drawing.Size(148, 133);
            this.friendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendPictureBox.TabIndex = 24;
            this.friendPictureBox.TabStop = false;
            this.friendPictureBox.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.birthdayLabel.Location = new System.Drawing.Point(624, 271);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(82, 21);
            this.birthdayLabel.TabIndex = 24;
            this.birthdayLabel.Text = "Birthday:";
            this.birthdayLabel.Visible = false;
            // 
            // friendBirthdayLabel
            // 
            this.friendBirthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.friendBirthdayLabel.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.friendBirthdayLabel.Location = new System.Drawing.Point(704, 271);
            this.friendBirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendBirthdayLabel.Name = "friendBirthdayLabel";
            this.friendBirthdayLabel.Size = new System.Drawing.Size(134, 37);
            this.friendBirthdayLabel.TabIndex = 25;
            this.friendBirthdayLabel.Text = "friend birthday";
            this.friendBirthdayLabel.Visible = false;
            // 
            // catchPageLabel
            // 
            this.catchPageLabel.AutoSize = true;
            this.catchPageLabel.Location = new System.Drawing.Point(868, 492);
            this.catchPageLabel.Name = "catchPageLabel";
            this.catchPageLabel.Size = new System.Drawing.Size(35, 20);
            this.catchPageLabel.TabIndex = 26;
            this.catchPageLabel.Text = "N/A";
            this.catchPageLabel.Visible = false;
            // 
            // photosFlowLayoutPanel2
            // 
            this.photosFlowLayoutPanel2.AutoScroll = true;
            this.photosFlowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.photosFlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photosFlowLayoutPanel2.Location = new System.Drawing.Point(856, 111);
            this.photosFlowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.photosFlowLayoutPanel2.Name = "photosFlowLayoutPanel2";
            this.photosFlowLayoutPanel2.Size = new System.Drawing.Size(479, 273);
            this.photosFlowLayoutPanel2.TabIndex = 23;
            this.photosFlowLayoutPanel2.Visible = false;
            // 
            // friendsListBox2
            // 
            this.friendsListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsListBox2.FormattingEnabled = true;
            this.friendsListBox2.ItemHeight = 22;
            this.friendsListBox2.Location = new System.Drawing.Point(327, 112);
            this.friendsListBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsListBox2.Name = "friendsListBox2";
            this.friendsListBox2.Size = new System.Drawing.Size(276, 136);
            this.friendsListBox2.TabIndex = 27;
            this.friendsListBox2.Visible = false;
            // 
            // postsListBox2
            // 
            this.postsListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsListBox2.FormattingEnabled = true;
            this.postsListBox2.ItemHeight = 22;
            this.postsListBox2.Location = new System.Drawing.Point(322, 363);
            this.postsListBox2.Name = "postsListBox2";
            this.postsListBox2.Size = new System.Drawing.Size(421, 114);
            this.postsListBox2.TabIndex = 28;
            this.postsListBox2.Visible = false;
            // 
            // likedPagesListBox2
            // 
            this.likedPagesListBox2.DisplayMember = "Albums";
            this.likedPagesListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likedPagesListBox2.FormattingEnabled = true;
            this.likedPagesListBox2.ItemHeight = 22;
            this.likedPagesListBox2.Location = new System.Drawing.Point(856, 482);
            this.likedPagesListBox2.Name = "likedPagesListBox2";
            this.likedPagesListBox2.Size = new System.Drawing.Size(462, 224);
            this.likedPagesListBox2.TabIndex = 29;
            this.likedPagesListBox2.ValueMember = "Albums";
            this.likedPagesListBox2.Visible = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.profilePictureBox.Image = global::A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.unknow;
            this.profilePictureBox.Location = new System.Drawing.Point(10, 66);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(154, 155);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 23;
            this.profilePictureBox.TabStop = false;
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 22;
            this.HistoryListBox.Location = new System.Drawing.Point(322, 520);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(421, 180);
            this.HistoryListBox.TabIndex = 30;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.historyLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.historyLabel.Location = new System.Drawing.Point(322, 492);
            this.historyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(98, 25);
            this.historyLabel.TabIndex = 31;
            this.historyLabel.Text = "History : ";
            // 
            // saveAsFileBtn
            // 
            this.saveAsFileBtn.Enabled = false;
            this.saveAsFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.saveAsFileBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.saveAsFileBtn.Location = new System.Drawing.Point(640, 706);
            this.saveAsFileBtn.Name = "saveAsFileBtn";
            this.saveAsFileBtn.Size = new System.Drawing.Size(103, 37);
            this.saveAsFileBtn.TabIndex = 34;
            this.saveAsFileBtn.Text = "Save As";
            this.saveAsFileBtn.UseVisualStyleBackColor = false;
            this.saveAsFileBtn.Click += new System.EventHandler(this.saveAsFileBtn_Click);
            // 
            // radioButtonXml
            // 
            this.radioButtonXml.AutoSize = true;
            this.radioButtonXml.Checked = true;
            this.radioButtonXml.Location = new System.Drawing.Point(322, 706);
            this.radioButtonXml.Name = "radioButtonXml";
            this.radioButtonXml.Size = new System.Drawing.Size(61, 24);
            this.radioButtonXml.TabIndex = 35;
            this.radioButtonXml.TabStop = true;
            this.radioButtonXml.Text = "Xml";
            this.radioButtonXml.UseVisualStyleBackColor = true;
            // 
            // radioButtonTxt
            // 
            this.radioButtonTxt.AutoSize = true;
            this.radioButtonTxt.Location = new System.Drawing.Point(398, 706);
            this.radioButtonTxt.Name = "radioButtonTxt";
            this.radioButtonTxt.Size = new System.Drawing.Size(55, 24);
            this.radioButtonTxt.TabIndex = 36;
            this.radioButtonTxt.Text = "Txt";
            this.radioButtonTxt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.radioButtonTxt);
            this.Controls.Add(this.radioButtonXml);
            this.Controls.Add(this.saveAsFileBtn);
            this.Controls.Add(this.historyLabel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Button saveAsFileBtn;
        private System.Windows.Forms.RadioButton radioButtonXml;
        private System.Windows.Forms.RadioButton radioButtonTxt;
    }
}