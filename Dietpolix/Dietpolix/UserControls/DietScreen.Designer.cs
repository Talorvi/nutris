namespace Dietpolix
{
    partial class DietScreen
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
            this.buttonAddToDiet = new System.Windows.Forms.Button();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.monthCalendarDateOfDiet = new System.Windows.Forms.MonthCalendar();
            this.listBoxCurrentDiet = new System.Windows.Forms.ListBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.labelproductsindiet = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxAddToDiet = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownPortionSize = new System.Windows.Forms.NumericUpDown();
            this.labeldetermineportion = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxAddToDiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortionSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddToDiet
            // 
            this.buttonAddToDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToDiet.Location = new System.Drawing.Point(27, 372);
            this.buttonAddToDiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddToDiet.Name = "buttonAddToDiet";
            this.buttonAddToDiet.Size = new System.Drawing.Size(140, 30);
            this.buttonAddToDiet.TabIndex = 8;
            this.buttonAddToDiet.Text = "Add to diet";
            this.buttonAddToDiet.UseVisualStyleBackColor = true;
            this.buttonAddToDiet.Click += new System.EventHandler(this.buttonAddToDiet_Click);
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 16;
            this.listBoxMatches.Items.AddRange(new object[] {
            "<No matches found>"});
            this.listBoxMatches.Location = new System.Drawing.Point(27, 65);
            this.listBoxMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(297, 292);
            this.listBoxMatches.TabIndex = 7;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxMatches_SelectedIndexChanged);
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearchProduct.Location = new System.Drawing.Point(27, 21);
            this.textBoxSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(192, 22);
            this.textBoxSearchProduct.TabIndex = 6;
            this.textBoxSearchProduct.Text = "Search for your product";
            // 
            // monthCalendarDateOfDiet
            // 
            this.monthCalendarDateOfDiet.Location = new System.Drawing.Point(828, 65);
            this.monthCalendarDateOfDiet.Name = "monthCalendarDateOfDiet";
            this.monthCalendarDateOfDiet.TabIndex = 9;
            this.monthCalendarDateOfDiet.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarDateOfDiet_DateSelected);
            // 
            // listBoxCurrentDiet
            // 
            this.listBoxCurrentDiet.FormattingEnabled = true;
            this.listBoxCurrentDiet.ItemHeight = 16;
            this.listBoxCurrentDiet.Items.AddRange(new object[] {
            "<No products in diet>"});
            this.listBoxCurrentDiet.Location = new System.Drawing.Point(597, 65);
            this.listBoxCurrentDiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCurrentDiet.Name = "listBoxCurrentDiet";
            this.listBoxCurrentDiet.Size = new System.Drawing.Size(219, 292);
            this.listBoxCurrentDiet.TabIndex = 10;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(330, 65);
            this.textBoxDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(261, 292);
            this.textBoxDetails.TabIndex = 11;
            this.textBoxDetails.Text = "No details";
            // 
            // labelproductsindiet
            // 
            this.labelproductsindiet.AutoSize = true;
            this.labelproductsindiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelproductsindiet.Location = new System.Drawing.Point(619, 44);
            this.labelproductsindiet.Name = "labelproductsindiet";
            this.labelproductsindiet.Size = new System.Drawing.Size(164, 18);
            this.labelproductsindiet.TabIndex = 12;
            this.labelproductsindiet.Text = "Products in current diet:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.Location = new System.Drawing.Point(225, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 30);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxAddToDiet
            // 
            this.groupBoxAddToDiet.Controls.Add(this.buttonCancel);
            this.groupBoxAddToDiet.Controls.Add(this.numericUpDownPortionSize);
            this.groupBoxAddToDiet.Controls.Add(this.labeldetermineportion);
            this.groupBoxAddToDiet.Controls.Add(this.buttonAdd);
            this.groupBoxAddToDiet.Location = new System.Drawing.Point(210, 362);
            this.groupBoxAddToDiet.Name = "groupBoxAddToDiet";
            this.groupBoxAddToDiet.Size = new System.Drawing.Size(588, 100);
            this.groupBoxAddToDiet.TabIndex = 19;
            this.groupBoxAddToDiet.TabStop = false;
            this.groupBoxAddToDiet.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(217, 54);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownPortionSize
            // 
            this.numericUpDownPortionSize.Location = new System.Drawing.Point(212, 17);
            this.numericUpDownPortionSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPortionSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPortionSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPortionSize.Name = "numericUpDownPortionSize";
            this.numericUpDownPortionSize.Size = new System.Drawing.Size(105, 22);
            this.numericUpDownPortionSize.TabIndex = 21;
            this.numericUpDownPortionSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labeldetermineportion
            // 
            this.labeldetermineportion.AutoSize = true;
            this.labeldetermineportion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldetermineportion.Location = new System.Drawing.Point(14, 17);
            this.labeldetermineportion.Name = "labeldetermineportion";
            this.labeldetermineportion.Size = new System.Drawing.Size(181, 18);
            this.labeldetermineportion.TabIndex = 20;
            this.labeldetermineportion.Text = "Determine portion size: [g]";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.Location = new System.Drawing.Point(828, 327);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(89, 30);
            this.buttonRemove.TabIndex = 19;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(411, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // DietScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddToDiet);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelproductsindiet);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.listBoxCurrentDiet);
            this.Controls.Add(this.monthCalendarDateOfDiet);
            this.Controls.Add(this.buttonAddToDiet);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.textBoxSearchProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DietScreen";
            this.Size = new System.Drawing.Size(1213, 524);
            this.Load += new System.EventHandler(this.DietScreen_Load);
            this.groupBoxAddToDiet.ResumeLayout(false);
            this.groupBoxAddToDiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortionSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddToDiet;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.MonthCalendar monthCalendarDateOfDiet;
        private System.Windows.Forms.ListBox listBoxCurrentDiet;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label labelproductsindiet;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxAddToDiet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownPortionSize;
        private System.Windows.Forms.Label labeldetermineportion;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
    }
}
