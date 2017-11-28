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

        public tester()
        {
            InitializeComponent();
            panel_testerAdd.Hide();
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_testerAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_testerMy_Click(object sender, EventArgs e)
        {
        }

        private void btn_testerAddBug_Click(object sender, EventArgs e)
        {
            panel_testerAdd.Show();
           
        }

        private void btn_testerNew_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30");
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
