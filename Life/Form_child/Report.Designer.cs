namespace Life.Form_child
{
    partial class Report
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_user = new System.Windows.Forms.Button();
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.btn_bank = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(251, 421);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(448, 108);
            this.reportViewer2.TabIndex = 0;
            // 
            // btn_user
            // 
            this.btn_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_user.Location = new System.Drawing.Point(238, 94);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(84, 33);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "User Manage";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Location = new System.Drawing.Point(227, 133);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.Size = new System.Drawing.Size(536, 282);
            this.dataGridView_report.TabIndex = 2;
            // 
            // btn_bank
            // 
            this.btn_bank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_bank.Location = new System.Drawing.Point(367, 94);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(84, 33);
            this.btn_bank.TabIndex = 3;
            this.btn_bank.Text = "Bank";
            this.btn_bank.UseVisualStyleBackColor = true;
            this.btn_bank.Click += new System.EventHandler(this.btn_bank_Click);
            // 
            // btn_in
            // 
            this.btn_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_in.Location = new System.Drawing.Point(507, 94);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(84, 33);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "Income";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exp.Location = new System.Drawing.Point(642, 94);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(84, 33);
            this.btn_exp.TabIndex = 5;
            this.btn_exp.Text = "Expense";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_bank);
            this.Controls.Add(this.dataGridView_report);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.Button btn_bank;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_exp;
    }
}