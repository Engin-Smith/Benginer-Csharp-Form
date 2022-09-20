using Life.Form_child.DataSet1TableAdapters;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
using DataSet = System.Data.DataSet;

namespace Life.Form_child
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");

        private void Report_Load(object sender, EventArgs e)
        {
            user();

            //this.reportViewer2.RefreshReport();
        }
        private void user()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_Umanage ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView_report.DataSource = dt;
        }
        private void bank()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_bank ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView_report.DataSource = dt;
        }
        private void income()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_income ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView_report.DataSource = dt;
        }
        private void exp()
        {
            SqlCommand cmd = new SqlCommand(" SELECT*FROM tbl_expense ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView_report.DataSource = dt;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            user();
        }

        private void btn_bank_Click(object sender, EventArgs e)
        {
            bank();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            income();   
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            exp();
        }


        /*private void btn_L_Click(object sender, EventArgs e)
        {

            ReportDataSource M = new ReportDataSource("tbl_Umanage", userM());
            ReportDataSource B = new ReportDataSource("tbl_bank", bank());
            ReportDataSource I = new ReportDataSource("tbl_income", income());
            ReportDataSource E = new ReportDataSource("tbl_expense", expense());

            reportViewer2.LocalReport.ReportPath = "D:\\virsual studio code\\Life\\Life\\Form_child\\Report1.rdlc";
            reportViewer2.LocalReport.DataSources.Add(M);
            reportViewer2.LocalReport.DataSources.Add(B);
            reportViewer2.LocalReport.DataSources.Add(I);
            reportViewer2.LocalReport.DataSources.Add(E);
            this.reportViewer2.RefreshReport();
        }
        private DataTable userM()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT*FROM tbl_Umanage",con);

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable bank()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT*FROM tbl_bank", con);

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable income()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT*FROM tbl_income", con);

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable expense()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6LOEMH4\SQLEXPRESS;Initial Catalog=life_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT*FROM tbl_expense", con);

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }*/
    }
}
