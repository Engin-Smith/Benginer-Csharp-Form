namespace Life
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo_home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_expense = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_bank = new System.Windows.Forms.Button();
            this.btn_userM = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_desktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_desktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.logo_home);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(175, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 72);
            this.panel3.TabIndex = 4;
            // 
            // logo_home
            // 
            this.logo_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_home.AutoSize = true;
            this.logo_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_home.ForeColor = System.Drawing.Color.White;
            this.logo_home.Location = new System.Drawing.Point(286, 24);
            this.logo_home.Name = "logo_home";
            this.logo_home.Size = new System.Drawing.Size(99, 31);
            this.logo_home.TabIndex = 0;
            this.logo_home.Text = "HOME";
            this.logo_home.Click += new System.EventHandler(this.logo_home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btn_expense);
            this.panel1.Controls.Add(this.btn_income);
            this.panel1.Controls.Add(this.btn_bank);
            this.panel1.Controls.Add(this.btn_userM);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 550);
            this.panel1.TabIndex = 3;
            // 
            // btn_report
            // 
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(0, 302);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(175, 44);
            this.btn_report.TabIndex = 7;
            this.btn_report.Text = "REPORT";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_expense
            // 
            this.btn_expense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_expense.FlatAppearance.BorderSize = 0;
            this.btn_expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expense.ForeColor = System.Drawing.Color.White;
            this.btn_expense.Location = new System.Drawing.Point(0, 258);
            this.btn_expense.Name = "btn_expense";
            this.btn_expense.Size = new System.Drawing.Size(175, 44);
            this.btn_expense.TabIndex = 6;
            this.btn_expense.Text = "EXPENSE";
            this.btn_expense.UseVisualStyleBackColor = true;
            this.btn_expense.Click += new System.EventHandler(this.btn_expense_Click);
            // 
            // btn_income
            // 
            this.btn_income.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_income.FlatAppearance.BorderSize = 0;
            this.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income.ForeColor = System.Drawing.Color.White;
            this.btn_income.Location = new System.Drawing.Point(0, 214);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(175, 44);
            this.btn_income.TabIndex = 5;
            this.btn_income.Text = "INCOME";
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_bank
            // 
            this.btn_bank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bank.FlatAppearance.BorderSize = 0;
            this.btn_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bank.ForeColor = System.Drawing.Color.White;
            this.btn_bank.Location = new System.Drawing.Point(0, 170);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(175, 44);
            this.btn_bank.TabIndex = 4;
            this.btn_bank.Text = "BANK";
            this.btn_bank.UseVisualStyleBackColor = true;
            this.btn_bank.Click += new System.EventHandler(this.btn_bank_Click);
            // 
            // btn_userM
            // 
            this.btn_userM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_userM.FlatAppearance.BorderSize = 0;
            this.btn_userM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userM.ForeColor = System.Drawing.Color.White;
            this.btn_userM.Location = new System.Drawing.Point(0, 126);
            this.btn_userM.Name = "btn_userM";
            this.btn_userM.Size = new System.Drawing.Size(175, 44);
            this.btn_userM.TabIndex = 3;
            this.btn_userM.Text = "USER MANAGE";
            this.btn_userM.UseVisualStyleBackColor = true;
            this.btn_userM.Click += new System.EventHandler(this.btn_userM_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 82);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(175, 44);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 82);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENGIN";
            // 
            // pnl_desktop
            // 
            this.pnl_desktop.Controls.Add(this.pictureBox1);
            this.pnl_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_desktop.Location = new System.Drawing.Point(0, 0);
            this.pnl_desktop.Name = "pnl_desktop";
            this.pnl_desktop.Size = new System.Drawing.Size(900, 550);
            this.pnl_desktop.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Life.Properties.Resources.khlogo;
            this.pictureBox1.Location = new System.Drawing.Point(356, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_desktop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_desktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label logo_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_expense;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_bank;
        private System.Windows.Forms.Button btn_userM;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_desktop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

