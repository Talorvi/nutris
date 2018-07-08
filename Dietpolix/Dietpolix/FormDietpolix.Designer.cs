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
            this.myaccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hometoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.myaccountToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.dietToolStripMenuItem,
            this.hometoolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(818, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // myaccountToolStripMenuItem
            // 
            this.myaccountToolStripMenuItem.Name = "myaccountToolStripMenuItem";
            this.myaccountToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.myaccountToolStripMenuItem.Text = "My account";
            this.myaccountToolStripMenuItem.Click += new System.EventHandler(this.myaccountToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // dietToolStripMenuItem
            // 
            this.dietToolStripMenuItem.Name = "dietToolStripMenuItem";
            this.dietToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.dietToolStripMenuItem.Text = "Diet";
            this.dietToolStripMenuItem.Click += new System.EventHandler(this.dietToolStripMenuItem_Click);
            // 
            // hometoolStripMenuItem
            // 
            this.hometoolStripMenuItem.Name = "hometoolStripMenuItem";
            this.hometoolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hometoolStripMenuItem.Text = "Home";
            this.hometoolStripMenuItem.Click += new System.EventHandler(this.hometoolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(0, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(818, 367);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // FormDietpolix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 395);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
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
        private System.Windows.Forms.ToolStripMenuItem hometoolStripMenuItem;
    }
}

