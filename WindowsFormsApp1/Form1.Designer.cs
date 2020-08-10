namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbMijnLabel = new System.Windows.Forms.Label();
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.cbLeerlingen = new System.Windows.Forms.ComboBox();
            this.lbLeerlingen = new System.Windows.Forms.ListBox();
            this.txtMijnTextBox = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMijnLabel
            // 
            this.lbMijnLabel.AutoSize = true;
            this.lbMijnLabel.Location = new System.Drawing.Point(12, 9);
            this.lbMijnLabel.Name = "lbMijnLabel";
            this.lbMijnLabel.Size = new System.Drawing.Size(72, 17);
            this.lbMijnLabel.TabIndex = 0;
            this.lbMijnLabel.Text = "Mijn Label";
            this.lbMijnLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(9, 30);
            this.btnMijnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(75, 23);
            this.btnMijnButton.TabIndex = 1;
            this.btnMijnButton.Text = "Klik mij!";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            this.btnMijnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLeerlingen
            // 
            this.cbLeerlingen.FormattingEnabled = true;
            this.cbLeerlingen.Location = new System.Drawing.Point(9, 77);
            this.cbLeerlingen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLeerlingen.Name = "cbLeerlingen";
            this.cbLeerlingen.Size = new System.Drawing.Size(159, 24);
            this.cbLeerlingen.TabIndex = 2;
            this.cbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.cbLeerlingen_SelectedIndexChanged);
            // 
            // lbLeerlingen
            // 
            this.lbLeerlingen.FormattingEnabled = true;
            this.lbLeerlingen.ItemHeight = 16;
            this.lbLeerlingen.Location = new System.Drawing.Point(9, 127);
            this.lbLeerlingen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLeerlingen.Name = "lbLeerlingen";
            this.lbLeerlingen.Size = new System.Drawing.Size(159, 116);
            this.lbLeerlingen.TabIndex = 3;
            // 
            // txtMijnTextBox
            // 
            this.txtMijnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMijnTextBox.Location = new System.Drawing.Point(9, 267);
            this.txtMijnTextBox.Name = "txtMijnTextBox";
            this.txtMijnTextBox.Size = new System.Drawing.Size(159, 22);
            this.txtMijnTextBox.TabIndex = 4;
            this.txtMijnTextBox.TextChanged += new System.EventHandler(this.txtMijnTextBox_TextChanged);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoegToe.Location = new System.Drawing.Point(581, 438);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(89, 35);
            this.btnVoegToe.TabIndex = 5;
            this.btnVoegToe.Text = "Toevoegen!";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 485);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.txtMijnTextBox);
            this.Controls.Add(this.lbLeerlingen);
            this.Controls.Add(this.cbLeerlingen);
            this.Controls.Add(this.btnMijnButton);
            this.Controls.Add(this.lbMijnLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mijn App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMijnLabel;
        private System.Windows.Forms.Button btnMijnButton;
        private System.Windows.Forms.ComboBox cbLeerlingen;
        private System.Windows.Forms.ListBox lbLeerlingen;
        private System.Windows.Forms.TextBox txtMijnTextBox;
        private System.Windows.Forms.Button btnVoegToe;
    }
}

