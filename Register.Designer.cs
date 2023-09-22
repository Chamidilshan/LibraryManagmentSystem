namespace LibraryMgtsys
{
    partial class Register
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
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.regbtn = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(1010, 718);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.emailtxt);
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.regbtn);
            this.panel4.Controls.Add(this.pwdtxt);
            this.panel4.Controls.Add(this.rgtxt);
            this.panel4.Controls.Add(this.lb);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(494, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 513);
            this.panel4.TabIndex = 5;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(29, 110);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(231, 22);
            this.emailtxt.TabIndex = 9;
            this.emailtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(32, 190);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(228, 22);
            this.nametxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(253, 481);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already Have? Login...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.Location = new System.Drawing.Point(90, 362);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(274, 35);
            this.regbtn.TabIndex = 4;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pwdtxt
            // 
            this.pwdtxt.Location = new System.Drawing.Point(29, 277);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(231, 22);
            this.pwdtxt.TabIndex = 3;
            this.pwdtxt.UseSystemPasswordChar = true;
            this.pwdtxt.TextChanged += new System.EventHandler(this.pwdtxt_TextChanged);
            // 
            // rgtxt
            // 
            this.rgtxt.Location = new System.Drawing.Point(29, 38);
            this.rgtxt.Name = "rgtxt";
            this.rgtxt.Size = new System.Drawing.Size(231, 22);
            this.rgtxt.TabIndex = 2;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(26, 77);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(59, 22);
            this.lb.TabIndex = 1;
            this.lb.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registartion No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 153);
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
            this.panel3.Size = new System.Drawing.Size(1004, 60);
            this.panel3.TabIndex = 1;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.SteelBlue;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(261, 9);
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
            this.about.Location = new System.Drawing.Point(54, 9);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(121, 40);
            this.about.TabIndex = 0;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 66);
            this.panel2.TabIndex = 0;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.TextBox rgtxt;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox nametxt;
    }
}