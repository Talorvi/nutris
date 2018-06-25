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
            this.listBoxTodayDietProducts = new System.Windows.Forms.ListBox();
            this.buttonEditTodayDiet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chartMyDream = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTodayDietProducts
            // 
            this.listBoxTodayDietProducts.FormattingEnabled = true;
            this.listBoxTodayDietProducts.ItemHeight = 16;
            this.listBoxTodayDietProducts.Location = new System.Drawing.Point(3, 3);
            this.listBoxTodayDietProducts.Name = "listBoxTodayDietProducts";
            this.listBoxTodayDietProducts.Size = new System.Drawing.Size(132, 388);
            this.listBoxTodayDietProducts.TabIndex = 0;
            this.listBoxTodayDietProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxTodayDietProducts_SelectedIndexChanged);
            // 
            // buttonEditTodayDiet
            // 
            this.buttonEditTodayDiet.Location = new System.Drawing.Point(60, 413);
            this.buttonEditTodayDiet.Name = "buttonEditTodayDiet";
            this.buttonEditTodayDiet.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTodayDiet.TabIndex = 1;
            this.buttonEditTodayDiet.Text = "Edit";
            this.buttonEditTodayDiet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 388);
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
            chartArea1.Name = "ChartArea1";
            this.chartMyDream.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMyDream.Legends.Add(legend1);
            this.chartMyDream.Location = new System.Drawing.Point(402, 22);
            this.chartMyDream.Name = "chartMyDream";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMyDream.Series.Add(series1);
            this.chartMyDream.Size = new System.Drawing.Size(300, 300);
            this.chartMyDream.TabIndex = 3;
            this.chartMyDream.Text = "chartMyDream";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMyDream);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEditTodayDiet);
            this.Controls.Add(this.listBoxTodayDietProducts);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(829, 548);
            ((System.ComponentModel.ISupportInitialize)(this.chartMyDream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTodayDietProducts;
        private System.Windows.Forms.Button buttonEditTodayDiet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMyDream;
    }
}
