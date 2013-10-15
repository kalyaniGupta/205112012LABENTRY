namespace Lab_Entry_Project
{
    partial class AACADEMIC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DEP = new System.Windows.Forms.Label();
            this.DEPT = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.AID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DEP);
            this.groupBox1.Controls.Add(this.DEPT);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.AID);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(34, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 264);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRATION_FORM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "ADMIN_DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DEP
            // 
            this.DEP.AutoSize = true;
            this.DEP.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEP.ForeColor = System.Drawing.Color.Black;
            this.DEP.Location = new System.Drawing.Point(27, 167);
            this.DEP.Name = "DEP";
            this.DEP.Size = new System.Drawing.Size(54, 18);
            this.DEP.TabIndex = 30;
            this.DEP.Text = "DEPT.";
            // 
            // DEPT
            // 
            this.DEPT.Location = new System.Drawing.Point(136, 156);
            this.DEPT.Name = "DEPT";
            this.DEPT.Size = new System.Drawing.Size(100, 29);
            this.DEPT.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(136, 107);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 29);
            this.ID.TabIndex = 1;
            // 
            // AID
            // 
            this.AID.AutoSize = true;
            this.AID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AID.ForeColor = System.Drawing.Color.Black;
            this.AID.Location = new System.Drawing.Point(27, 107);
            this.AID.Name = "AID";
            this.AID.Size = new System.Drawing.Size(90, 18);
            this.AID.TabIndex = 1;
            this.AID.Text = "ADMIN ID.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(81, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AACADEMIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(342, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "AACADEMIC";
            this.Text = "AACADEMIC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DEP;
        private System.Windows.Forms.TextBox DEPT;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label AID;
        private System.Windows.Forms.Button button1;
    }
}