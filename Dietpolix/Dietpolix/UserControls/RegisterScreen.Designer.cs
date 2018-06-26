namespace Dietpolix.UserControls
{
    partial class RegisterScreen
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.linkLabelGotoLogin = new System.Windows.Forms.LinkLabel();
            this.buttonCancelRegister = new System.Windows.Forms.Button();
            this.errorProviderEmptyTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmptyTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(19, 21);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 53);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Location = new System.Drawing.Point(19, 85);
            this.labelPassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(73, 17);
            this.labelPassword1.TabIndex = 2;
            this.labelPassword1.Text = "Password:";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(19, 117);
            this.labelPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(73, 17);
            this.labelPassword2.TabIndex = 3;
            this.labelPassword2.Text = "Password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(136, 17);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.MaxLength = 16;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(132, 22);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 49);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 16;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(136, 81);
            this.textBoxPassword1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword1.MaxLength = 32;
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.PasswordChar = '*';
            this.textBoxPassword1.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword1.TabIndex = 7;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(136, 113);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword2.MaxLength = 32;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword2.TabIndex = 8;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(136, 145);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(133, 28);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.ForeColor = System.Drawing.Color.Green;
            this.labelInfo.Location = new System.Drawing.Point(46, 189);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(223, 17);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "Your account has been registered";
            this.labelInfo.Visible = false;
            // 
            // linkLabelGotoLogin
            // 
            this.linkLabelGotoLogin.AutoSize = true;
            this.linkLabelGotoLogin.Location = new System.Drawing.Point(221, 219);
            this.linkLabelGotoLogin.Name = "linkLabelGotoLogin";
            this.linkLabelGotoLogin.Size = new System.Drawing.Size(47, 17);
            this.linkLabelGotoLogin.TabIndex = 11;
            this.linkLabelGotoLogin.TabStop = true;
            this.linkLabelGotoLogin.Text = "Log in";
            this.linkLabelGotoLogin.Visible = false;
            this.linkLabelGotoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGotoLogin_LinkClicked);
            // 
            // buttonCancelRegister
            // 
            this.buttonCancelRegister.Location = new System.Drawing.Point(22, 145);
            this.buttonCancelRegister.Name = "buttonCancelRegister";
            this.buttonCancelRegister.Size = new System.Drawing.Size(95, 28);
            this.buttonCancelRegister.TabIndex = 9;
            this.buttonCancelRegister.Text = "Cancel";
            this.buttonCancelRegister.UseVisualStyleBackColor = true;
            this.buttonCancelRegister.Click += new System.EventHandler(this.buttonCancelRegister_Click);
            // 
            // errorProviderEmptyTextBox
            // 
            this.errorProviderEmptyTextBox.ContainerControl = this;
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelRegister);
            this.Controls.Add(this.linkLabelGotoLogin);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.labelPassword1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterScreen";
            this.Size = new System.Drawing.Size(607, 344);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.RegisterScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmptyTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.LinkLabel linkLabelGotoLogin;
        private System.Windows.Forms.Button buttonCancelRegister;
        private System.Windows.Forms.ErrorProvider errorProviderEmptyTextBox;
    }
}
