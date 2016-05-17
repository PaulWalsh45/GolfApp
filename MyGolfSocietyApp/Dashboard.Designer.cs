namespace MyGolfSocietyApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.outingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddOuting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditOuting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewOuting = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddTournament = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewTournament = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.outingToolStripMenuItem,
            this.tournamentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewPlayer,
            this.menuViewPlayer,
            this.menuListPlayers,
            this.listToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // menuNewPlayer
            // 
            this.menuNewPlayer.Name = "menuNewPlayer";
            this.menuNewPlayer.Size = new System.Drawing.Size(99, 22);
            this.menuNewPlayer.Text = "New";
            this.menuNewPlayer.Click += new System.EventHandler(this.menuNewPlayer_Click);
            // 
            // menuViewPlayer
            // 
            this.menuViewPlayer.Name = "menuViewPlayer";
            this.menuViewPlayer.Size = new System.Drawing.Size(99, 22);
            this.menuViewPlayer.Text = "View";
            this.menuViewPlayer.Click += new System.EventHandler(this.menuViewPlayer_Click);
            // 
            // menuListPlayers
            // 
            this.menuListPlayers.Name = "menuListPlayers";
            this.menuListPlayers.Size = new System.Drawing.Size(99, 22);
            this.menuListPlayers.Text = "Edit";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.menuEditCourse,
            this.menuViewCourse});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // menuEditCourse
            // 
            this.menuEditCourse.Name = "menuEditCourse";
            this.menuEditCourse.Size = new System.Drawing.Size(99, 22);
            this.menuEditCourse.Text = "Edit";
            // 
            // menuViewCourse
            // 
            this.menuViewCourse.Name = "menuViewCourse";
            this.menuViewCourse.Size = new System.Drawing.Size(99, 22);
            this.menuViewCourse.Text = "View";
            // 
            // outingToolStripMenuItem
            // 
            this.outingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddOuting,
            this.menuEditOuting,
            this.menuViewOuting});
            this.outingToolStripMenuItem.Name = "outingToolStripMenuItem";
            this.outingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.outingToolStripMenuItem.Text = "Outing";
            // 
            // menuAddOuting
            // 
            this.menuAddOuting.Name = "menuAddOuting";
            this.menuAddOuting.Size = new System.Drawing.Size(99, 22);
            this.menuAddOuting.Text = "Add";
            // 
            // menuEditOuting
            // 
            this.menuEditOuting.Name = "menuEditOuting";
            this.menuEditOuting.Size = new System.Drawing.Size(99, 22);
            this.menuEditOuting.Text = "Edit";
            // 
            // menuViewOuting
            // 
            this.menuViewOuting.Name = "menuViewOuting";
            this.menuViewOuting.Size = new System.Drawing.Size(99, 22);
            this.menuViewOuting.Text = "View";
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTournament,
            this.menuViewTournament});
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // menuAddTournament
            // 
            this.menuAddTournament.Name = "menuAddTournament";
            this.menuAddTournament.Size = new System.Drawing.Size(99, 22);
            this.menuAddTournament.Text = "Add";
            // 
            // menuViewTournament
            // 
            this.menuViewTournament.Name = "menuViewTournament";
            this.menuViewTournament.Size = new System.Drawing.Size(99, 22);
            this.menuViewTournament.Text = "View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(848, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewPlayer;
        private System.Windows.Forms.ToolStripMenuItem menuViewPlayer;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditCourse;
        private System.Windows.Forms.ToolStripMenuItem outingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddOuting;
        private System.Windows.Forms.ToolStripMenuItem menuEditOuting;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddTournament;
        private System.Windows.Forms.ToolStripMenuItem menuViewTournament;
        private System.Windows.Forms.ToolStripMenuItem menuViewCourse;
        private System.Windows.Forms.ToolStripMenuItem menuViewOuting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuListPlayers;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    }
}