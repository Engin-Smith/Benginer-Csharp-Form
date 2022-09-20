namespace Life.Form_child
{
    partial class Bank
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
            this.label6 = new System.Windows.Forms.Label();
            this.Bank_dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveChange = new System.Windows.Forms.Button();
            this.txt_bl = new System.Windows.Forms.Label();
            this.txt_accnum = new System.Windows.Forms.Label();
            this.txt_accname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_accNa = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_acc_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "BANKING";
            // 
            // Bank_dataGridView
            // 
            this.Bank_dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bank_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bank_dataGridView.Location = new System.Drawing.Point(216, 327);
            this.Bank_dataGridView.Name = "Bank_dataGridView";
            this.Bank_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Bank_dataGridView.Size = new System.Drawing.Size(572, 111);
            this.Bank_dataGridView.TabIndex = 58;
            this.Bank_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bank_dataGridView_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Location = new System.Drawing.Point(359, 278);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 33);
            this.btn_save.TabIndex = 57;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveChange
            // 
            this.btn_saveChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveChange.Location = new System.Drawing.Point(448, 278);
            this.btn_saveChange.Name = "btn_saveChange";
            this.btn_saveChange.Size = new System.Drawing.Size(110, 33);
            this.btn_saveChange.TabIndex = 56;
            this.btn_saveChange.Text = "Save Change";
            this.btn_saveChange.UseVisualStyleBackColor = true;
            this.btn_saveChange.Click += new System.EventHandler(this.btn_saveChange_Click);
            // 
            // txt_bl
            // 
            this.txt_bl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_bl.AutoSize = true;
            this.txt_bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bl.Location = new System.Drawing.Point(401, 235);
            this.txt_bl.Name = "txt_bl";
            this.txt_bl.Size = new System.Drawing.Size(61, 18);
            this.txt_bl.TabIndex = 54;
            this.txt_bl.Text = "Balance";
            // 
            // txt_accnum
            // 
            this.txt_accnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_accnum.AutoSize = true;
            this.txt_accnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accnum.Location = new System.Drawing.Point(386, 198);
            this.txt_accnum.Name = "txt_accnum";
            this.txt_accnum.Size = new System.Drawing.Size(96, 18);
            this.txt_accnum.TabIndex = 53;
            this.txt_accnum.Text = "ACC Number";
            // 
            // txt_accname
            // 
            this.txt_accname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_accname.AutoSize = true;
            this.txt_accname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accname.Location = new System.Drawing.Point(386, 161);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.Size = new System.Drawing.Size(83, 18);
            this.txt_accname.TabIndex = 52;
            this.txt_accname.Text = "ACC Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID";
            // 
            // txt_balance
            // 
            this.txt_balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_balance.Location = new System.Drawing.Point(483, 222);
            this.txt_balance.Multiline = true;
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(163, 31);
            this.txt_balance.TabIndex = 49;
            // 
            // txt_accNa
            // 
            this.txt_accNa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_accNa.Location = new System.Drawing.Point(483, 148);
            this.txt_accNa.Multiline = true;
            this.txt_accNa.Name = "txt_accNa";
            this.txt_accNa.Size = new System.Drawing.Size(163, 31);
            this.txt_accNa.TabIndex = 47;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Location = new System.Drawing.Point(483, 111);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(163, 31);
            this.txt_ID.TabIndex = 46;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(575, 278);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 33);
            this.btn_delete.TabIndex = 45;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_acc_num
            // 
            this.txt_acc_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_acc_num.Location = new System.Drawing.Point(483, 185);
            this.txt_acc_num.Multiline = true;
            this.txt_acc_num.Name = "txt_acc_num";
            this.txt_acc_num.Size = new System.Drawing.Size(163, 31);
            this.txt_acc_num.TabIndex = 48;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bank_dataGridView);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_saveChange);
            this.Controls.Add(this.txt_bl);
            this.Controls.Add(this.txt_accnum);
            this.Controls.Add(this.txt_accname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_accNa);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_acc_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bank_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Bank_dataGridView;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveChange;
        private System.Windows.Forms.Label txt_bl;
        private System.Windows.Forms.Label txt_accnum;
        private System.Windows.Forms.Label txt_accname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_accNa;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_acc_num;
    }
}