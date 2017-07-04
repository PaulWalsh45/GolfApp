namespace MyGolfSocietyApp.Forms
{
    partial class CompetitionPlayers
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CompetitionPlayersDGV = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pLAYERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANDICAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDJUSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Class1DGV = new System.Windows.Forms.DataGridView();
            this.Class2DGV = new System.Windows.Forms.DataGridView();
            this.Class3DGV = new System.Windows.Forms.DataGridView();
            this.Class1GroupBox = new System.Windows.Forms.GroupBox();
            this.Class2GroupBox = new System.Windows.Forms.GroupBox();
            this.Class3GroupBox = new System.Windows.Forms.GroupBox();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPlayersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class1DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class2DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class3DGV)).BeginInit();
            this.Class1GroupBox.SuspendLayout();
            this.Class2GroupBox.SuspendLayout();
            this.Class3GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Window;
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.label3);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 487);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(655, 32);
            this.BottomPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bottom";
            // 
            // CompetitionPlayersDGV
            // 
            this.CompetitionPlayersDGV.AllowUserToAddRows = false;
            this.CompetitionPlayersDGV.AutoGenerateColumns = false;
            this.CompetitionPlayersDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CompetitionPlayersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompetitionPlayersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.pLAYERIDDataGridViewTextBoxColumn,
            this.fULLNAMEDataGridViewTextBoxColumn,
            this.hANDICAPDataGridViewTextBoxColumn,
            this.aDJUSTDataGridViewTextBoxColumn});
            this.CompetitionPlayersDGV.DataSource = this.PlayersBindingSource;
            this.CompetitionPlayersDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompetitionPlayersDGV.Location = new System.Drawing.Point(0, 0);
            this.CompetitionPlayersDGV.Name = "CompetitionPlayersDGV";
            this.CompetitionPlayersDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompetitionPlayersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompetitionPlayersDGV.Size = new System.Drawing.Size(655, 152);
            this.CompetitionPlayersDGV.TabIndex = 1;
            this.CompetitionPlayersDGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CompetitionPlayersDGV_CellMouseUp);
            this.CompetitionPlayersDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompetitionPlayersDGV_CellValueChanged);
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // pLAYERIDDataGridViewTextBoxColumn
            // 
            this.pLAYERIDDataGridViewTextBoxColumn.DataPropertyName = "PLAYER_ID";
            this.pLAYERIDDataGridViewTextBoxColumn.HeaderText = "PLAYER_ID";
            this.pLAYERIDDataGridViewTextBoxColumn.Name = "pLAYERIDDataGridViewTextBoxColumn";
            this.pLAYERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fULLNAMEDataGridViewTextBoxColumn
            // 
            this.fULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME";
            this.fULLNAMEDataGridViewTextBoxColumn.HeaderText = "FULLNAME";
            this.fULLNAMEDataGridViewTextBoxColumn.Name = "fULLNAMEDataGridViewTextBoxColumn";
            this.fULLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hANDICAPDataGridViewTextBoxColumn
            // 
            this.hANDICAPDataGridViewTextBoxColumn.DataPropertyName = "HANDICAP";
            this.hANDICAPDataGridViewTextBoxColumn.HeaderText = "HANDICAP";
            this.hANDICAPDataGridViewTextBoxColumn.Name = "hANDICAPDataGridViewTextBoxColumn";
            this.hANDICAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDJUSTDataGridViewTextBoxColumn
            // 
            this.aDJUSTDataGridViewTextBoxColumn.DataPropertyName = "ADJUST";
            this.aDJUSTDataGridViewTextBoxColumn.HeaderText = "ADJUST";
            this.aDJUSTDataGridViewTextBoxColumn.Name = "aDJUSTDataGridViewTextBoxColumn";
            this.aDJUSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PlayersBindingSource
            // 
            this.PlayersBindingSource.DataSource = typeof(DAL.Player);
            // 
            // Class1DGV
            // 
            this.Class1DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Class1DGV.Location = new System.Drawing.Point(21, 19);
            this.Class1DGV.Name = "Class1DGV";
            this.Class1DGV.Size = new System.Drawing.Size(177, 254);
            this.Class1DGV.TabIndex = 1;
            // 
            // Class2DGV
            // 
            this.Class2DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Class2DGV.Location = new System.Drawing.Point(21, 19);
            this.Class2DGV.Name = "Class2DGV";
            this.Class2DGV.Size = new System.Drawing.Size(177, 254);
            this.Class2DGV.TabIndex = 1;
            this.Class2DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Class2DGV_CellContentClick);
            // 
            // Class3DGV
            // 
            this.Class3DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Class3DGV.Location = new System.Drawing.Point(21, 19);
            this.Class3DGV.Name = "Class3DGV";
            this.Class3DGV.Size = new System.Drawing.Size(177, 254);
            this.Class3DGV.TabIndex = 1;
            this.Class3DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Class2DGV_CellContentClick);
            // 
            // Class1GroupBox
            // 
            this.Class1GroupBox.Controls.Add(this.Class1DGV);
            this.Class1GroupBox.Location = new System.Drawing.Point(12, 176);
            this.Class1GroupBox.Name = "Class1GroupBox";
            this.Class1GroupBox.Size = new System.Drawing.Size(211, 289);
            this.Class1GroupBox.TabIndex = 2;
            this.Class1GroupBox.TabStop = false;
            this.Class1GroupBox.Text = "Class 1";
            // 
            // Class2GroupBox
            // 
            this.Class2GroupBox.Controls.Add(this.Class2DGV);
            this.Class2GroupBox.Location = new System.Drawing.Point(229, 176);
            this.Class2GroupBox.Name = "Class2GroupBox";
            this.Class2GroupBox.Size = new System.Drawing.Size(204, 289);
            this.Class2GroupBox.TabIndex = 2;
            this.Class2GroupBox.TabStop = false;
            this.Class2GroupBox.Text = "Class 2";
            // 
            // Class3GroupBox
            // 
            this.Class3GroupBox.Controls.Add(this.Class3DGV);
            this.Class3GroupBox.Location = new System.Drawing.Point(439, 176);
            this.Class3GroupBox.Name = "Class3GroupBox";
            this.Class3GroupBox.Size = new System.Drawing.Size(204, 289);
            this.Class3GroupBox.TabIndex = 2;
            this.Class3GroupBox.TabStop = false;
            this.Class3GroupBox.Text = "Class 3";
            // 
            // CompetitionPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 519);
            this.Controls.Add(this.Class3GroupBox);
            this.Controls.Add(this.Class2GroupBox);
            this.Controls.Add(this.Class1GroupBox);
            this.Controls.Add(this.CompetitionPlayersDGV);
            this.Controls.Add(this.BottomPanel);
            this.Name = "CompetitionPlayers";
            this.Text = " Select Players";
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPlayersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class1DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class2DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class3DGV)).EndInit();
            this.Class1GroupBox.ResumeLayout(false);
            this.Class2GroupBox.ResumeLayout(false);
            this.Class3GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView CompetitionPlayersDGV;
        private System.Windows.Forms.BindingSource PlayersBindingSource;
        private System.Windows.Forms.Panel ClassTwoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAYERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANDICAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDJUSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Class2DGV;
        private System.Windows.Forms.DataGridView Class1DGV;
        private System.Windows.Forms.DataGridView Class3DGV;
        private System.Windows.Forms.GroupBox Class1GroupBox;
        private System.Windows.Forms.GroupBox Class2GroupBox;
        private System.Windows.Forms.GroupBox Class3GroupBox;
    }
}