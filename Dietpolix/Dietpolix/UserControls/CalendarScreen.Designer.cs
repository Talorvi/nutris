namespace Dietpolix
{
    partial class CalendarScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendarDiet = new System.Windows.Forms.MonthCalendar();
            this.listBoxUserDayDiet = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendarDiet
            // 
            this.monthCalendarDiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendarDiet.Location = new System.Drawing.Point(61, 64);
            this.monthCalendarDiet.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarDiet.MaxSelectionCount = 1;
            this.monthCalendarDiet.Name = "monthCalendarDiet";
            this.monthCalendarDiet.ScrollChange = 1;
            this.monthCalendarDiet.ShowWeekNumbers = true;
            this.monthCalendarDiet.TabIndex = 1;
            this.monthCalendarDiet.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarDiet_DateSelected);
            // 
            // listBoxUserDayDiet
            // 
            this.listBoxUserDayDiet.FormattingEnabled = true;
            this.listBoxUserDayDiet.ItemHeight = 16;
            this.listBoxUserDayDiet.Location = new System.Drawing.Point(508, 25);
            this.listBoxUserDayDiet.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserDayDiet.Name = "listBoxUserDayDiet";
            this.listBoxUserDayDiet.Size = new System.Drawing.Size(231, 292);
            this.listBoxUserDayDiet.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CalendarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxUserDayDiet);
            this.Controls.Add(this.monthCalendarDiet);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarScreen";
            this.Size = new System.Drawing.Size(756, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendarDiet;
        private System.Windows.Forms.ListBox listBoxUserDayDiet;
        private System.Windows.Forms.Button button1;
    }
}
