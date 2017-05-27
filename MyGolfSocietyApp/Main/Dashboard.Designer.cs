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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.listPlayersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCourseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCoursesMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOutingMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listOutingsMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTournamentMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listTournamentsMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listPlayersMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // menuNewPlayer
            // 
            this.menuNewPlayer.Name = "menuNewPlayer";
            this.menuNewPlayer.Size = new System.Drawing.Size(152, 22);
            this.menuNewPlayer.Text = "New";
            //this.menuNewPlayer.Click += new System.EventHandler(this.menuNewPlayer_Click);
            // 
            // listPlayersMenuItem
            // 
            this.listPlayersMenuItem.Name = "listPlayersMenuItem";
            this.listPlayersMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listPlayersMenuItem.Text = "List";
            this.listPlayersMenuItem.Click += new System.EventHandler(this.listPlayersMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCourseMenuItem,
            this.listCoursesMenuItem1});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // newCourseMenuItem
            // 
            this.newCourseMenuItem.Name = "newCourseMenuItem";
            this.newCourseMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newCourseMenuItem.Text = "New";
            //this.newCourseMenuItem.Click += new System.EventHandler(this.newCourseMenuItem_Click);
            // 
            // listCoursesMenuItem1
            // 
            this.listCoursesMenuItem1.Name = "listCoursesMenuItem1";
            this.listCoursesMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.listCoursesMenuItem1.Text = "List";
            // 
            // outingToolStripMenuItem
            // 
            this.outingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOutingMenuItem1,
            this.listOutingsMenuItem2});
            this.outingToolStripMenuItem.Name = "outingToolStripMenuItem";
            this.outingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.outingToolStripMenuItem.Text = "Outing";
            // 
            // newOutingMenuItem1
            // 
            this.newOutingMenuItem1.Name = "newOutingMenuItem1";
            this.newOutingMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.newOutingMenuItem1.Text = "New";
            this.newOutingMenuItem1.Click += new System.EventHandler(this.newOutingMenuItem1_Click);
            // 
            // listOutingsMenuItem2
            // 
            this.listOutingsMenuItem2.Name = "listOutingsMenuItem2";
            this.listOutingsMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.listOutingsMenuItem2.Text = "List";
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTournamentMenuItem2,
            this.listTournamentsMenuItem3});
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // newTournamentMenuItem2
            // 
            this.newTournamentMenuItem2.Name = "newTournamentMenuItem2";
            this.newTournamentMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.newTournamentMenuItem2.Text = "New";
            // 
            // listTournamentsMenuItem3
            // 
            this.listTournamentsMenuItem3.Name = "listTournamentsMenuItem3";
            this.listTournamentsMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.listTournamentsMenuItem3.Text = "List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyGolfSocietyApp.Properties.Resources.transp_logo;
            this.pictureBox1.Location = new System.Drawing.Point(246, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 426);
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
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem listPlayersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCourseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCoursesMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newOutingMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listOutingsMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newTournamentMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listTournamentsMenuItem3;
    }
}