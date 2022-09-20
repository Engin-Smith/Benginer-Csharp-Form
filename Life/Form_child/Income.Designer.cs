namespace Life.Form_child
{
    partial class Income
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
            this.dataGridView_incom = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveChange = new System.Windows.Forms.Button();
            this.txt_dateIn = new System.Windows.Forms.Label();
            this.txt_descript = new System.Windows.Forms.Label();
            this.txt_inamount = new System.Windows.Forms.Label();
            this.txt_intoAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.txt_in_acc = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_in_amo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_incom)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "INCOME";
            // 
            // dataGridView_incom
            // 
            this.dataGridView_incom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_incom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_incom.Location = new System.Drawing.Point(216, 337);
            this.dataGridView_incom.Name = "dataGridView_incom";
            this.dataGridView_incom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_incom.Size = new System.Drawing.Size(572, 101);
            this.dataGridView_incom.TabIndex = 58;
            this.dataGridView_incom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_incom_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Location = new System.Drawing.Point(362, 298);
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
            this.btn_saveChange.Location = new System.Drawing.Point(451, 298);
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
            this.txt_dateIn.Location = new System.Drawing.Point(230, 231);
            this.txt_dateIn.Name = "txt_dateIn";
            this.txt_dateIn.Size = new System.Drawing.Size(92, 18);
            this.txt_dateIn.TabIndex = 55;
            this.txt_dateIn.Text = "Date Income";
            // 
            // txt_descript
            // 
            this.txt_descript.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descript.AutoSize = true;
            this.txt_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descript.Location = new System.Drawing.Point(624, 122);
            this.txt_descript.Name = "txt_descript";
            this.txt_descript.Size = new System.Drawing.Size(83, 18);
            this.txt_descript.TabIndex = 54;
            this.txt_descript.Text = "Description";
            // 
            // txt_inamount
            // 
            this.txt_inamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_inamount.AutoSize = true;
            this.txt_inamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inamount.Location = new System.Drawing.Point(230, 196);
            this.txt_inamount.Name = "txt_inamount";
            this.txt_inamount.Size = new System.Drawing.Size(112, 18);
            this.txt_inamount.TabIndex = 53;
            this.txt_inamount.Text = "Income Amount";
            // 
            // txt_intoAcc
            // 
            this.txt_intoAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_intoAcc.AutoSize = true;
            this.txt_intoAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intoAcc.Location = new System.Drawing.Point(230, 158);
            this.txt_intoAcc.Name = "txt_intoAcc";
            this.txt_intoAcc.Size = new System.Drawing.Size(109, 18);
            this.txt_intoAcc.TabIndex = 52;
            this.txt_intoAcc.Text = "Income to ACC";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID";
            // 
            // txt_des
            // 
            this.txt_des.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_des.Location = new System.Drawing.Point(568, 159);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(203, 115);
            this.txt_des.TabIndex = 49;
            // 
            // txt_in_acc
            // 
            this.txt_in_acc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_in_acc.Location = new System.Drawing.Point(362, 146);
            this.txt_in_acc.Multiline = true;
            this.txt_in_acc.Name = "txt_in_acc";
            this.txt_in_acc.Size = new System.Drawing.Size(163, 31);
            this.txt_in_acc.TabIndex = 47;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.Location = new System.Drawing.Point(362, 109);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(163, 31);
            this.txt_id.TabIndex = 46;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(578, 298);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 33);
            this.btn_delete.TabIndex = 45;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_in_amo
            // 
            this.txt_in_amo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_in_amo.Location = new System.Drawing.Point(362, 183);
            this.txt_in_amo.Multiline = true;
            this.txt_in_amo.Name = "txt_in_amo";
            this.txt_in_amo.Size = new System.Drawing.Size(163, 31);
            this.txt_in_amo.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_incom);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_saveChange);
            this.Controls.Add(this.txt_dateIn);
            this.Controls.Add(this.txt_descript);
            this.Controls.Add(this.txt_inamount);
            this.Controls.Add(this.txt_intoAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_in_acc);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_in_amo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_incom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_incom;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveChange;
        private System.Windows.Forms.Label txt_dateIn;
        private System.Windows.Forms.Label txt_descript;
        private System.Windows.Forms.Label txt_inamount;
        private System.Windows.Forms.Label txt_intoAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox txt_in_acc;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_in_amo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}