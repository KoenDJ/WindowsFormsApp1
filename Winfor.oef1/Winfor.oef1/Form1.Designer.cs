namespace Winfor.oef1
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
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.lbMijnList = new System.Windows.Forms.ListBox();
            this.txtMijnText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(0, 0);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(75, 23);
            this.btnMijnButton.TabIndex = 0;
            this.btnMijnButton.Text = "button1";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            this.btnMijnButton.Click += new System.EventHandler(this.btnMijnButton_Click);
            // 
            // lbMijnList
            // 
            this.lbMijnList.FormattingEnabled = true;
            this.lbMijnList.ItemHeight = 16;
            this.lbMijnList.Location = new System.Drawing.Point(0, 50);
            this.lbMijnList.Name = "lbMijnList";
            this.lbMijnList.Size = new System.Drawing.Size(120, 84);
            this.lbMijnList.TabIndex = 1;
            // 
            // txtMijnText
            // 
            this.txtMijnText.Location = new System.Drawing.Point(0, 169);
            this.txtMijnText.Name = "txtMijnText";
            this.txtMijnText.Size = new System.Drawing.Size(100, 22);
            this.txtMijnText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMijnText);
            this.Controls.Add(this.lbMijnList);
            this.Controls.Add(this.btnMijnButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMijnButton;
        private System.Windows.Forms.ListBox lbMijnList;
        private System.Windows.Forms.TextBox txtMijnText;
    }
}

