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

            btn_checkBugs.BackColor = Color.White;
            btn_assignBug.BackColor = SystemColors.Info;
            btn_completeBug.BackColor = SystemColors.Info;
            btn_history.BackColor = SystemColors.Info;
            panel_checkBugs.Show();
            panel_assignBug.Hide();
            panel_completeBug.Hide();
            panel_history.Hide();
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

        private void btn_checkBugs_Click(object sender, EventArgs e)
        {
            btn_checkBugs.BackColor = Color.White;
            btn_assignBug.BackColor = SystemColors.Info;
            btn_completeBug.BackColor = SystemColors.Info;
            btn_history.BackColor = SystemColors.Info;
            panel_checkBugs.Show();
            panel_assignBug.Hide();
            panel_completeBug.Hide();
            panel_history.Hide();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_assignBug_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            btn_checkBugs.BackColor = SystemColors.Info;
            btn_assignBug.BackColor = Color.White;
            btn_completeBug.BackColor = SystemColors.Info;
            btn_history.BackColor = SystemColors.Info;
            panel_checkBugs.Hide();
            panel_assignBug.Show();
            panel_completeBug.Hide();
            panel_history.Hide();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where developer = '" + this.label3.Text + "' and state = 'Uploaded' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }

            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                var cell = row.Cells[0].Value;
                if (cell != null)
                {
                    comboBox3.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btn_selectToAssign_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string newcom = "UPDATE bug SET state = 'Assigned',process_date = '"+sqlFormattedDate+"' WHERE BugID = '" +comboBox3.Text+"'";
                    SqlCommand cmd = new SqlCommand(newcom, con);
                    cmd.ExecuteNonQuery();
                    load();
                }
            }
            else
            {

                MessageBox.Show("You can not assign nothing!");
            }
        }

        private void btn_completeBug_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            btn_checkBugs.BackColor = SystemColors.Info;
            btn_assignBug.BackColor = SystemColors.Info;
            btn_completeBug.BackColor = Color.White;
            btn_history.BackColor = SystemColors.Info;
            panel_checkBugs.Hide();
            panel_assignBug.Hide();
            panel_completeBug.Show();
            panel_history.Hide();
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where developer = '" + this.label3.Text + "' and state = 'Assigned' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                var cell = row.Cells[0].Value;
                if (cell != null)
                {
                    comboBox4.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string newcom = "insert into bug_description ( BugID, Class_file, Method, Source_code, Line_number, update_date) VALUES('" + comboBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + sqlFormattedDate + "')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
                string newcom1 = "UPDATE bug SET state = 'Completed',completed_date = '"+sqlFormattedDate+ "', update_date = '"+sqlFormattedDate+"' WHERE BugID = '" + comboBox4.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(newcom1, con);
                cmd1.ExecuteNonQuery();
                load();
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            panel_audit.Hide();
            btn_sourceCode.Hide();
            combo_audit.Items.Clear();
            btn_checkBugs.BackColor = SystemColors.Info;
            btn_assignBug.BackColor = SystemColors.Info;
            btn_completeBug.BackColor = SystemColors.Info;
            btn_history.BackColor = Color.White; 
            panel_checkBugs.Hide();
            panel_assignBug.Hide();
            panel_completeBug.Hide();
            panel_history.Show();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug_description INNER JOIN bug ON bug_description.BugID = bug.BugID where state = 'Completed' and developer = '"+label3.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                
            }
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select BugID FROM bug where state = 'Completed' and developer = '" + label3.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;

            }
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                var cell = row.Cells[0].Value;
                if (cell != null)
                {
                    combo_audit.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btn_audit_Click(object sender, EventArgs e)
        {
            if (combo_audit.Text != "")
            {
                panel_audit.Show();
                btn_sourceCode.Show();
                txt_sourceCode.Hide();
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand da = new SqlCommand("Select * FROM bug_description where BugID = '" + combo_audit.Text + "' and update_date = (select max(update_date) from bug_description)", con);
                    SqlDataReader dr = da.ExecuteReader();
                    if (dr.Read())
                    {
                        label13.Text = (dr["BugID"].ToString());
                        txt_classFile.Text = (dr["Class_file"].ToString());
                        txt_method.Text = (dr["Method"].ToString());
                        txt_lineNumber.Text = (dr["Line_number"].ToString());
                        txt_comment.Text = (dr["comment"].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a bug to audit!");
            }
            
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string newcom = "insert into bug_description (BugID,Class_file,Method,Line_number,comment,update_date) VALUES('" + label13.Text + "','" + txt_classFile.Text + "','" + txt_method.Text + "','" + txt_lineNumber.Text + "','" + txt_comment.Text + "','" + sqlFormattedDate + "')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
            }
            load();
        }

        private void btn_sourceCode_Click(object sender, EventArgs e)
        {
            panel_audit.Hide();
            txt_sourceCode.Show();
            if (combo_audit.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand da = new SqlCommand("Select * FROM bug_description where BugID = '" + combo_audit.Text + "' and update_date = (select max(update_date) from bug_description)", con);
                    SqlDataReader dr = da.ExecuteReader();
                    if (dr.Read())
                    {
                        txt_sourceCode.Text = (dr["Source_code"].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a bug !");
            }
        }
    }
}
