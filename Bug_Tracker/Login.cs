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
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_user_login_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select name From [user] where email = '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    tester tester = new tester(dt.Rows[0][0].ToString());
                    tester.Show();
                }
                else
                {
                    MessageBox.Show("Please Check Your e-mail or password");
                }

            }
        }

        private void btn_developer_login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select name From [developer] where email = '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.Hide();
                    developer developer = new developer("reggie");
                    developer.Show();
                if (dt.Rows.Count == 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("Please Check Your e-mail or password");
                }

            }
        }
    }
}
