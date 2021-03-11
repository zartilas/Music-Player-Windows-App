namespace FinalErgasia3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonFavourites = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonMusic = new System.Windows.Forms.Button();
            this.panelMusic = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonPreviousSong = new System.Windows.Forms.Button();
            this.buttonNextSong = new System.Windows.Forms.Button();
            this.pictureAlbum = new System.Windows.Forms.PictureBox();
            this.labelSongDuration = new System.Windows.Forms.Label();
            this.buttonPlay_Pause = new System.Windows.Forms.Button();
            this.panelCurrentSongInfo = new System.Windows.Forms.Panel();
            this.labelCurrentSongInfo = new System.Windows.Forms.Label();
            this.labelCurrentSong = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDeleteSong = new System.Windows.Forms.Button();
            this.buttonAddNewSong = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonShuffleAll = new System.Windows.Forms.Button();
            this.buttonEditInfo = new System.Windows.Forms.Button();
            this.buttonClearFavourites = new System.Windows.Forms.Button();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.songTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelNoFavouritesFound = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbum)).BeginInit();
            this.panelCurrentSongInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelSideMenu.Controls.Add(this.buttonFavourites);
            this.panelSideMenu.Controls.Add(this.buttonMusic);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(208, 447);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonFavourites
            // 
            this.buttonFavourites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFavourites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFavourites.FlatAppearance.BorderSize = 0;
            this.buttonFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavourites.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavourites.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFavourites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFavourites.ImageIndex = 1;
            this.buttonFavourites.ImageList = this.imageList;
            this.buttonFavourites.Location = new System.Drawing.Point(0, 113);
            this.buttonFavourites.Name = "buttonFavourites";
            this.buttonFavourites.Size = new System.Drawing.Size(208, 45);
            this.buttonFavourites.TabIndex = 1;
            this.buttonFavourites.Text = "   Favourites";
            this.buttonFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonFavourites, "Most played songs");
            this.buttonFavourites.UseVisualStyleBackColor = true;
            this.buttonFavourites.Click += new System.EventHandler(this.buttonFavourites_Click);
            this.buttonFavourites.MouseEnter += new System.EventHandler(this.buttonFavourites_MouseEnter);
            this.buttonFavourites.MouseLeave += new System.EventHandler(this.buttonFavourites_MouseLeave);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "settings.png");
            this.imageList.Images.SetKeyName(1, "favourites.png");
            this.imageList.Images.SetKeyName(2, "Shuffle.png");
            this.imageList.Images.SetKeyName(3, "music.png");
            this.imageList.Images.SetKeyName(4, "Refresh.png");
            this.imageList.Images.SetKeyName(5, "Remove.png");
            this.imageList.Images.SetKeyName(6, "Add.png");
            this.imageList.Images.SetKeyName(7, "Bin-512.png");
            this.imageList.Images.SetKeyName(8, "Edit.png");
            // 
            // buttonMusic
            // 
            this.buttonMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMusic.FlatAppearance.BorderSize = 0;
            this.buttonMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMusic.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusic.ImageIndex = 3;
            this.buttonMusic.ImageList = this.imageList;
            this.buttonMusic.Location = new System.Drawing.Point(3, 62);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(205, 45);
            this.buttonMusic.TabIndex = 0;
            this.buttonMusic.Text = "   My Music";
            this.buttonMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonMusic, "Your music");
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            this.buttonMusic.MouseEnter += new System.EventHandler(this.buttonMusic_MouseEnter);
            this.buttonMusic.MouseLeave += new System.EventHandler(this.buttonMusic_MouseLeave);
            // 
            // panelMusic
            // 
            this.panelMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panelMusic.Controls.Add(this.buttonStop);
            this.panelMusic.Controls.Add(this.WindowsMediaPlayer);
            this.panelMusic.Controls.Add(this.buttonRepeat);
            this.panelMusic.Controls.Add(this.buttonShuffle);
            this.panelMusic.Controls.Add(this.buttonPreviousSong);
            this.panelMusic.Controls.Add(this.buttonNextSong);
            this.panelMusic.Controls.Add(this.pictureAlbum);
            this.panelMusic.Controls.Add(this.labelSongDuration);
            this.panelMusic.Controls.Add(this.buttonPlay_Pause);
            this.panelMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMusic.Location = new System.Drawing.Point(0, 447);
            this.panelMusic.Name = "panelMusic";
            this.panelMusic.Size = new System.Drawing.Size(1118, 115);
            this.panelMusic.TabIndex = 1;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStop.BackgroundImage = global::FinalErgasia3.Properties.Resources.Stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(731, 32);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(27, 29);
            this.buttonStop.TabIndex = 14;
            this.toolTip.SetToolTip(this.buttonStop, "Stop playing");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(892, 12);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(205, 82);
            this.WindowsMediaPlayer.TabIndex = 13;
            this.WindowsMediaPlayer.Visible = false;
            this.WindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowsMediaPlayer_PlayStateChange);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRepeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRepeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRepeat.BackgroundImage")));
            this.buttonRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRepeat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRepeat.FlatAppearance.BorderSize = 0;
            this.buttonRepeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeat.Location = new System.Drawing.Point(651, 24);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(43, 45);
            this.buttonRepeat.TabIndex = 10;
            this.toolTip.SetToolTip(this.buttonRepeat, "Repeat the current song");
            this.buttonRepeat.UseVisualStyleBackColor = true;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShuffle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShuffle.BackgroundImage")));
            this.buttonShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShuffle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonShuffle.FlatAppearance.BorderSize = 0;
            this.buttonShuffle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShuffle.Location = new System.Drawing.Point(416, 25);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(43, 45);
            this.buttonShuffle.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonShuffle, "Shuffle songs");
            this.buttonShuffle.UseVisualStyleBackColor = true;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // buttonPreviousSong
            // 
            this.buttonPreviousSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPreviousSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPreviousSong.BackgroundImage = global::FinalErgasia3.Properties.Resources.PreviousSong;
            this.buttonPreviousSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPreviousSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreviousSong.FlatAppearance.BorderSize = 0;
            this.buttonPreviousSong.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousSong.Location = new System.Drawing.Point(476, 25);
            this.buttonPreviousSong.Name = "buttonPreviousSong";
            this.buttonPreviousSong.Size = new System.Drawing.Size(40, 42);
            this.buttonPreviousSong.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonPreviousSong, "Previous song");
            this.buttonPreviousSong.UseVisualStyleBackColor = true;
            this.buttonPreviousSong.Click += new System.EventHandler(this.buttonPreviousSong_Click);
            // 
            // buttonNextSong
            // 
            this.buttonNextSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNextSong.BackgroundImage = global::FinalErgasia3.Properties.Resources.NextSong;
            this.buttonNextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextSong.FlatAppearance.BorderSize = 0;
            this.buttonNextSong.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonNextSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNextSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNextSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextSong.Location = new System.Drawing.Point(596, 25);
            this.buttonNextSong.Name = "buttonNextSong";
            this.buttonNextSong.Size = new System.Drawing.Size(40, 42);
            this.buttonNextSong.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonNextSong, "Next song");
            this.buttonNextSong.UseVisualStyleBackColor = true;
            this.buttonNextSong.Click += new System.EventHandler(this.buttonNextSong_Click);
            // 
            // pictureAlbum
            // 
            this.pictureAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pictureAlbum.BackgroundImage = global::FinalErgasia3.Properties.Resources.MusicLogo;
            this.pictureAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureAlbum.Location = new System.Drawing.Point(0, 0);
            this.pictureAlbum.Name = "pictureAlbum";
            this.pictureAlbum.Size = new System.Drawing.Size(122, 115);
            this.pictureAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAlbum.TabIndex = 5;
            this.pictureAlbum.TabStop = false;
            // 
            // labelSongDuration
            // 
            this.labelSongDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSongDuration.AutoSize = true;
            this.labelSongDuration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSongDuration.Location = new System.Drawing.Point(533, 84);
            this.labelSongDuration.Name = "labelSongDuration";
            this.labelSongDuration.Size = new System.Drawing.Size(46, 23);
            this.labelSongDuration.TabIndex = 4;
            this.labelSongDuration.Text = "00:00";
            // 
            // buttonPlay_Pause
            // 
            this.buttonPlay_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlay_Pause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlay_Pause.BackgroundImage = global::FinalErgasia3.Properties.Resources.Play;
            this.buttonPlay_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay_Pause.FlatAppearance.BorderSize = 0;
            this.buttonPlay_Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay_Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay_Pause.Location = new System.Drawing.Point(522, 12);
            this.buttonPlay_Pause.Name = "buttonPlay_Pause";
            this.buttonPlay_Pause.Size = new System.Drawing.Size(68, 69);
            this.buttonPlay_Pause.TabIndex = 3;
            this.buttonPlay_Pause.UseVisualStyleBackColor = true;
            this.buttonPlay_Pause.Click += new System.EventHandler(this.buttonPlay_Pause_Click);
            // 
            // panelCurrentSongInfo
            // 
            this.panelCurrentSongInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrentSongInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panelCurrentSongInfo.Controls.Add(this.labelCurrentSongInfo);
            this.panelCurrentSongInfo.Controls.Add(this.labelCurrentSong);
            this.panelCurrentSongInfo.Location = new System.Drawing.Point(202, 382);
            this.panelCurrentSongInfo.Name = "panelCurrentSongInfo";
            this.panelCurrentSongInfo.Size = new System.Drawing.Size(916, 65);
            this.panelCurrentSongInfo.TabIndex = 12;
            // 
            // labelCurrentSongInfo
            // 
            this.labelCurrentSongInfo.AutoSize = true;
            this.labelCurrentSongInfo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSongInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCurrentSongInfo.Location = new System.Drawing.Point(24, 35);
            this.labelCurrentSongInfo.Name = "labelCurrentSongInfo";
            this.labelCurrentSongInfo.Size = new System.Drawing.Size(178, 27);
            this.labelCurrentSongInfo.TabIndex = 11;
            this.labelCurrentSongInfo.Text = "labelCurrentSongInfo";
            this.labelCurrentSongInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCurrentSong
            // 
            this.labelCurrentSong.AutoSize = true;
            this.labelCurrentSong.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCurrentSong.Location = new System.Drawing.Point(24, 0);
            this.labelCurrentSong.Name = "labelCurrentSong";
            this.labelCurrentSong.Size = new System.Drawing.Size(186, 34);
            this.labelCurrentSong.TabIndex = 9;
            this.labelCurrentSong.Text = "labelCurrentSong";
            // 
            // buttonDeleteSong
            // 
            this.buttonDeleteSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteSong.FlatAppearance.BorderSize = 0;
            this.buttonDeleteSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSong.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteSong.ImageIndex = 5;
            this.buttonDeleteSong.ImageList = this.imageList;
            this.buttonDeleteSong.Location = new System.Drawing.Point(773, 331);
            this.buttonDeleteSong.Name = "buttonDeleteSong";
            this.buttonDeleteSong.Size = new System.Drawing.Size(182, 45);
            this.buttonDeleteSong.TabIndex = 9;
            this.buttonDeleteSong.Text = " Delete Selected Song";
            this.buttonDeleteSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonDeleteSong, "Remove a song");
            this.buttonDeleteSong.UseVisualStyleBackColor = true;
            this.buttonDeleteSong.Visible = false;
            this.buttonDeleteSong.Click += new System.EventHandler(this.buttonDeleteSong_Click);
            // 
            // buttonAddNewSong
            // 
            this.buttonAddNewSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddNewSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddNewSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewSong.FlatAppearance.BorderSize = 0;
            this.buttonAddNewSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewSong.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewSong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddNewSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewSong.ImageIndex = 6;
            this.buttonAddNewSong.ImageList = this.imageList;
            this.buttonAddNewSong.Location = new System.Drawing.Point(961, 331);
            this.buttonAddNewSong.Name = "buttonAddNewSong";
            this.buttonAddNewSong.Size = new System.Drawing.Size(142, 45);
            this.buttonAddNewSong.TabIndex = 10;
            this.buttonAddNewSong.Text = " Add New Song";
            this.buttonAddNewSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddNewSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonAddNewSong, "Add a new song");
            this.buttonAddNewSong.UseVisualStyleBackColor = true;
            this.buttonAddNewSong.Click += new System.EventHandler(this.buttonAddNewSong_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.ImageIndex = 4;
            this.buttonRefresh.ImageList = this.imageList;
            this.buttonRefresh.Location = new System.Drawing.Point(1017, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(99, 45);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = " Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonRefresh, "Refresh the current songs");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            this.buttonRefresh.MouseEnter += new System.EventHandler(this.buttonRefresh_MouseEnter);
            this.buttonRefresh.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            // 
            // buttonShuffleAll
            // 
            this.buttonShuffleAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShuffleAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShuffleAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShuffleAll.FlatAppearance.BorderSize = 0;
            this.buttonShuffleAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonShuffleAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShuffleAll.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShuffleAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShuffleAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShuffleAll.ImageIndex = 2;
            this.buttonShuffleAll.ImageList = this.imageList;
            this.buttonShuffleAll.Location = new System.Drawing.Point(235, 12);
            this.buttonShuffleAll.Name = "buttonShuffleAll";
            this.buttonShuffleAll.Size = new System.Drawing.Size(135, 45);
            this.buttonShuffleAll.TabIndex = 1;
            this.buttonShuffleAll.Text = " Shuffle All (0)";
            this.buttonShuffleAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShuffleAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonShuffleAll, "Shuffle all the songs of the playlist");
            this.buttonShuffleAll.UseVisualStyleBackColor = true;
            this.buttonShuffleAll.Click += new System.EventHandler(this.buttonShuffleAll_Click);
            this.buttonShuffleAll.MouseEnter += new System.EventHandler(this.buttonShuffleAll_MouseEnter);
            this.buttonShuffleAll.MouseLeave += new System.EventHandler(this.buttonShuffleAll_MouseLeave);
            // 
            // buttonEditInfo
            // 
            this.buttonEditInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditInfo.FlatAppearance.BorderSize = 0;
            this.buttonEditInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditInfo.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEditInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditInfo.ImageIndex = 8;
            this.buttonEditInfo.ImageList = this.imageList;
            this.buttonEditInfo.Location = new System.Drawing.Point(231, 331);
            this.buttonEditInfo.Name = "buttonEditInfo";
            this.buttonEditInfo.Size = new System.Drawing.Size(99, 45);
            this.buttonEditInfo.TabIndex = 5;
            this.buttonEditInfo.Text = " Edit Info";
            this.buttonEditInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonEditInfo, "Edit the info of the song");
            this.buttonEditInfo.UseVisualStyleBackColor = true;
            this.buttonEditInfo.Visible = false;
            this.buttonEditInfo.Click += new System.EventHandler(this.buttonEditInfo_Click);
            // 
            // buttonClearFavourites
            // 
            this.buttonClearFavourites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClearFavourites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClearFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFavourites.FlatAppearance.BorderSize = 0;
            this.buttonClearFavourites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClearFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFavourites.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFavourites.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClearFavourites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearFavourites.ImageIndex = 7;
            this.buttonClearFavourites.ImageList = this.imageList;
            this.buttonClearFavourites.Location = new System.Drawing.Point(367, 12);
            this.buttonClearFavourites.Name = "buttonClearFavourites";
            this.buttonClearFavourites.Size = new System.Drawing.Size(155, 45);
            this.buttonClearFavourites.TabIndex = 12;
            this.buttonClearFavourites.Text = " Clear Favourites";
            this.buttonClearFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonClearFavourites, "Clear your favourites playlist");
            this.buttonClearFavourites.UseVisualStyleBackColor = true;
            this.buttonClearFavourites.Visible = false;
            this.buttonClearFavourites.Click += new System.EventHandler(this.buttonClearFavourites_Click);
            // 
            // listSongs
            // 
            this.listSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.listSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSongs.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSongs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 34;
            this.listSongs.Location = new System.Drawing.Point(237, 61);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(860, 272);
            this.listSongs.TabIndex = 3;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // songTimer
            // 
            this.songTimer.Interval = 1000;
            this.songTimer.Tick += new System.EventHandler(this.songTimer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // labelNoFavouritesFound
            // 
            this.labelNoFavouritesFound.AutoSize = true;
            this.labelNoFavouritesFound.BackColor = System.Drawing.Color.Transparent;
            this.labelNoFavouritesFound.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoFavouritesFound.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNoFavouritesFound.Location = new System.Drawing.Point(311, 86);
            this.labelNoFavouritesFound.Name = "labelNoFavouritesFound";
            this.labelNoFavouritesFound.Size = new System.Drawing.Size(666, 45);
            this.labelNoFavouritesFound.TabIndex = 11;
            this.labelNoFavouritesFound.Text = "You need to play a song to have favourites!";
            this.labelNoFavouritesFound.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1118, 562);
            this.Controls.Add(this.buttonClearFavourites);
            this.Controls.Add(this.buttonAddNewSong);
            this.Controls.Add(this.buttonDeleteSong);
            this.Controls.Add(this.buttonEditInfo);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.buttonShuffleAll);
            this.Controls.Add(this.panelMusic);
            this.Controls.Add(this.labelNoFavouritesFound);
            this.Controls.Add(this.panelCurrentSongInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Super Music Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMusic.ResumeLayout(false);
            this.panelMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbum)).EndInit();
            this.panelCurrentSongInfo.ResumeLayout(false);
            this.panelCurrentSongInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panelMusic;
        private System.Windows.Forms.Button buttonFavourites;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonNextSong;
        private System.Windows.Forms.PictureBox pictureAlbum;
        private System.Windows.Forms.Label labelSongDuration;
        private System.Windows.Forms.Button buttonPlay_Pause;
        private System.Windows.Forms.Button buttonPreviousSong;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Label labelCurrentSong;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Panel panelCurrentSongInfo;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button buttonEditInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer songTimer;
        private System.Windows.Forms.Button buttonDeleteSong;
        private System.Windows.Forms.Button buttonAddNewSong;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.Label labelNoFavouritesFound;
        public System.Windows.Forms.Button buttonShuffleAll;
        private System.Windows.Forms.Button buttonClearFavourites;
        private System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.Label labelCurrentSongInfo;
    }
}

