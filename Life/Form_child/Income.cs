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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
        public int userID;
        private void Income_Load(object sender, EventArgs e)
        {
            Incomerecord();
        }
        private void Incomerecord()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_income ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView_incom.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_income (income_id, in_acc , in_amount, in_date, in_description)" + "VALUES (@inid, @inacc , @inam, @indate, @indes) ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@inid", txt_id.Text);
                cmd.Parameters.AddWithValue("@inacc", txt_in_acc.Text);
                cmd.Parameters.AddWithValue("@inam", txt_in_amo.Text);
                cmd.Parameters.AddWithValue("@indate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@indes", txt_des.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Incomerecord();
            }
        }
        private bool isValid()
        {
            //throw new NotImplementedException();
            if (txt_intoAcc.Text == string.Empty)
            {
                MessageBox.Show("you name is Income ACC", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView_incom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = Convert.ToInt32(dataGridView_incom.SelectedRows[0].Cells[0].Value);
            txt_in_acc.Text = dataGridView_incom.SelectedRows[0].Cells[1].Value.ToString();
            txt_in_amo.Text = dataGridView_incom.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView_incom.SelectedRows[0].Cells[3].Value.ToString();
            txt_des.Text = dataGridView_incom.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void btn_saveChange_Click(object sender, EventArgs e)
        {
            if (userID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_income SET income_id = @in_id, in_acc=@in_acc, in_amount= @in_am, in_date= @in_date, in_description=@in_des WHERE income_id =@in_id", con);
                //cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@in_id", txt_id.Text);
                cmd.Parameters.AddWithValue("@in_acc", txt_in_acc.Text);
                cmd.Parameters.AddWithValue("@in_am", txt_in_amo.Text);
                cmd.Parameters.AddWithValue("@in_date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@in_des", txt_des.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord Update is successfully saved in the database Income ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Incomerecord();

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
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_income WHERE income_id=@in_id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@in_id", this.userID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Rrcord Delete is successfully From table Income  ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Incomerecord();

            }
            else
            {
                MessageBox.Show(" Please select to delete ", " Select? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
