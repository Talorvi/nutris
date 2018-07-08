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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxTodayDietProducts = new System.Windows.Forms.ListBox();
            this.buttonEditTodayDiet = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chartMyDream = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.labelUserCaloriesDemand = new System.Windows.Forms.Label();
            this.labelcaloriesdemand = new System.Windows.Forms.Label();
            this.labelUserBMI = new System.Windows.Forms.Label();
            this.labelbmi = new System.Windows.Forms.Label();
            this.linkLabelGotouserprofile = new System.Windows.Forms.LinkLabel();
            this.labelUserHello = new System.Windows.Forms.Label();
            this.labelyourdiet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            chartArea7.Name = "ChartArea1";
            this.chartMyDream.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartMyDream.Legends.Add(legend7);
            this.chartMyDream.Location = new System.Drawing.Point(783, 21);
            this.chartMyDream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMyDream.Name = "chartMyDream";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartMyDream.Series.Add(series7);
            this.chartMyDream.Size = new System.Drawing.Size(300, 300);
            this.chartMyDream.TabIndex = 3;
            this.chartMyDream.Text = "chartMyDream";
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(383, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chartMyNutriens";
            this.chart1.Visible = false;
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
            this.labelUserHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserHello.Location = new System.Drawing.Point(8, 0);
            this.labelUserHello.Name = "labelUserHello";
            this.labelUserHello.Size = new System.Drawing.Size(51, 24);
            this.labelUserHello.TabIndex = 10;
            this.labelUserHello.Text = "hello";
            // 
            // labelyourdiet
            // 
            this.labelyourdiet.AutoSize = true;
            this.labelyourdiet.Location = new System.Drawing.Point(9, 47);
            this.labelyourdiet.Name = "labelyourdiet";
            this.labelyourdiet.Size = new System.Drawing.Size(129, 17);
            this.labelyourdiet.TabIndex = 11;
            this.labelyourdiet.Text = "Your diet for today:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelyourdiet);
            this.Controls.Add(this.labelUserHello);
            this.Controls.Add(this.linkLabelGotouserprofile);
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartMyDream);
            this.Controls.Add(this.buttonEditTodayDiet);
            this.Controls.Add(this.listBoxTodayDietProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1093, 449);
            this.VisibleChanged += new System.EventHandler(this.MainScreen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.Label labelcaloriesdemand;
        private System.Windows.Forms.Label labelbmi;
        private System.Windows.Forms.Label labelUserCaloriesDemand;
        private System.Windows.Forms.Label labelUserBMI;
        private System.Windows.Forms.LinkLabel linkLabelGotouserprofile;
        private System.Windows.Forms.Label labelUserHello;
        private System.Windows.Forms.Label labelyourdiet;
    }
}
