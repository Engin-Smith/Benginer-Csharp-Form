using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.Form_child
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
            {
                this.Hide();
                //Form1 m = new Form1();
                //m.Show();
                //  if (txtuser.Text == "smith" && txtpass.Text == "2022")
                //{
                //  new Home().Show();
                //this.Hide();
                //}
                //else
                //{
                //  MessageBox.Show("The User or Password is incorrect, try again");
                //txtuser.Clear();
                //txtpass.Clear();
                //txtuser.Focus();

                // code from teacher
                string user = txtuser.Text;
                string pass = txtpass.Text;
                SqlConnection con;
                string sql = null;
                con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");


                if (user == "" || pass == "")
                {
                    MessageBox.Show("Empty user or password");
                }
                else
                {
                    // create connection 
                    con.Open();
                    sql = "SELECT * FROM tbl_login WHERE username='" + user + "' and password='" + pass + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "user");
                    if (ds.Tables["user"].Rows.Count > 0)
                    {
                        //MessageBox.Show("Login successfully");
                        Form1 fmain = new Form1();
                        fmain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user and password");
                    }
                    con.Close();
                }

            }

        }
    }
}
