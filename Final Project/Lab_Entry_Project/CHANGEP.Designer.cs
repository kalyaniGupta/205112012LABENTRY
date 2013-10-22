namespace Lab_Entry_Project
{
    partial class CHANGEP
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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UNM = new System.Windows.Forms.TextBox();
            this.OPWD = new System.Windows.Forms.TextBox();
            this.NPWD = new System.Windows.Forms.TextBox();
            this.CPWD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(74, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 37;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "NEW PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "OLD PASSWORD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "CONFIRM PASS.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UNM
            // 
            this.UNM.Location = new System.Drawing.Point(230, 63);
            this.UNM.Multiline = true;
            this.UNM.Name = "UNM";
            this.UNM.Size = new System.Drawing.Size(100, 29);
            this.UNM.TabIndex = 1;
            this.UNM.TextChanged += new System.EventHandler(this.UNM_TextChanged_1);
            // 
            // OPWD
            // 
            this.OPWD.Location = new System.Drawing.Point(230, 113);
            this.OPWD.Multiline = true;
            this.OPWD.Name = "OPWD";
            this.OPWD.Size = new System.Drawing.Size(100, 29);
            this.OPWD.TabIndex = 3;
            this.OPWD.UseSystemPasswordChar = true;
            this.OPWD.TextChanged += new System.EventHandler(this.OPWD_TextChanged);
            // 
            // NPWD
            // 
            this.NPWD.Location = new System.Drawing.Point(230, 162);
            this.NPWD.Multiline = true;
            this.NPWD.Name = "NPWD";
            this.NPWD.Size = new System.Drawing.Size(100, 29);
            this.NPWD.TabIndex = 4;
            this.NPWD.UseSystemPasswordChar = true;
            this.NPWD.TextChanged += new System.EventHandler(this.NPWD_TextChanged_1);
            // 
            // CPWD
            // 
            this.CPWD.Location = new System.Drawing.Point(230, 217);
            this.CPWD.Multiline = true;
            this.CPWD.Name = "CPWD";
            this.CPWD.Size = new System.Drawing.Size(100, 29);
            this.CPWD.TabIndex = 5;
            this.CPWD.UseSystemPasswordChar = true;
            this.CPWD.TextChanged += new System.EventHandler(this.CPWD_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(212, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHANGEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(436, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UNM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPWD);
            this.Controls.Add(this.OPWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NPWD);
            this.Name = "CHANGEP";
            this.Text = "CHANGEP";
            this.Load += new System.EventHandler(this.CHANGEP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UNM;
        private System.Windows.Forms.TextBox OPWD;
        private System.Windows.Forms.TextBox NPWD;
        private System.Windows.Forms.TextBox CPWD;
        private System.Windows.Forms.Button button1;
    }
}