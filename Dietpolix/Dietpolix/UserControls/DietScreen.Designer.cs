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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labeldetermineportion = new System.Windows.Forms.Label();
            this.numericUpDownPortionSize = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortionSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddToDiet
            // 
            this.buttonAddToDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToDiet.Location = new System.Drawing.Point(27, 405);
            this.buttonAddToDiet.Name = "buttonAddToDiet";
            this.buttonAddToDiet.Size = new System.Drawing.Size(140, 29);
            this.buttonAddToDiet.TabIndex = 8;
            this.buttonAddToDiet.Text = "Add to diet";
            this.buttonAddToDiet.UseVisualStyleBackColor = true;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 16;
            this.listBoxMatches.Items.AddRange(new object[] {
            "<No matches found>"});
            this.listBoxMatches.Location = new System.Drawing.Point(27, 84);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(298, 292);
            this.listBoxMatches.TabIndex = 7;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearchProduct.Location = new System.Drawing.Point(27, 21);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(298, 22);
            this.textBoxSearchProduct.TabIndex = 6;
            this.textBoxSearchProduct.Text = "Search for your product";
            // 
            // monthCalendarDateOfDiet
            // 
            this.monthCalendarDateOfDiet.Location = new System.Drawing.Point(847, 84);
            this.monthCalendarDateOfDiet.Name = "monthCalendarDateOfDiet";
            this.monthCalendarDateOfDiet.TabIndex = 9;
            // 
            // listBoxCurrentDiet
            // 
            this.listBoxCurrentDiet.FormattingEnabled = true;
            this.listBoxCurrentDiet.ItemHeight = 16;
            this.listBoxCurrentDiet.Items.AddRange(new object[] {
            "<No products in diet>"});
            this.listBoxCurrentDiet.Location = new System.Drawing.Point(621, 84);
            this.listBoxCurrentDiet.Name = "listBoxCurrentDiet";
            this.listBoxCurrentDiet.Size = new System.Drawing.Size(178, 292);
            this.listBoxCurrentDiet.TabIndex = 10;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(341, 84);
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
            this.labelproductsindiet.Location = new System.Drawing.Point(618, 63);
            this.labelproductsindiet.Name = "labelproductsindiet";
            this.labelproductsindiet.Size = new System.Drawing.Size(164, 18);
            this.labelproductsindiet.TabIndex = 12;
            this.labelproductsindiet.Text = "Products in current diet:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(621, 405);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 29);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.Location = new System.Drawing.Point(724, 405);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 29);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // labeldetermineportion
            // 
            this.labeldetermineportion.AutoSize = true;
            this.labeldetermineportion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldetermineportion.Location = new System.Drawing.Point(239, 410);
            this.labeldetermineportion.Name = "labeldetermineportion";
            this.labeldetermineportion.Size = new System.Drawing.Size(181, 18);
            this.labeldetermineportion.TabIndex = 15;
            this.labeldetermineportion.Text = "Determine portion size: [g]";
            // 
            // numericUpDownPortionSize
            // 
            this.numericUpDownPortionSize.Location = new System.Drawing.Point(438, 410);
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
            this.numericUpDownPortionSize.TabIndex = 16;
            this.numericUpDownPortionSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(443, 448);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 29);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DietScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownPortionSize);
            this.Controls.Add(this.labeldetermineportion);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelproductsindiet);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.listBoxCurrentDiet);
            this.Controls.Add(this.monthCalendarDateOfDiet);
            this.Controls.Add(this.buttonAddToDiet);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.textBoxSearchProduct);
            this.Name = "DietScreen";
            this.Size = new System.Drawing.Size(1057, 524);
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labeldetermineportion;
        private System.Windows.Forms.NumericUpDown numericUpDownPortionSize;
        private System.Windows.Forms.Button buttonCancel;
    }
}
