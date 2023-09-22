namespace LibraryMgtsys
{
    partial class HOME
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contact = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rgbtn = new System.Windows.Forms.Button();
            this.logbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 722);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Started";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contact);
            this.panel3.Controls.Add(this.about);
            this.panel3.Location = new System.Drawing.Point(4, 659);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 60);
            this.panel3.TabIndex = 1;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.SteelBlue;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(237, 13);
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
            this.about.Location = new System.Drawing.Point(67, 13);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(121, 40);
            this.about.TabIndex = 0;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.rgbtn);
            this.panel2.Controls.Add(this.logbtn);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 66);
            this.panel2.TabIndex = 0;
            // 
            // rgbtn
            // 
            this.rgbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.rgbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbtn.Location = new System.Drawing.Point(823, 11);
            this.rgbtn.Name = "rgbtn";
            this.rgbtn.Size = new System.Drawing.Size(121, 40);
            this.rgbtn.TabIndex = 1;
            this.rgbtn.Text = "reginster";
            this.rgbtn.UseVisualStyleBackColor = false;
            this.rgbtn.Click += new System.EventHandler(this.rgbtn_Click);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(680, 12);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(121, 40);
            this.logbtn.TabIndex = 0;
            this.logbtn.Text = "login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel1);
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button rgbtn;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

