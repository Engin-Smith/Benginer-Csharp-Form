namespace Life.Form_child
{
    partial class U_manag
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
            this.dataGridView_user_manage = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_addres = new System.Windows.Forms.TextBox();
            this.txt_userN = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_fullN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user_manage)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "USER MANAGE";
            // 
            // dataGridView_user_manage
            // 
            this.dataGridView_user_manage.AllowUserToAddRows = false;
            this.dataGridView_user_manage.AllowUserToDeleteRows = false;
            this.dataGridView_user_manage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_user_manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user_manage.Location = new System.Drawing.Point(219, 402);
            this.dataGridView_user_manage.Name = "dataGridView_user_manage";
            this.dataGridView_user_manage.ReadOnly = true;
            this.dataGridView_user_manage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_user_manage.Size = new System.Drawing.Size(610, 125);
            this.dataGridView_user_manage.TabIndex = 43;
            this.dataGridView_user_manage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_manage_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Location = new System.Drawing.Point(392, 365);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 33);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveChange
            // 
            this.btn_saveChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveChange.Location = new System.Drawing.Point(481, 365);
            this.btn_saveChange.Name = "btn_saveChange";
            this.btn_saveChange.Size = new System.Drawing.Size(110, 33);
            this.btn_saveChange.TabIndex = 41;
            this.btn_saveChange.Text = "Save Change";
            this.btn_saveChange.UseVisualStyleBackColor = true;
            this.btn_saveChange.Click += new System.EventHandler(this.btn_saveChange_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "User Name";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone.Location = new System.Drawing.Point(519, 328);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(163, 31);
            this.txt_phone.TabIndex = 35;
            // 
            // txt_mail
            // 
            this.txt_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mail.Location = new System.Drawing.Point(519, 291);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(163, 31);
            this.txt_mail.TabIndex = 34;
            // 
            // txt_addres
            // 
            this.txt_addres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_addres.Location = new System.Drawing.Point(519, 254);
            this.txt_addres.Multiline = true;
            this.txt_addres.Name = "txt_addres";
            this.txt_addres.Size = new System.Drawing.Size(163, 31);
            this.txt_addres.TabIndex = 32;
            // 
            // txt_userN
            // 
            this.txt_userN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_userN.Location = new System.Drawing.Point(519, 180);
            this.txt_userN.Multiline = true;
            this.txt_userN.Name = "txt_userN";
            this.txt_userN.Size = new System.Drawing.Size(163, 31);
            this.txt_userN.TabIndex = 31;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(608, 365);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 33);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_fullN
            // 
            this.txt_fullN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullN.Location = new System.Drawing.Point(519, 217);
            this.txt_fullN.Multiline = true;
            this.txt_fullN.Name = "txt_fullN";
            this.txt_fullN.Size = new System.Drawing.Size(163, 31);
            this.txt_fullN.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Location = new System.Drawing.Point(519, 143);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(163, 31);
            this.txt_ID.TabIndex = 45;
            // 
            // U_manag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_user_manage);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_saveChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_addres);
            this.Controls.Add(this.txt_userN);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_fullN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "U_manag";
            this.Text = "U_manag";
            this.Load += new System.EventHandler(this.U_manag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user_manage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_user_manage;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_addres;
        private System.Windows.Forms.TextBox txt_userN;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_fullN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ID;
    }
}