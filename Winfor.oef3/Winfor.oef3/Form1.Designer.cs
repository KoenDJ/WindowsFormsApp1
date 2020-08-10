namespace Winfor.oef3
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
            this.lbMijnListBox = new System.Windows.Forms.ListBox();
            this.tbMijnTextBox = new System.Windows.Forms.TextBox();
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMijnListBox
            // 
            this.lbMijnListBox.FormattingEnabled = true;
            this.lbMijnListBox.ItemHeight = 16;
            this.lbMijnListBox.Location = new System.Drawing.Point(0, 0);
            this.lbMijnListBox.Name = "lbMijnListBox";
            this.lbMijnListBox.Size = new System.Drawing.Size(120, 84);
            this.lbMijnListBox.TabIndex = 0;
            // 
            // tbMijnTextBox
            // 
            this.tbMijnTextBox.Location = new System.Drawing.Point(12, 102);
            this.tbMijnTextBox.Name = "tbMijnTextBox";
            this.tbMijnTextBox.Size = new System.Drawing.Size(100, 22);
            this.tbMijnTextBox.TabIndex = 1;
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(12, 145);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(75, 23);
            this.btnMijnButton.TabIndex = 2;
            this.btnMijnButton.Text = "button1";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            this.btnMijnButton.Click += new System.EventHandler(this.btnMijnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMijnButton);
            this.Controls.Add(this.tbMijnTextBox);
            this.Controls.Add(this.lbMijnListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMijnListBox;
        private System.Windows.Forms.TextBox tbMijnTextBox;
        private System.Windows.Forms.Button btnMijnButton;
    }
}

