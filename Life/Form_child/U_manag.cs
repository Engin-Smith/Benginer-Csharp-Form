using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.Form_child
{
    public partial class U_manag : Form
    {
        public U_manag()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
        public int userID;

        private void Getrecord()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_Umanage ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView_user_manage.DataSource = dt;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            /*SqlConnection con;
            string sql = null;
           
            con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            // Create the InsertCommand.
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO tbl_Umanage (ID, userName,fullName,address,email,phoneNumber) " +
                "VALUES (@ID, @userName, @fullName, @address, @email, @phoneNumber)", con);
            // Add the parameters for the InsertCommand.
            cmd.Parameters.Add("@ID", SqlDbType.NChar, 5, "ID");
            cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 40, "userName");*/
            // get uer
            /*string sql = null;
            SqlConnection con;
            con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            sql = "SELECT * FROM tbl_Umanage";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            //transfer data
            da.Fill(ds, "user");
            dataGridView_user_manage.DataSource = ds.Tables["user"].DefaultView;*/

            //input and get
            /*string txtid = txt_Uid.Text;
            string txtuser = txt_userN.Text;
            string txtfull = txt_fullN.Text;
            string txtadree = txt_addres.Text;
            string txtmail = txt_mail.Text;
            string txtphoneNo = txt_phone.Text;
            string queryString = null;
            SqlConnection con;
            con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            queryString = "INSERT INTO tbl_Umanage (ID,userName,FullName,address,email,phoneNumber)";
            SqlCommand commend = new SqlCommand(queryString,con);
            commend.ExecuteNonQuery();
            MessageBox.Show("Record has been save");
            con.Close();*/
            //getUser();

            //input and get
            /*string txtid = txt_Uid.Text;
            string txtuser = txt_userN.Text;
            string txtfull = txt_fullN.Text;
            string txtadree = txt_addres.Text;
            string txtmail = txt_mail.Text;
            string txtphoneNo = txt_phone.Text;
            string queryString = null;
            string sql;
            SqlConnection con;
            con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            queryString = "INSERT INTO tbl_Umanage (ID,userName,FullName,address,email,phoneNumber)";
          
            sql = "INSERT INTO tbl_Umanage WHERE username='" + txtid + "',fullName='" + txtid +"";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "user");*/

            /*if (isValid()) {
                SqlCommand cmd new SqlCommand(" INSERT INTO tbl_Umanage VALUES ( @name , @FatherName , @moll , Address , @Mobile ) ", con);
                cmd.CommandType CommandType.Text;

                cmd.Parameters.AddwithValue(" @ nano ", txtStudentName.Text);
                cmd.Parameters.AddwithValue(" Fatherflame ", txtFatherName.Text) ;
                cmd.Parameters.AddwlthValue(" @ Roll ", txtRollNumber.Text);
                cmd.Parameters.AddwithValue(" Address ", txtRollNumber.Text);
                cmd.Parameters.Addwithvalue(" mobile ", txtMobile, Text) ;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                RessageBox.Show(" New student is successfully saved in the database ", " Saved ", MessagelloxButtons.OK, MessageBoxicon.Information);
                GetStudentsRecord();
            }*/

            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Umanage (userID, userName , fullName, address, email, phoneNumber )" + "VALUES (@userID, @userName , @fullName, @address, @email, @phoneNumber ) ", con);
                //cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@userID", txt_ID.Text);
                cmd.Parameters.AddWithValue("@userName", txt_userN.Text);
                cmd.Parameters.AddWithValue("@fullName", txt_fullN.Text);
                cmd.Parameters.AddWithValue("@address", txt_addres.Text);
                cmd.Parameters.AddWithValue("@email", txt_mail.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txt_phone.Text);


                con.Open();
                 cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Getrecord();
            }

        }

        private bool isValid()
        {
            //throw new NotImplementedException();
            if (txt_userN.Text == string.Empty)
            {
                MessageBox.Show("you name is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void U_manag_Load(object sender, EventArgs e)
        {
            Getrecord();
        }

        private void dataGridView_user_manage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = Convert.ToInt32(dataGridView_user_manage.SelectedRows[0].Cells[0].Value);
            txt_userN.Text= dataGridView_user_manage.SelectedRows[0].Cells[1].Value.ToString();
            txt_fullN.Text = dataGridView_user_manage.SelectedRows[0].Cells[2].Value.ToString();
            txt_addres.Text = dataGridView_user_manage.SelectedRows[0].Cells[3].Value.ToString();
            txt_mail.Text = dataGridView_user_manage.SelectedRows[0].Cells[4].Value.ToString();
            txt_phone.Text = dataGridView_user_manage.SelectedRows[0].Cells[5].Value.ToString();
            txt_ID.Text = dataGridView_user_manage.SelectedRows[0].Cells[6].Value.ToString(); 
        }

        private void btn_saveChange_Click(object sender, EventArgs e)
        {
            if (userID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_Umanage SET userName = @userName , fullName=@fullName, address = @address, email= @email, phoneNumber=@phoneNumber WHERE userID =@userID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@userID", txt_ID.Text);
                cmd.Parameters.AddWithValue("@userName", txt_userN.Text);
                cmd.Parameters.AddWithValue("@fullName", txt_fullN.Text);
                cmd.Parameters.AddWithValue("@address", txt_addres.Text);
                cmd.Parameters.AddWithValue("@email", txt_mail.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txt_phone.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" New Rrcord Update is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Getrecord();
                
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
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Umanage WHERE userID =@userID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@userID", this.userID);    


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Rrcord Delete is successfully  ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Getrecord();

            }
            else
            {
                MessageBox.Show(" Please select to delete ", " Select? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
