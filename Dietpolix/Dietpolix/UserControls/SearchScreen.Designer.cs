namespace Dietpolix
{
    partial class SearchScreen
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
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.textBoxProductDetails = new System.Windows.Forms.TextBox();
            this.labeldetails = new System.Windows.Forms.Label();
            this.buttonAddToDiet = new System.Windows.Forms.Button();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearchProduct.Location = new System.Drawing.Point(26, 18);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(298, 22);
            this.textBoxSearchProduct.TabIndex = 0;
            this.textBoxSearchProduct.Text = "Search for your product";
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 16;
            this.listBoxMatches.Items.AddRange(new object[] {
            "<No matches found>"});
            this.listBoxMatches.Location = new System.Drawing.Point(26, 57);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(298, 292);
            this.listBoxMatches.TabIndex = 1;
            // 
            // textBoxProductDetails
            // 
            this.textBoxProductDetails.Location = new System.Drawing.Point(365, 57);
            this.textBoxProductDetails.Multiline = true;
            this.textBoxProductDetails.Name = "textBoxProductDetails";
            this.textBoxProductDetails.Size = new System.Drawing.Size(381, 292);
            this.textBoxProductDetails.TabIndex = 2;
            this.textBoxProductDetails.Text = "No details";
            // 
            // labeldetails
            // 
            this.labeldetails.AutoSize = true;
            this.labeldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldetails.Location = new System.Drawing.Point(362, 19);
            this.labeldetails.Name = "labeldetails";
            this.labeldetails.Size = new System.Drawing.Size(205, 18);
            this.labeldetails.TabIndex = 3;
            this.labeldetails.Text = "Details of the chosen product:";
            // 
            // buttonAddToDiet
            // 
            this.buttonAddToDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToDiet.Location = new System.Drawing.Point(630, 374);
            this.buttonAddToDiet.Name = "buttonAddToDiet";
            this.buttonAddToDiet.Size = new System.Drawing.Size(116, 29);
            this.buttonAddToDiet.TabIndex = 4;
            this.buttonAddToDiet.Text = "Add to diet";
            this.buttonAddToDiet.UseVisualStyleBackColor = true;
            this.buttonAddToDiet.Click += new System.EventHandler(this.buttonAddToDiet_Click);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewProduct.Location = new System.Drawing.Point(26, 374);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(140, 29);
            this.buttonAddNewProduct.TabIndex = 5;
            this.buttonAddNewProduct.Text = "Add new product";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddNewProduct);
            this.Controls.Add(this.buttonAddToDiet);
            this.Controls.Add(this.labeldetails);
            this.Controls.Add(this.textBoxProductDetails);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.textBoxSearchProduct);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(1078, 547);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.TextBox textBoxProductDetails;
        private System.Windows.Forms.Label labeldetails;
        private System.Windows.Forms.Button buttonAddToDiet;
        private System.Windows.Forms.Button buttonAddNewProduct;
    }
}
