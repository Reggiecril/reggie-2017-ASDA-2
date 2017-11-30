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
    public partial class developer : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";
        
        public developer(string name)
        {
            InitializeComponent();
            load();
            this.label3.Text = name;

        }

        public void load()
        {
            this.comboBox1.Text = "All Bugs";
            this.comboBox2.Text = "All";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        { 
            Login login = new Login();
            login.Show();
            this.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                if (comboBox1.Text == "All Bugs" && comboBox2.Text == "All")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                
                else if (comboBox1.Text == "All Bugs" && comboBox2.Text != "All")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where state = '"+this.comboBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text != "All Bugs" && comboBox2.Text == "All")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where developer = '" + this.label3.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where developer = '" + this.label3.Text + "' and state = '" + this.comboBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                
            }
        }
    }
}
