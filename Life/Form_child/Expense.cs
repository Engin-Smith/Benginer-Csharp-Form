using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.Form_child
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
        public int userID;

        private void Expense_Load(object sender, EventArgs e)
        {
            Expenserecord();
        }
        private void Expenserecord()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_expense ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView_expense.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_expense (expense_id, exp_from_acc , amount, date, description)" + "VALUES (@expense_id, @exp_from_acc , @amount, @date, @description) ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@expense_id", txt_id.Text);
                cmd.Parameters.AddWithValue("@exp_from_acc", txt_E_acc.Text);
                cmd.Parameters.AddWithValue("@amount", txt_am.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@description", txt_des_E.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expenserecord();
            }
        }
        private bool isValid()
        {
            //throw new NotImplementedException();
            if (txt_E_acc.Text == string.Empty)
            {
                MessageBox.Show("you name is Income ACC", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView_expense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = Convert.ToInt32(dataGridView_expense.SelectedRows[0].Cells[0].Value);
            txt_E_acc.Text= dataGridView_expense.SelectedRows[0].Cells[1].Value.ToString();
            txt_am.Text = dataGridView_expense.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView_expense.SelectedRows[0].Cells[3].Value.ToString();
            txt_des_E.Text = dataGridView_expense.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void btn_saveChange_Click(object sender, EventArgs e)
        {

            if (userID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_expense SET expense_id = @expense_id , exp_from_acc= @exp_from_acc, amount= @amount, date= @date, description=@description WHERE expense_id =@expense_id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@expense_id", txt_id.Text);
                cmd.Parameters.AddWithValue("@exp_from_acc", txt_E_acc.Text);
                cmd.Parameters.AddWithValue("@amount", txt_am.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@description", txt_des_E.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord Update is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expenserecord();

            }
            else
            {
                MessageBox.Show(" Please select to update ", " Select? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (userID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_expense WHERE expense_id =@userID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@userID", this.userID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Rrcord Delete is successfully  ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expenserecord();

            }
            else
            {
                MessageBox.Show(" Please select to delete ", " Select? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
