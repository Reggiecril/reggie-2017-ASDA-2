using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bug_Tracker
{
    public partial class tester : Form
    {
       
        
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";
        public tester()
        {
            
            InitializeComponent();
            panel_allTestedBug.Show();
            panel_testerAdd.Hide();
            panel_myTestedBug.Hide();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagv_allTestedBug.DataSource = dt;
            }


        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_testerAll_Click(object sender, EventArgs e)
        {
            btn_testerAll.BackColor = Color.White;
            btn_testerAddBug.BackColor = Color.Silver;
            btn_testerMy.BackColor = Color.Silver;
            panel_testerAdd.Hide();
            panel_allTestedBug.Show();
            panel_myTestedBug.Hide();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagv_allTestedBug.DataSource = dt;
            }
        }

        private void btn_testerMy_Click(object sender, EventArgs e)
        {
            btn_testerAll.BackColor = Color.Silver;
            btn_testerAddBug.BackColor = Color.Silver;
            btn_testerMy.BackColor = Color.White;
            panel_testerAdd.Hide();
            panel_allTestedBug.Hide();
            panel_myTestedBug.Show();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagv_myTestedBug.DataSource = dt;
            }
        }

        private void btn_testerAddBug_Click(object sender, EventArgs e)
        {
            btn_testerAll.BackColor = Color.Silver;
            btn_testerAddBug.BackColor = Color.White;
            btn_testerMy.BackColor = Color.Silver;
            panel_testerAdd.Show();
            panel_allTestedBug.Hide();
            panel_myTestedBug.Hide();

        }

        private void btn_testerNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string newcom = "insert into bug (project,bugTitle,cause,bugSummary,priority,state,start_date) VALUES('" + txt_project + "','" + txt_bugTitle + "','" + txt_cause + "','" + txt_bugSummary + "','" + cmb_priority + "','" + cmb_state + "','" + sqlFormattedDate + "')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
                panel_testerAdd.Hide();
            }
        }
    }
}
