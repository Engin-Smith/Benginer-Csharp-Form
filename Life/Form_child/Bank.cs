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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
        public int bankID;

        private void Bankrecord()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_bank ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            Bank_dataGridView.DataSource = dt;
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            Bankrecord();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_bank (id,acc_name, acc_num,balance )" + "VALUES (@id,@acc_name, @acc_num , @balance ) ", con);
                //cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@acc_name", txt_accNa.Text);
                cmd.Parameters.AddWithValue("@acc_num", txt_acc_num.Text);
                cmd.Parameters.AddWithValue("@balance", txt_balance.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bankrecord();
            }
        }
        private bool isValid()
        {
            //throw new NotImplementedException();
            if (txt_accNa.Text == string.Empty)
            {
                MessageBox.Show("you name is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Bank_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bankID = Convert.ToInt32(Bank_dataGridView.SelectedRows[0].Cells[0].Value);
            txt_accNa.Text = Bank_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txt_acc_num.Text = Bank_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txt_balance.Text = Bank_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_saveChange_Click(object sender, EventArgs e)
        {
            if (bankID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_bank SET acc_name = @acc_name , acc_num=@acc_num, balance = @balance WHERE ID =@ID", con);
                //cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@ID", txt_ID.Text);
                cmd.Parameters.Add("@acc_name", txt_accNa.Text);
                cmd.Parameters.AddWithValue("@acc_num", txt_accnum.Text);
                cmd.Parameters.AddWithValue("@balance", txt_balance.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Bank Rrcord Update is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bankrecord();

            }
            else
            {
                MessageBox.Show(" Please select to update ", " Select? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (bankID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_bank WHERE ID =@ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.bankID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Rrcord Delete is successfully  ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bankrecord();

            }
            else
            {
                MessageBox.Show(" Please select to delete ", " Select? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
