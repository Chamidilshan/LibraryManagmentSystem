namespace LibraryMgtsys
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.rgtxt = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contact = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 721);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.loginbtn);
            this.panel4.Controls.Add(this.pwdtxt);
            this.panel4.Controls.Add(this.rgtxt);
            this.panel4.Controls.Add(this.lb);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(576, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 269);
            this.panel4.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(175, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New User? Register...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(29, 192);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(231, 35);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // pwdtxt
            // 
            this.pwdtxt.Location = new System.Drawing.Point(29, 140);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(231, 22);
            this.pwdtxt.TabIndex = 3;
            this.pwdtxt.UseSystemPasswordChar = true;
            this.pwdtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rgtxt
            // 
            this.rgtxt.Location = new System.Drawing.Point(29, 56);
            this.rgtxt.Name = "rgtxt";
            this.rgtxt.Size = new System.Drawing.Size(231, 22);
            this.rgtxt.TabIndex = 2;
            this.rgtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(26, 102);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(94, 22);
            this.lb.TabIndex = 1;
            this.lb.Text = "Password:";
            this.lb.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registartion No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "PICTURE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contact);
            this.panel3.Controls.Add(this.about);
            this.panel3.Location = new System.Drawing.Point(3, 658);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 60);
            this.panel3.TabIndex = 1;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.SteelBlue;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(270, 9);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(121, 40);
            this.contact.TabIndex = 1;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = false;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.SteelBlue;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(60, 9);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(121, 40);
            this.about.TabIndex = 0;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 66);
            this.panel2.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.TextBox rgtxt;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}