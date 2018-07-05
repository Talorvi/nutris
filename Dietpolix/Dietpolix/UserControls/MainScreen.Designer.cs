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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chartMyDream = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.labelUserCaloriesDemand = new System.Windows.Forms.Label();
            this.labelcaloriesdemand = new System.Windows.Forms.Label();
            this.labelUserBMI = new System.Windows.Forms.Label();
            this.labelbmi = new System.Windows.Forms.Label();
            this.linkLabelGotouserprofile = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTodayDietProducts
            // 
            this.listBoxTodayDietProducts.FormattingEnabled = true;
            this.listBoxTodayDietProducts.Location = new System.Drawing.Point(9, 15);
            this.listBoxTodayDietProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTodayDietProducts.Name = "listBoxTodayDietProducts";
            this.listBoxTodayDietProducts.Size = new System.Drawing.Size(100, 290);
            this.listBoxTodayDietProducts.TabIndex = 0;
            this.listBoxTodayDietProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxTodayDietProducts_SelectedIndexChanged);
            // 
            // buttonEditTodayDiet
            // 
            this.buttonEditTodayDiet.Location = new System.Drawing.Point(52, 318);
            this.buttonEditTodayDiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditTodayDiet.Name = "buttonEditTodayDiet";
            this.buttonEditTodayDiet.Size = new System.Drawing.Size(56, 19);
            this.buttonEditTodayDiet.TabIndex = 1;
            this.buttonEditTodayDiet.Text = "Edit";
            this.buttonEditTodayDiet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 290);
            this.textBox1.TabIndex = 2;
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
            this.chartMyDream.Location = new System.Drawing.Point(587, 17);
            this.chartMyDream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartMyDream.Name = "chartMyDream";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMyDream.Series.Add(series1);
            this.chartMyDream.Size = new System.Drawing.Size(225, 244);
            this.chartMyDream.TabIndex = 3;
            this.chartMyDream.Text = "chartMyDream";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(320, 17);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(225, 244);
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
            this.groupBoxUserData.Location = new System.Drawing.Point(320, 275);
            this.groupBoxUserData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUserData.Size = new System.Drawing.Size(300, 81);
            this.groupBoxUserData.TabIndex = 5;
            this.groupBoxUserData.TabStop = false;
            // 
            // labelUserCaloriesDemand
            // 
            this.labelUserCaloriesDemand.AutoSize = true;
            this.labelUserCaloriesDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserCaloriesDemand.Location = new System.Drawing.Point(199, 43);
            this.labelUserCaloriesDemand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserCaloriesDemand.Name = "labelUserCaloriesDemand";
            this.labelUserCaloriesDemand.Size = new System.Drawing.Size(58, 17);
            this.labelUserCaloriesDemand.TabIndex = 8;
            this.labelUserCaloriesDemand.Text = "No data";
            // 
            // labelcaloriesdemand
            // 
            this.labelcaloriesdemand.AutoSize = true;
            this.labelcaloriesdemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelcaloriesdemand.Location = new System.Drawing.Point(4, 43);
            this.labelcaloriesdemand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcaloriesdemand.Name = "labelcaloriesdemand";
            this.labelcaloriesdemand.Size = new System.Drawing.Size(170, 17);
            this.labelcaloriesdemand.TabIndex = 7;
            this.labelcaloriesdemand.Text = "Calories demand per day:";
            // 
            // labelUserBMI
            // 
            this.labelUserBMI.AutoSize = true;
            this.labelUserBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserBMI.Location = new System.Drawing.Point(199, 13);
            this.labelUserBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserBMI.Name = "labelUserBMI";
            this.labelUserBMI.Size = new System.Drawing.Size(58, 17);
            this.labelUserBMI.TabIndex = 6;
            this.labelUserBMI.Text = "No data";
            // 
            // labelbmi
            // 
            this.labelbmi.AutoSize = true;
            this.labelbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelbmi.Location = new System.Drawing.Point(4, 13);
            this.labelbmi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbmi.Name = "labelbmi";
            this.labelbmi.Size = new System.Drawing.Size(35, 17);
            this.labelbmi.TabIndex = 6;
            this.labelbmi.Text = "BMI:";
            // 
            // linkLabelGotouserprofile
            // 
            this.linkLabelGotouserprofile.AutoSize = true;
            this.linkLabelGotouserprofile.Location = new System.Drawing.Point(374, 136);
            this.linkLabelGotouserprofile.Name = "linkLabelGotouserprofile";
            this.linkLabelGotouserprofile.Size = new System.Drawing.Size(99, 13);
            this.linkLabelGotouserprofile.TabIndex = 9;
            this.linkLabelGotouserprofile.TabStop = true;
            this.linkLabelGotouserprofile.Text = "Edit your profile info";
            this.linkLabelGotouserprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGotouserprofile_LinkClicked);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelGotouserprofile);
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartMyDream);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEditTodayDiet);
            this.Controls.Add(this.listBoxTodayDietProducts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(820, 365);
            this.Load += new System.EventHandler(this.MainScreen_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMyDream;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.Label labelcaloriesdemand;
        private System.Windows.Forms.Label labelbmi;
        private System.Windows.Forms.Label labelUserCaloriesDemand;
        private System.Windows.Forms.Label labelUserBMI;
        private System.Windows.Forms.LinkLabel linkLabelGotouserprofile;
    }
}
