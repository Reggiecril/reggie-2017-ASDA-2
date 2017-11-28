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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_user_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            tester tester = new tester();
            tester.Show();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) From [user] where EMAIL = '" + textBox1.Text + "' and PASSWORD= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
            }
            else
            {
                MessageBox.Show("Please Check Your e-mail or password");
            }

           
        }

        private void btn_developer_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) From [developer] where EMAIL = '" + textBox1.Text + "' and PASSWORD= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                developer developer = new developer();
                developer.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your e-mail or password");
            }
        }
    }
}
