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
using LibGit2Sharp;
using System.Net.Mail;

namespace Bug_Tracker
{
    /// <summary>
    /// this is the main form, people can login by developer or tester.
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// database path
        /// </summary>
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";
        /// <summary>
        /// display the login form.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// tester login.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// login will check the email and password. if there are,  tester can enter to tester form.
        /// </remarks>
        /// <example>
        /// <code>
        ///     using (SqlConnection con = new SqlConnection(connection))
        ///     {
        ///         SqlDataAdapter da = new SqlDataAdapter("Select name From [user] where email = '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", con);
        ///         DataTable dt = new DataTable();
        ///         da.Fill(dt);
        ///               
        ///         if (dt.Rows.Count == 1)
        ///         {
        ///             this.Hide();
        ///             tester tester = new tester(dt.Rows[0][0].ToString());
        ///             tester.Show();
        ///         }
        ///         else
        ///         {
        ///             MessageBox.Show("Please Check Your e-mail or password");
        ///         }
        /// </code>
        /// </example>
        private void btn_user_login_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select name From buger where email = '" + textBox1.Text + "' and password= '" + textBox2.Text + "' and role = 'tester'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);this.Hide();
                    tester tester = new tester(dt.Rows[0][0].ToString());
                    tester.Show();
                if (dt.Rows.Count == 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("Please Check Your e-mail or password");
                }

            }
            

        }
        /// <summary>
        ///  developer login.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// login will check the email and password. if there are,  developer can enter to develper form.
        /// </remarks>
        /// <example>
        /// <code>
        ///     using (SqlConnection con = new SqlConnection(connection))
        ///     {
        ///         SqlDataAdapter da = new SqlDataAdapter("Select name From [developer] where email = '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", con);
        ///         DataTable dt = new DataTable();
        ///         da.Fill(dt);
        ///               
        ///         if (dt.Rows.Count == 1)
        ///         {
        ///             this.Hide();
        ///             developer developer = new developer("reggie");
        ///              developer.Show();
        ///         }
        ///         else
        ///         {
        ///             MessageBox.Show("Please Check Your e-mail or password");
        ///         }
        /// </code>
        /// </example>
        private void btn_developer_login_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select name From buger where email = '" + textBox1.Text + "' and password= '" + textBox2.Text + "' and role = 'developer'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    developer developer = new developer(dt.Rows[0][0].ToString());
                    developer.Show();
                }
                else
                {
                    MessageBox.Show("Please Check Your e-mail or password");
                }

            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register re = new register();
            re.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
