namespace Dietpolix
{
    partial class FormDietpolix
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myaccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.dietToolStripMenuItem,
            this.myaccountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(933, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.calendarToolStripMenuItem.Text = "Calendar";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // dietToolStripMenuItem
            // 
            this.dietToolStripMenuItem.Name = "dietToolStripMenuItem";
            this.dietToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.dietToolStripMenuItem.Text = "Diet";
            // 
            // myaccountToolStripMenuItem
            // 
            this.myaccountToolStripMenuItem.Name = "myaccountToolStripMenuItem";
            this.myaccountToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.myaccountToolStripMenuItem.Text = "My account";
            this.myaccountToolStripMenuItem.Click += new System.EventHandler(this.myaccountToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(0, 33);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(933, 452);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // FormDietpolix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 486);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDietpolix";
            this.Text = "Dietpolix";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dietToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ToolStripMenuItem myaccountToolStripMenuItem;
    }
}

