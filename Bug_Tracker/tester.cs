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
   
    /// <summary>
    /// This class is function for tester form
    /// <list type="bullet">
    /// <item>
    /// <description>All Tested Bug</description>
    /// </item>
    /// <item>
    /// <description>My Tested Bug</description>
    /// </item>
    /// <item>
    /// <description>Add Bug</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class tester : Form
    {
        /// <summary>
        /// Database Path
        /// </summary>
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";
        /// <summary>
        /// Display first page when people load 
        /// </summary>
        /// <param name="TesterName">name</param>
        public tester(string username)
        {

            InitializeComponent();
            this.label_username.Text = username;
            load();
            reminder();


        }
        public void reminder()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand da = new SqlCommand("Select * FROM bug Where completed_date = (Select MAX(completed_date) FROM bug) and tester = '"+label_username+"'", con);
                SqlDataReader dr = da.ExecuteReader();
                if (dr.Read())
                {
                    label26.Text = (dr["developer"].ToString());
                    label28.Text = (dr["completed_date"].ToString());
                }
                if (label26.Text == "")
                {
                    panel_reminder.Hide();
                }

            }

        }
        /// <summary>
        /// This method is to display the first page when load to this form.
        /// </summary>
        /// <remarks>
        /// <para>The page set different color to a button as others and just display the first page's panel.</para>
        /// <para>Get all bugs</para>
        /// <example>
        /// <code>
        ///  using (SqlConnection con = new SqlConnection(connection))
        ///   {
        ///         con.Open();
        ///         SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
        ///         DataTable dt = new DataTable();
        ///         da.Fill(dt);
        ///         dataGridView1.DataSource = dt;
        ///    }
        /// </code>
        /// </example>
        ///  </remarks>
        public void load()
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
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagv_allTestedBug.DataSource = dt;
            }
        }
        /// <summary>
        /// turn to Login form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        /// <summary>
        /// when click Button testedAll, it will turn to first page.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void btn_testerAll_Click(object sender, EventArgs e)
        {
            load();
        }
        /// <summary>
        /// check out tester's bug which have uploaded.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <example>
        /// <code>
        /// "Select * FROM bug where tester = '"+label_username.Text+"'";
        /// </code>
        /// </example>
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
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where tester = '"+label_username.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagv_myTestedBug.DataSource = dt;
            }
        }
        /// <summary>
        /// turn to testerAdd panel.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void btn_testerAddBug_Click(object sender, EventArgs e)
        {
            btn_testerAll.BackColor = Color.Silver;
            btn_testerAddBug.BackColor = Color.White;
            btn_testerMy.BackColor = Color.Silver;
            panel_testerAdd.Show();
            panel_allTestedBug.Hide();
            panel_myTestedBug.Hide();

        }
        /// <summary>
        /// this event is insert all bug detail.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <example>
        /// <code>
        /// "insert into bug (project,bugTitle,cause,bugSummary,priority,state,start_date,tester) VALUES('" + txt_project.Text + "','" + txt_bugTitle.Text + "','" + txt_cause.Text + "','" + txt_bugSummary.Text + "','" + cmb_priority.Text + "','" + label_testState.Text + "','" + sqlFormattedDate + "','"+label_username.Text+"')";
        /// </code>
        /// </example>
        private void btn_testerNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string newcom = "insert into bug (project,bugTitle,cause,bugSummary,priority,state,start_date,tester) VALUES('" + txt_project.Text + "','" + txt_bugTitle.Text + "','" + txt_cause.Text + "','" + txt_bugSummary.Text + "','" + cmb_priority.Text + "','" + label_testState.Text + "','" + sqlFormattedDate + "','"+label_username.Text+"')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
            }
            load();
        }
        /// <summary>
        /// when the form close, the application will stop.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void tester_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
