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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Bug_Tracker
{

    public partial class register : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";
        public register()
        {
            InitializeComponent();
        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string pat = @"^([\w]+)@([\w]+)\.([\w]+)$";
            if (txt_name.Text == "" || txt_password.Text == "" || txt_email.Text == "")
            { 
                MessageBox.Show("please fill mandatory fields!");
            }
            else if (txt_password.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("Password do not match!");
            }
            else if(Regex.IsMatch(txt_email.Text, pat))
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string reg = "INSERT INTO buger(name,email,password,role) VALUES ('" + txt_name.Text + "','" + txt_email.Text + "', '" + txt_password.Text + "', '" + combo_role.Text + "')";
                    SqlCommand sqlCmd = new SqlCommand(reg, con);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    try
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("reggiecril0618@gmail.com", "Cloud10080618");
                        MailMessage msg = new MailMessage();
                        msg.To.Add(txt_email.Text);
                        msg.From = new MailAddress("reggiecril0618@gmail.com");
                        msg.Subject = "hi " + txt_name.Text;
                        msg.Body = "You just register the bug tracker. Enjoying :)";
                        client.Send(msg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.Hide();
                    if (combo_role.Text == "tester")
                    {
                        tester te = new tester(txt_name.Text);
                        te.Show();
                    }
                    else
                    {
                        developer de = new developer(txt_name.Text);
                        de.Show();
                    }
                }
            }else
            {
                        MessageBox.Show("The email address is not valid!");
            }
        }
    }
}
