namespace Life.Form_child
{
    partial class Expense
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
            this.dataGridView_expense = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveChange = new System.Windows.Forms.Button();
            this.txt_dateIn = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.Label();
            this.txt_expenseAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_des_E = new System.Windows.Forms.TextBox();
            this.txt_E_acc = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_am = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "EXPENSE";
            // 
            // dataGridView_expense
            // 
            this.dataGridView_expense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expense.Location = new System.Drawing.Point(216, 337);
            this.dataGridView_expense.Name = "dataGridView_expense";
            this.dataGridView_expense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_expense.Size = new System.Drawing.Size(572, 101);
            this.dataGridView_expense.TabIndex = 58;
            this.dataGridView_expense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_expense_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Location = new System.Drawing.Point(361, 283);
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
            this.btn_saveChange.Location = new System.Drawing.Point(450, 283);
            this.btn_saveChange.Name = "btn_saveChange";
            this.btn_saveChange.Size = new System.Drawing.Size(110, 33);
            this.btn_saveChange.TabIndex = 56;
            this.btn_saveChange.Text = "Save Change";
            this.btn_saveChange.UseVisualStyleBackColor = true;
            this.btn_saveChange.Click += new System.EventHandler(this.btn_saveChange_Click);
            // 
            // txt_dateIn
            // 
            this.txt_dateIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dateIn.AutoSize = true;
            this.txt_dateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateIn.Location = new System.Drawing.Point(303, 222);
            this.txt_dateIn.Name = "txt_dateIn";
            this.txt_dateIn.Size = new System.Drawing.Size(92, 18);
            this.txt_dateIn.TabIndex = 55;
            this.txt_dateIn.Text = "Date Income";
            // 
            // txt_des
            // 
            this.txt_des.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_des.AutoSize = true;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.Location = new System.Drawing.Point(659, 106);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(83, 18);
            this.txt_des.TabIndex = 54;
            this.txt_des.Text = "Description";
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_amount.AutoSize = true;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(321, 193);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(59, 18);
            this.txt_amount.TabIndex = 53;
            this.txt_amount.Text = "Amount";
            // 
            // txt_expenseAcc
            // 
            this.txt_expenseAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_expenseAcc.AutoSize = true;
            this.txt_expenseAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expenseAcc.Location = new System.Drawing.Point(283, 156);
            this.txt_expenseAcc.Name = "txt_expenseAcc";
            this.txt_expenseAcc.Size = new System.Drawing.Size(133, 18);
            this.txt_expenseAcc.TabIndex = 52;
            this.txt_expenseAcc.Text = "Expense from Acc ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID";
            // 
            // txt_des_E
            // 
            this.txt_des_E.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_des_E.Location = new System.Drawing.Point(625, 128);
            this.txt_des_E.Multiline = true;
            this.txt_des_E.Name = "txt_des_E";
            this.txt_des_E.Size = new System.Drawing.Size(163, 112);
            this.txt_des_E.TabIndex = 49;
            // 
            // txt_E_acc
            // 
            this.txt_E_acc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_E_acc.Location = new System.Drawing.Point(422, 143);
            this.txt_E_acc.Multiline = true;
            this.txt_E_acc.Name = "txt_E_acc";
            this.txt_E_acc.Size = new System.Drawing.Size(163, 31);
            this.txt_E_acc.TabIndex = 47;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.Location = new System.Drawing.Point(422, 106);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(163, 31);
            this.txt_id.TabIndex = 46;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(577, 283);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 33);
            this.btn_delete.TabIndex = 45;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_am
            // 
            this.txt_am.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_am.Location = new System.Drawing.Point(422, 180);
            this.txt_am.Multiline = true;
            this.txt_am.Name = "txt_am";
            this.txt_am.Size = new System.Drawing.Size(163, 31);
            this.txt_am.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(401, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 60;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_expense);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_saveChange);
            this.Controls.Add(this.txt_dateIn);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_expenseAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_des_E);
            this.Controls.Add(this.txt_E_acc);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_am);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_expense;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveChange;
        private System.Windows.Forms.Label txt_dateIn;
        private System.Windows.Forms.Label txt_des;
        private System.Windows.Forms.Label txt_amount;
        private System.Windows.Forms.Label txt_expenseAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_des_E;
        private System.Windows.Forms.TextBox txt_E_acc;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_am;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}