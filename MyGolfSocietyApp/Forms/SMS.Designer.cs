namespace MyGolfSocietyApp.Forms
{
    partial class SMS
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
            this.ToLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.MessageBodyTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(31, 22);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 0;
            this.ToLabel.Text = "To";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(96, 22);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(140, 20);
            this.NumberTextBox.TabIndex = 1;
            this.NumberTextBox.Text = "0877727879";
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Location = new System.Drawing.Point(31, 56);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(50, 13);
            this.Messagelabel.TabIndex = 0;
            this.Messagelabel.Text = "Message";
            // 
            // MessageBodyTextBox
            // 
            this.MessageBodyTextBox.Location = new System.Drawing.Point(96, 56);
            this.MessageBodyTextBox.Multiline = true;
            this.MessageBodyTextBox.Name = "MessageBodyTextBox";
            this.MessageBodyTextBox.Size = new System.Drawing.Size(140, 57);
            this.MessageBodyTextBox.TabIndex = 2;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(96, 142);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(130, 23);
            this.SendMessageButton.TabIndex = 3;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 244);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.MessageBodyTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.ToLabel);
            this.Name = "SMS";
            this.Text = "SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.TextBox MessageBodyTextBox;
        private System.Windows.Forms.Button SendMessageButton;
    }
}