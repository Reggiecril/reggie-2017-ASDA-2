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
            string pat = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (Regex.IsMatch(txt_email.Text,pat))
                    MessageBox.Show("The email address is not valid!");
                else if (txt_name.Text == "" || txt_password.Text == "" || txt_email.Text == "")
                    MessageBox.Show("please fill mandatory fields!");
                else if (txt_password.Text != txt_confirmPassword.Text)
                    MessageBox.Show("Password do not match!");
                else
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();
                        string reg = "INSERT INTO buger(name,email,password,role) VALUES ('" + txt_name.Text + "','" + txt_email.Text + "', '" + txt_password.Text + "', '" + combo_role.Text + "')"; 
                        SqlCommand sqlCmd = new SqlCommand(reg, con);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration is successfull");
                        Clear();

                    }
                }
        }
        void Clear()
        {
            txt_name.Text = txt_email.Text = txt_password.Text = "";

        }
    }
}
