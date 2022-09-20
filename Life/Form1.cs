using Life.Form_child;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_userM_Click(object sender, EventArgs e)
        {
            pnl_desktop.Controls.Clear();// Remove all form in panel 
            U_manag objForm1 = new U_manag();
            objForm1.TopLevel = false;
            pnl_desktop.Controls.Add(objForm1); // add form into panel 

            objForm1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm1.Dock = DockStyle.Fill;

            objForm1.Show();
        }

        private void btn_bank_Click(object sender, EventArgs e)
        {
            pnl_desktop.Controls.Clear();// Remove all form in panel 
            Bank objForm2 = new Bank();
            objForm2.TopLevel = false;
            pnl_desktop.Controls.Add(objForm2); // add form into panel 

            objForm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm2.Dock = DockStyle.Fill;

            objForm2.Show();
        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            pnl_desktop.Controls.Clear();// Remove all form in panel 
            Income objForm3 = new Income();
            objForm3.TopLevel = false;
            pnl_desktop.Controls.Add(objForm3); // add form into panel 

            objForm3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm3.Dock = DockStyle.Fill;

            objForm3.Show();
        }

        private void btn_expense_Click(object sender, EventArgs e)
        {
            pnl_desktop.Controls.Clear();// Remove all form in panel 
            Expense objForm4 = new Expense();
            objForm4.TopLevel = false;
            pnl_desktop.Controls.Add(objForm4); // add form into panel 

            objForm4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm4.Dock = DockStyle.Fill;

            objForm4.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            pnl_desktop.Controls.Clear();// Remove all form in panel 
            Report objForm5 = new Report();
            objForm5.TopLevel = false;
            pnl_desktop.Controls.Add(objForm5); // add form into panel 

            objForm5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm5.Dock = DockStyle.Fill;

            objForm5.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void logo_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
