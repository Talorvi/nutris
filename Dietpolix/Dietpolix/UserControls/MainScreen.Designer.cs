namespace Dietpolix
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxTodayDietProducts = new System.Windows.Forms.ListBox();
            this.buttonEditTodayDiet = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chartMyDream = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMyNutriens = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.labelUserCaloriesDemand = new System.Windows.Forms.Label();
            this.labelcaloriesdemand = new System.Windows.Forms.Label();
            this.labelUserBMI = new System.Windows.Forms.Label();
            this.labelbmi = new System.Windows.Forms.Label();
            this.linkLabelGotouserprofile = new System.Windows.Forms.LinkLabel();
            this.labelUserHello = new System.Windows.Forms.Label();
            this.labeltodaydiet = new System.Windows.Forms.Label();
            this.buttonTodayDiet = new System.Windows.Forms.Button();
            this.buttonWeekDiet = new System.Windows.Forms.Button();
            this.buttonMonthDiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyNutriens)).BeginInit();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTodayDietProducts
            // 
            this.listBoxTodayDietProducts.FormattingEnabled = true;
            this.listBoxTodayDietProducts.ItemHeight = 16;
            this.listBoxTodayDietProducts.Location = new System.Drawing.Point(12, 66);
            this.listBoxTodayDietProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTodayDietProducts.Name = "listBoxTodayDietProducts";
            this.listBoxTodayDietProducts.Size = new System.Drawing.Size(306, 308);
            this.listBoxTodayDietProducts.TabIndex = 0;
            // 
            // buttonEditTodayDiet
            // 
            this.buttonEditTodayDiet.Location = new System.Drawing.Point(243, 391);
            this.buttonEditTodayDiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditTodayDiet.Name = "buttonEditTodayDiet";
            this.buttonEditTodayDiet.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTodayDiet.TabIndex = 1;
            this.buttonEditTodayDiet.Text = "Edit";
            this.buttonEditTodayDiet.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chartMyDream
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMyDream.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMyDream.Legends.Add(legend1);
            this.chartMyDream.Location = new System.Drawing.Point(783, 21);
            this.chartMyDream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMyDream.Name = "chartMyDream";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMyDream.Series.Add(series1);
            this.chartMyDream.Size = new System.Drawing.Size(300, 300);
            this.chartMyDream.TabIndex = 3;
            this.chartMyDream.Text = "chartMyDream";
            // 
            // chartMyNutriens
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMyNutriens.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMyNutriens.Legends.Add(legend2);
            this.chartMyNutriens.Location = new System.Drawing.Point(374, 21);
            this.chartMyNutriens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMyNutriens.Name = "chartMyNutriens";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMyNutriens.Series.Add(series2);
            this.chartMyNutriens.Size = new System.Drawing.Size(300, 300);
            this.chartMyNutriens.TabIndex = 4;
            this.chartMyNutriens.Text = "chartMyNutriens";
            this.chartMyNutriens.Visible = false;
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.labelUserCaloriesDemand);
            this.groupBoxUserData.Controls.Add(this.labelcaloriesdemand);
            this.groupBoxUserData.Controls.Add(this.labelUserBMI);
            this.groupBoxUserData.Controls.Add(this.labelbmi);
            this.groupBoxUserData.Location = new System.Drawing.Point(374, 338);
            this.groupBoxUserData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUserData.Size = new System.Drawing.Size(400, 100);
            this.groupBoxUserData.TabIndex = 5;
            this.groupBoxUserData.TabStop = false;
            // 
            // labelUserCaloriesDemand
            // 
            this.labelUserCaloriesDemand.AutoSize = true;
            this.labelUserCaloriesDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserCaloriesDemand.Location = new System.Drawing.Point(265, 53);
            this.labelUserCaloriesDemand.Name = "labelUserCaloriesDemand";
            this.labelUserCaloriesDemand.Size = new System.Drawing.Size(67, 20);
            this.labelUserCaloriesDemand.TabIndex = 8;
            this.labelUserCaloriesDemand.Text = "No data";
            // 
            // labelcaloriesdemand
            // 
            this.labelcaloriesdemand.AutoSize = true;
            this.labelcaloriesdemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelcaloriesdemand.Location = new System.Drawing.Point(5, 53);
            this.labelcaloriesdemand.Name = "labelcaloriesdemand";
            this.labelcaloriesdemand.Size = new System.Drawing.Size(200, 20);
            this.labelcaloriesdemand.TabIndex = 7;
            this.labelcaloriesdemand.Text = "Calories demand per day:";
            // 
            // labelUserBMI
            // 
            this.labelUserBMI.AutoSize = true;
            this.labelUserBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserBMI.Location = new System.Drawing.Point(265, 16);
            this.labelUserBMI.Name = "labelUserBMI";
            this.labelUserBMI.Size = new System.Drawing.Size(67, 20);
            this.labelUserBMI.TabIndex = 6;
            this.labelUserBMI.Text = "No data";
            // 
            // labelbmi
            // 
            this.labelbmi.AutoSize = true;
            this.labelbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelbmi.Location = new System.Drawing.Point(5, 16);
            this.labelbmi.Name = "labelbmi";
            this.labelbmi.Size = new System.Drawing.Size(44, 20);
            this.labelbmi.TabIndex = 6;
            this.labelbmi.Text = "BMI:";
            // 
            // linkLabelGotouserprofile
            // 
            this.linkLabelGotouserprofile.AutoSize = true;
            this.linkLabelGotouserprofile.Location = new System.Drawing.Point(469, 156);
            this.linkLabelGotouserprofile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGotouserprofile.Name = "linkLabelGotouserprofile";
            this.linkLabelGotouserprofile.Size = new System.Drawing.Size(134, 17);
            this.linkLabelGotouserprofile.TabIndex = 9;
            this.linkLabelGotouserprofile.TabStop = true;
            this.linkLabelGotouserprofile.Text = "Edit your profile info";
            this.linkLabelGotouserprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGotouserprofile_LinkClicked);
            // 
            // labelUserHello
            // 
            this.labelUserHello.AutoSize = true;
            this.labelUserHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserHello.Location = new System.Drawing.Point(8, 18);
            this.labelUserHello.Name = "labelUserHello";
            this.labelUserHello.Size = new System.Drawing.Size(53, 20);
            this.labelUserHello.TabIndex = 10;
            this.labelUserHello.Text = "label1";
            // 
            // labeltodaydiet
            // 
            this.labeltodaydiet.AutoSize = true;
            this.labeltodaydiet.Location = new System.Drawing.Point(9, 47);
            this.labeltodaydiet.Name = "labeltodaydiet";
            this.labeltodaydiet.Size = new System.Drawing.Size(129, 17);
            this.labeltodaydiet.TabIndex = 11;
            this.labeltodaydiet.Text = "Your diet for today:";
            // 
            // buttonTodayDiet
            // 
            this.buttonTodayDiet.Location = new System.Drawing.Point(689, 210);
            this.buttonTodayDiet.Name = "buttonTodayDiet";
            this.buttonTodayDiet.Size = new System.Drawing.Size(75, 33);
            this.buttonTodayDiet.TabIndex = 12;
            this.buttonTodayDiet.Text = "Today";
            this.buttonTodayDiet.UseVisualStyleBackColor = true;
            // 
            // buttonWeekDiet
            // 
            this.buttonWeekDiet.Location = new System.Drawing.Point(689, 249);
            this.buttonWeekDiet.Name = "buttonWeekDiet";
            this.buttonWeekDiet.Size = new System.Drawing.Size(75, 33);
            this.buttonWeekDiet.TabIndex = 13;
            this.buttonWeekDiet.Text = "Week";
            this.buttonWeekDiet.UseVisualStyleBackColor = true;
            // 
            // buttonMonthDiet
            // 
            this.buttonMonthDiet.Location = new System.Drawing.Point(689, 288);
            this.buttonMonthDiet.Name = "buttonMonthDiet";
            this.buttonMonthDiet.Size = new System.Drawing.Size(75, 33);
            this.buttonMonthDiet.TabIndex = 14;
            this.buttonMonthDiet.Text = "Month";
            this.buttonMonthDiet.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMonthDiet);
            this.Controls.Add(this.buttonWeekDiet);
            this.Controls.Add(this.buttonTodayDiet);
            this.Controls.Add(this.labeltodaydiet);
            this.Controls.Add(this.labelUserHello);
            this.Controls.Add(this.linkLabelGotouserprofile);
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.chartMyNutriens);
            this.Controls.Add(this.chartMyDream);
            this.Controls.Add(this.buttonEditTodayDiet);
            this.Controls.Add(this.listBoxTodayDietProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1093, 449);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Enter += new System.EventHandler(this.MainScreen_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyNutriens)).EndInit();
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTodayDietProducts;
        private System.Windows.Forms.Button buttonEditTodayDiet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMyDream;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMyNutriens;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.Label labelcaloriesdemand;
        private System.Windows.Forms.Label labelbmi;
        private System.Windows.Forms.Label labelUserCaloriesDemand;
        private System.Windows.Forms.Label labelUserBMI;
        private System.Windows.Forms.LinkLabel linkLabelGotouserprofile;
        private System.Windows.Forms.Label labelUserHello;
        private System.Windows.Forms.Label labeltodaydiet;
        private System.Windows.Forms.Button buttonTodayDiet;
        private System.Windows.Forms.Button buttonWeekDiet;
        private System.Windows.Forms.Button buttonMonthDiet;
    }
}
