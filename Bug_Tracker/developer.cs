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
using System.IO;
using System.Text.RegularExpressions;
using LibGit2Sharp;

namespace Bug_Tracker
{
    /// <summary>
    /// This class is function for developer form
    /// <list type="bullet">
    /// <item>
    /// <description>Check Bugs</description>
    /// </item>
    /// <item>
    /// <description>Assign a bug</description>
    /// </item>
    /// <item>
    /// <description>Complete a bug</description>
    /// </item>
    /// <item>
    /// <description>History</description>
    /// </item>
    /// </list>
    /// </summary>
    public partial class developer : Form
    {
        /// <summary>
        /// Database Path
        /// </summary>
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reggie\Documents\Bug_Tracker_Table.mdf;Integrated Security=True;Connect Timeout=30";
        /// <summary>
        /// Display first page when people load 
        /// </summary>
        /// <param name="DeveloperName">name</param>
        public developer(string name)
        {
            InitializeComponent();
            load();
            reminder();
            this.label3.Text = name;
        }
        /// <summary>
        /// 
        /// </summary>
        public void reminder()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                    SqlCommand da = new SqlCommand("Select * FROM bug Where start_date = (Select MAX(start_date) FROM bug)", con);
                    SqlDataReader dr = da.ExecuteReader();
                    if (dr.Read())
                    {
                        label26.Text = (dr["tester"].ToString());
                        label28.Text = (dr["start_date"].ToString());
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
        /// developer can have option to choose bug
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// There are two combobox,one for state and the other for developer.
        /// <para>
        /// Data will display by combobox text.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// "Select * FROM bug where developer = '" + this.label3.Text + "' and state = '" + this.comboBox2.Text + "'";
        /// </code>
        /// </example>
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
        /// <summary>
        /// when click Button checkBugs, it will turn to first page.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void btn_checkBugs_Click(object sender, EventArgs e)
        {
            load();
        }
        /// <summary>
        /// Developer can assign a bug to repair.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// combobox will display available bug to assign.
        /// </remarks>
        /// <example>
        /// <code>
        /// "Select * FROM bug where developer = '" + this.label3.Text + "' and state = 'Uploaded' ";
        /// </code>
        /// </example>
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
            panel_reminder.Hide();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM bug where state = 'Uploaded' ", con);
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
        /// <summary>
        /// change the state ofter developer assigned.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void btn_selectToAssign_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string newcom = "UPDATE bug SET developer='"+this.label3.Text+"',state = 'Assigned',process_date = '"+sqlFormattedDate+"' WHERE BugID = '" +comboBox3.Text+"'";
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
        /// <summary>
        /// turn to complete panel.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// combobox will have available bug Id to display.
        /// </remarks>
        /// <example>
        /// <code>
        /// "Select * FROM bug where developer = '" + this.label3.Text + "' and state = 'Assigned' ";
        /// </code>
        /// </example>
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
        /// <summary>
        /// this is the event of insert data when button click.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <example>
        /// <code>
        ///  "insert into bug_description ( BugID, Class_file, Method, Source_code, Line_number, update_date) VALUES('" + comboBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + label16.Text + "','" + textBox3.Text + "','" + sqlFormattedDate + "')";
        /// </code>
        /// <code>
        /// "UPDATE bug SET state = 'Completed',completed_date = '"+sqlFormattedDate+ "', update_date = '"+sqlFormattedDate+"' WHERE BugID = '" + comboBox4.Text + "' ";
        /// </code>
        /// </example>
        private void btn_insertBugDescription_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                StreamWriter File = new StreamWriter(label16.Text);
                File.Write(label18.Text);
                File.Close();
                con.Open();
                SqlCommand da = new SqlCommand("Select project FROM bug where BugID = '" + comboBox4.Text + "'", con);
                SqlDataReader dr = da.ExecuteReader();
                if (dr.Read())
                {
                    label23.Text = (dr["project"].ToString());
                }
                dr.Close();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string newcom = "insert into bug_description ( BugID, Class_file, Method, Source_code, Start_Line_Number,End_Line_Number,project,update_date) VALUES('" + comboBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + label16.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+label23.Text+"','" + sqlFormattedDate + "')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
                string newcom1 = "UPDATE bug SET state = 'Completed',completed_date = '"+sqlFormattedDate+ "', update_date = '"+sqlFormattedDate+"' WHERE BugID = '" + comboBox4.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(newcom1, con);
                cmd1.ExecuteNonQuery();
                
                load();
            }
        }
        /// <summary>
        /// turn to history panel
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// The data will display where the bugID from bug is equal to the bugID from bug_description.
        /// </remarks>
        private void btn_history_Click(object sender, EventArgs e)
        {
            panel_audit.Hide();
            dataGridView5.Show();
            btn_sourceCode.Hide();
            txt_sourceCode.Hide();
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
        /// <summary>
        /// turn to audit panel
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// The data from the choose bug will display in each textbox.
        /// </remarks>
        /// <example>
        /// <code>
        /// using (SqlConnection con = new SqlConnection(connection))
        /// {
        ///     con.Open();
        ///     SqlCommand da = new SqlCommand("Select * FROM bug_description where BugID = '" + combo_audit.Text + "' and update_date = (select max(update_date) from bug_description)", con);
        ///     SqlDataReader dr = da.ExecuteReader();
        ///     if (dr.Read())
        ///     {
        ///         label13.Text = (dr["BugID"].ToString());
        ///         txt_classFile.Text = (dr["Class_file"].ToString());
        ///         txt_method.Text = (dr["Method"].ToString());
        ///         txt_lineNumber.Text = (dr["Line_number"].ToString());
        ///         txt_comment.Text = (dr["comment"].ToString());
        ///     }
        /// }
        /// </code>
        /// </example>
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
                        txt_startLineNumber.Text = (dr["Start_Line_Number"].ToString());
                        txt_endLineNumber.Text = (dr["End_Line_Number"].ToString());
                        label_project.Text = (dr["project"].ToString());
                        txt_comment.Text = (dr["comment"].ToString());
                        label_sourceCode.Text = (dr["Source_code"].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a bug to audit!");
            }
            
        }
        /// <summary>
        /// it insert a new data in description, but in table 'bug', just update the update_date.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void btn_finish_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string newcom = "insert into bug_description (BugID,Class_file,Method,Start_Line_Number,End_Line_Number,project,comment,update_date,Source_code) VALUES('" + label13.Text + "','" + txt_classFile.Text + "','" + txt_method.Text + "','" + txt_startLineNumber.Text + "','" + txt_endLineNumber.Text + "','" + label_project.Text + "','" + txt_comment.Text + "','" + sqlFormattedDate + "','"+label_sourceCode.Text+"')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
            }
            DateTime myDateTime1 = DateTime.Now;
            string history = @"C:\Users\Reggie\source\repos\history\history.txt";
            if (Directory.Exists(history))
            {
                Directory.Delete(history, true);
            }
            string sqlFormattedDate1 = myDateTime1.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string[] lines = { txt_comment.Text, label13.Text, txt_method.Text, txt_startLineNumber.Text, txt_endLineNumber.Text, label_project.Text, sqlFormattedDate1 };
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(history))
            {
                foreach (string line in lines)
                {
                        file.WriteLine(line);
                }
            }
            //commit and push to bitbucket
            GitRepositoryManager grm = new GitRepositoryManager("reggiecril0618@gmail.com", "Cloud19961008", "https://reggiecril@bitbucket.org/reggiecril/history.git", @"C:\Users\Reggie\source\repos\history");
            String message = txt_comment.Text;
            Signature author = new Signature(this.label3.Text, "email", DateTime.Now);
            Signature commiter = author;
            CommitOptions co = new CommitOptions();
            grm.CommitAllChanges(message, author, commiter, co);
            grm.PushCommits("history", @"refs/heads/master");
            //back to home page
            load();
        }
        /// <summary>
        /// a textbox will display source code.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// it will get the filename from database and display the file.
        /// </remarks>
        private void btn_sourceCode_Click(object sender, EventArgs e)
        {
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
                        StreamReader read = new StreamReader(File.OpenRead(dr["Source_code"].ToString()));
                        txt_sourceCode.Text = read.ReadToEnd();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a bug !");
            }
        }
        /// <summary>
        /// upload the source code file.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        /// <remarks>
        /// it will upload the filename, display the source code in a hide textbox and save it in source path.
        /// </remarks>
        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                label18.Text = read.ReadToEnd();
                label16.Text = Path.GetFileName(open.FileName);
                label16.Show();
                btn_openFile.Hide();
                read.Dispose();
            }
        }
        /// <summary>
        /// sytnax color
        /// </summary>
        public Regex keyWordsBlue = new Regex("using| if | then | else| fi| true| while| do| done| set| export| bool| break| case| class| const| for| foreach| goto| in| void |if\n|then\n| else\n|fi\n|true\n|while\n|do\n|done\n|set\n|export\n|bool\n|break\n|case\n|class\n|const\n|for\n|foreach\n|goto\n|in\n|public void\n| public| private| protected|partial|namespace |string | this|new |object |foreach |var |null|DataGridViewRow |SqlDataReader |SqlCommand ");
        /// <summary>
        /// sytnax color .
        /// </summary>
        public Regex keyWordsLightGreen = new Regex("Match|FonStyle|@| Color|SystemColors|SqlConnection|SqlDataAdapter|DataTable|EventArgs|DataTime| MessageBox|StreamReader|Path|Regex|OpenFileDialog|DialogResult|File|CommitOption|Signature|GitRepositoryManager|Directory|StreamWrite");
        /// <summary>
        /// sytnax color for string in queto.
        /// </summary>
        public Regex keyWordsYellow = new Regex("\".*?\"");
        /// <summary>
        /// sytnax color for line have"//".
        /// </summary>
        public Regex keyWordsGreen = new Regex("//");
        /// <summary>
        /// set a color
        /// </summary>
        Color cc = Color.FromArgb(179,114,91);
        /// <summary>
        /// set a color
        /// </summary>
        Color comment= Color.FromArgb(0,100,0);
        /// <summary>
        /// set a color
        /// </summary>
        Color blueColor = Color.FromArgb(86,156,214);
        /// <summary>
        /// set color in special word at source code textbox.
        /// </summary>
        /// <remarks>
        /// different color for different style, one for special word, one for string under queto.
        /// </remarks>
        private void ApplySyntaxHighlighting()
        {
            
            // Start applying the highlighting... Set a value to selPos
            int selPos = txt_sourceCode.SelectionStart;
            foreach (Match keyWordMatch in keyWordsLightGreen.Matches(txt_sourceCode.Text))
            {
                // Select the word..
                txt_sourceCode.Select(keyWordMatch.Index, keyWordMatch.Length);
                // Change it to light green
                txt_sourceCode.SelectionColor = cc;
                // Set it to bold for this example
                txt_sourceCode.SelectionFont = new Font(txt_sourceCode.SelectionFont, FontStyle.Regular);
                // Move cursor back to where it was
                txt_sourceCode.SelectionStart = selPos;
                // Change the default font color back to black.
                txt_sourceCode.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in keyWordsBlue.Matches(txt_sourceCode.Text))
            {
                // Select the word..
                txt_sourceCode.Select(keyWordMatch.Index, keyWordMatch.Length);
                // Change it to blue
                txt_sourceCode.SelectionColor = blueColor;
                // Set it to bold for this example
                txt_sourceCode.SelectionFont = new Font(txt_sourceCode.SelectionFont, FontStyle.Regular);
                // Move cursor back to where it was
                txt_sourceCode.SelectionStart = selPos;

            }
            foreach (Match keyWordMatch in keyWordsYellow.Matches(txt_sourceCode.Text))
            {
                // Select the word..
                txt_sourceCode.Select(keyWordMatch.Index, keyWordMatch.Length);
                // Change it to orange
                txt_sourceCode.SelectionColor = Color.Orange;
                // Set it to bold for this example
                txt_sourceCode.SelectionFont = new Font(txt_sourceCode.SelectionFont, FontStyle.Regular);
                // Move cursor back to where it was
                txt_sourceCode.SelectionStart = selPos;
            }

            for (int i = 0; i < txt_sourceCode.Lines.Count(); i++)
            {
                highlightLineContaining(txt_sourceCode, i);
            }
        }
        /// <summary>
        /// get the entire line when the line have "//"
        /// </summary>
        /// <param name="rtb">get richtextbox</param>
        /// <param name="line">select line</param>
        public void highlightLineContaining(RichTextBox rtb, int line)
        {
            int c0 = rtb.GetFirstCharIndexFromLine(line);
            int c1 = rtb.GetFirstCharIndexFromLine(line + 1);
            if (c1 < 0) c1 = rtb.Text.Length;
            rtb.SelectionStart = c0;
            rtb.SelectionLength = c1 - c0;
            if (rtb.SelectedText.Contains("//"))
                rtb.SelectionColor = comment;
            rtb.SelectionLength = 0;
        }
        /// <summary>
        /// when the form close, the application will stop.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void developer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// event to set color to special word.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Arguments</param>
        private void txt_sourceCode_TextChanged_1(object sender, EventArgs e)
        {
            ApplySyntaxHighlighting();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_reminder.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
