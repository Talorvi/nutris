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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTodayDietProducts
            // 
            this.listBoxTodayDietProducts.FormattingEnabled = true;
            this.listBoxTodayDietProducts.ItemHeight = 16;
            this.listBoxTodayDietProducts.Location = new System.Drawing.Point(12, 18);
            this.listBoxTodayDietProducts.Name = "listBoxTodayDietProducts";
            this.listBoxTodayDietProducts.Size = new System.Drawing.Size(132, 356);
            this.listBoxTodayDietProducts.TabIndex = 0;
            this.listBoxTodayDietProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxTodayDietProducts_SelectedIndexChanged);
            // 
            // buttonEditTodayDiet
            // 
            this.buttonEditTodayDiet.Location = new System.Drawing.Point(69, 391);
            this.buttonEditTodayDiet.Name = "buttonEditTodayDiet";
            this.buttonEditTodayDiet.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTodayDiet.TabIndex = 1;
            this.buttonEditTodayDiet.Text = "Edit";
            this.buttonEditTodayDiet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 356);
            this.textBox1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // chartMyDream
            // 
            chartArea9.Name = "ChartArea1";
            this.chartMyDream.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartMyDream.Legends.Add(legend9);
            this.chartMyDream.Location = new System.Drawing.Point(783, 21);
            this.chartMyDream.Name = "chartMyDream";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartMyDream.Series.Add(series9);
            this.chartMyDream.Size = new System.Drawing.Size(300, 300);
            this.chartMyDream.TabIndex = 3;
            this.chartMyDream.Text = "chartMyDream";
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(427, 21);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chartMyNutriens";
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.labelUserCaloriesDemand);
            this.groupBoxUserData.Controls.Add(this.labelcaloriesdemand);
            this.groupBoxUserData.Controls.Add(this.labelUserBMI);
            this.groupBoxUserData.Controls.Add(this.label1);
            this.groupBoxUserData.Location = new System.Drawing.Point(427, 338);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Size = new System.Drawing.Size(377, 100);
            this.groupBoxUserData.TabIndex = 5;
            this.groupBoxUserData.TabStop = false;
            // 
            // labelUserCaloriesDemand
            // 
            this.labelUserCaloriesDemand.AutoSize = true;
            this.labelUserCaloriesDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserCaloriesDemand.Location = new System.Drawing.Point(213, 53);
            this.labelUserCaloriesDemand.Name = "labelUserCaloriesDemand";
            this.labelUserCaloriesDemand.Size = new System.Drawing.Size(67, 20);
            this.labelUserCaloriesDemand.TabIndex = 8;
            this.labelUserCaloriesDemand.Text = "No data";
            // 
            // labelcaloriesdemand
            // 
            this.labelcaloriesdemand.AutoSize = true;
            this.labelcaloriesdemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelcaloriesdemand.Location = new System.Drawing.Point(6, 53);
            this.labelcaloriesdemand.Name = "labelcaloriesdemand";
            this.labelcaloriesdemand.Size = new System.Drawing.Size(200, 20);
            this.labelcaloriesdemand.TabIndex = 7;
            this.labelcaloriesdemand.Text = "Calories demand per day:";
            // 
            // labelUserBMI
            // 
            this.labelUserBMI.AutoSize = true;
            this.labelUserBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserBMI.Location = new System.Drawing.Point(213, 16);
            this.labelUserBMI.Name = "labelUserBMI";
            this.labelUserBMI.Size = new System.Drawing.Size(67, 20);
            this.labelUserBMI.TabIndex = 6;
            this.labelUserBMI.Text = "No data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "BMI:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartMyDream);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEditTodayDiet);
            this.Controls.Add(this.listBoxTodayDietProducts);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1093, 449);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserCaloriesDemand;
        private System.Windows.Forms.Label labelUserBMI;
    }
}
