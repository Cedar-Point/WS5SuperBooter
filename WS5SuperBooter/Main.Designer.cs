namespace WS5SuperBooter
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
            this.btnReboot = new System.Windows.Forms.Button();
            this.tbReboot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReboot
            // 
            this.btnReboot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReboot.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.Location = new System.Drawing.Point(4, 35);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(266, 35);
            this.btnReboot.TabIndex = 1;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.BtnReboot_Click);
            // 
            // tbReboot
            // 
            this.tbReboot.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbReboot.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReboot.Location = new System.Drawing.Point(0, 0);
            this.tbReboot.Multiline = true;
            this.tbReboot.Name = "tbReboot";
            this.tbReboot.Size = new System.Drawing.Size(274, 32);
            this.tbReboot.TabIndex = 2;
            this.tbReboot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(274, 73);
            this.Controls.Add(this.tbReboot);
            this.Controls.Add(this.btnReboot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Booter - WS5 Edition";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.TextBox tbReboot;
    }
}

