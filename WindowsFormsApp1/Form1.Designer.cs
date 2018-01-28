namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pctexit = new System.Windows.Forms.PictureBox();
            this.pctresim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(12, 279);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(496, 22);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(12, 329);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(496, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // btnlogin
            // 
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogin.Location = new System.Drawing.Point(157, 366);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(173, 53);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.TabStop = false;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(12, 444);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.Text = "Forgot Password";
            // 
            // pctexit
            // 
            this.pctexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctexit.Image = global::WindowsFormsApp1.Properties.Resources._170796_button_256x256;
            this.pctexit.Location = new System.Drawing.Point(433, 12);
            this.pctexit.Name = "pctexit";
            this.pctexit.Size = new System.Drawing.Size(75, 50);
            this.pctexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctexit.TabIndex = 8;
            this.pctexit.TabStop = false;
            this.pctexit.Click += new System.EventHandler(this.pctexit_Click);
            // 
            // pctresim
            // 
            this.pctresim.Image = global::WindowsFormsApp1.Properties.Resources.Crystal_Project_Lock;
            this.pctresim.Location = new System.Drawing.Point(157, 21);
            this.pctresim.Name = "pctresim";
            this.pctresim.Size = new System.Drawing.Size(169, 204);
            this.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctresim.TabIndex = 1;
            this.pctresim.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 470);
            this.Controls.Add(this.pctexit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pctresim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Alperjoo";
            ((System.ComponentModel.ISupportInitialize)(this.pctexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctresim;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pctexit;
    }
}

