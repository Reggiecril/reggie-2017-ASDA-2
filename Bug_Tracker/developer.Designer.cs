namespace Bug_Tracker
{
    partial class developer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(developer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_checkBugs = new System.Windows.Forms.Button();
            this.btn_assignBug = new System.Windows.Forms.Button();
            this.btn_completeBug = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.panel_assignBug = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btn_selectToAssign = new System.Windows.Forms.Button();
            this.panel_completeBug = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_checkBugs = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_history = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.combo_audit = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_assignBug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel_completeBug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel_checkBugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bug Tracker-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(370, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "Developer";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
            this.btn_logout.Location = new System.Drawing.Point(800, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(142, 74);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(793, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "name";
            // 
            // btn_checkBugs
            // 
            this.btn_checkBugs.BackColor = System.Drawing.SystemColors.Info;
            this.btn_checkBugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkBugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkBugs.Location = new System.Drawing.Point(12, 3);
            this.btn_checkBugs.Name = "btn_checkBugs";
            this.btn_checkBugs.Size = new System.Drawing.Size(110, 90);
            this.btn_checkBugs.TabIndex = 9;
            this.btn_checkBugs.Text = "Check Bugs";
            this.btn_checkBugs.UseVisualStyleBackColor = false;
            this.btn_checkBugs.Click += new System.EventHandler(this.btn_checkBugs_Click);
            // 
            // btn_assignBug
            // 
            this.btn_assignBug.BackColor = System.Drawing.SystemColors.Info;
            this.btn_assignBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_assignBug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_assignBug.Location = new System.Drawing.Point(189, 3);
            this.btn_assignBug.Name = "btn_assignBug";
            this.btn_assignBug.Size = new System.Drawing.Size(110, 90);
            this.btn_assignBug.TabIndex = 10;
            this.btn_assignBug.Text = "Assign a Bug";
            this.btn_assignBug.UseVisualStyleBackColor = false;
            this.btn_assignBug.Click += new System.EventHandler(this.btn_assignBug_Click);
            // 
            // btn_completeBug
            // 
            this.btn_completeBug.BackColor = System.Drawing.SystemColors.Info;
            this.btn_completeBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_completeBug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_completeBug.Location = new System.Drawing.Point(365, 3);
            this.btn_completeBug.Name = "btn_completeBug";
            this.btn_completeBug.Size = new System.Drawing.Size(110, 90);
            this.btn_completeBug.TabIndex = 11;
            this.btn_completeBug.Text = "Complete a Bug";
            this.btn_completeBug.UseVisualStyleBackColor = false;
            this.btn_completeBug.Click += new System.EventHandler(this.btn_completeBug_Click);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.SystemColors.Info;
            this.btn_history.Location = new System.Drawing.Point(536, 3);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(110, 90);
            this.btn_history.TabIndex = 15;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // panel_assignBug
            // 
            this.panel_assignBug.BackColor = System.Drawing.Color.White;
            this.panel_assignBug.Controls.Add(this.btn_selectToAssign);
            this.panel_assignBug.Controls.Add(this.comboBox3);
            this.panel_assignBug.Controls.Add(this.dataGridView2);
            this.panel_assignBug.Location = new System.Drawing.Point(9, 90);
            this.panel_assignBug.Name = "panel_assignBug";
            this.panel_assignBug.Size = new System.Drawing.Size(933, 453);
            this.panel_assignBug.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(903, 365);
            this.dataGridView2.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(60, 15);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 46);
            this.comboBox3.TabIndex = 1;
            // 
            // btn_selectToAssign
            // 
            this.btn_selectToAssign.Location = new System.Drawing.Point(252, 15);
            this.btn_selectToAssign.Name = "btn_selectToAssign";
            this.btn_selectToAssign.Size = new System.Drawing.Size(110, 46);
            this.btn_selectToAssign.TabIndex = 2;
            this.btn_selectToAssign.Text = "Assign it";
            this.btn_selectToAssign.UseVisualStyleBackColor = true;
            this.btn_selectToAssign.Click += new System.EventHandler(this.btn_selectToAssign_Click);
            // 
            // panel_completeBug
            // 
            this.panel_completeBug.BackColor = System.Drawing.Color.White;
            this.panel_completeBug.Controls.Add(this.button2);
            this.panel_completeBug.Controls.Add(this.dataGridView3);
            this.panel_completeBug.Controls.Add(this.label10);
            this.panel_completeBug.Controls.Add(this.textBox5);
            this.panel_completeBug.Controls.Add(this.textBox3);
            this.panel_completeBug.Controls.Add(this.textBox2);
            this.panel_completeBug.Controls.Add(this.label7);
            this.panel_completeBug.Controls.Add(this.label9);
            this.panel_completeBug.Controls.Add(this.label8);
            this.panel_completeBug.Controls.Add(this.label6);
            this.panel_completeBug.Controls.Add(this.label5);
            this.panel_completeBug.Controls.Add(this.textBox1);
            this.panel_completeBug.Controls.Add(this.label4);
            this.panel_completeBug.Controls.Add(this.comboBox4);
            this.panel_completeBug.Location = new System.Drawing.Point(9, 90);
            this.panel_completeBug.Name = "panel_completeBug";
            this.panel_completeBug.Size = new System.Drawing.Size(933, 453);
            this.panel_completeBug.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(227, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(177, 46);
            this.comboBox4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bug";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 28);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Code Block";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Line Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Class Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "State";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 28);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(657, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 28);
            this.textBox3.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 284);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(674, 122);
            this.textBox5.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.GreenYellow;
            this.label10.Location = new System.Drawing.Point(657, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Completed";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(83, 81);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 30;
            this.dataGridView3.Size = new System.Drawing.Size(734, 197);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Complete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_checkBugs
            // 
            this.panel_checkBugs.BackColor = System.Drawing.Color.White;
            this.panel_checkBugs.Controls.Add(this.dataGridView1);
            this.panel_checkBugs.Controls.Add(this.comboBox1);
            this.panel_checkBugs.Controls.Add(this.comboBox2);
            this.panel_checkBugs.Controls.Add(this.button1);
            this.panel_checkBugs.Location = new System.Drawing.Point(9, 89);
            this.panel_checkBugs.Name = "panel_checkBugs";
            this.panel_checkBugs.Size = new System.Drawing.Size(933, 454);
            this.panel_checkBugs.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "Uploaded",
            "Assigned",
            "Completed"});
            this.comboBox2.Location = new System.Drawing.Point(415, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 46);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "All Bugs",
            "My Bugs"});
            this.comboBox1.Location = new System.Drawing.Point(98, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 46);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(903, 363);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel_history
            // 
            this.panel_history.BackColor = System.Drawing.Color.White;
            this.panel_history.Controls.Add(this.dataGridView5);
            this.panel_history.Controls.Add(this.button4);
            this.panel_history.Controls.Add(this.combo_audit);
            this.panel_history.Controls.Add(this.dataGridView4);
            this.panel_history.Location = new System.Drawing.Point(6, 87);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(936, 456);
            this.panel_history.TabIndex = 19;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(10, 81);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 30;
            this.dataGridView4.Size = new System.Drawing.Size(903, 365);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.Visible = false;
            // 
            // combo_audit
            // 
            this.combo_audit.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo_audit.FormattingEnabled = true;
            this.combo_audit.Location = new System.Drawing.Point(99, 15);
            this.combo_audit.Name = "combo_audit";
            this.combo_audit.Size = new System.Drawing.Size(192, 46);
            this.combo_audit.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(397, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Audit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(10, 81);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 30;
            this.dataGridView5.Size = new System.Drawing.Size(915, 365);
            this.dataGridView5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel_history);
            this.panel1.Controls.Add(this.panel_checkBugs);
            this.panel1.Controls.Add(this.panel_completeBug);
            this.panel1.Controls.Add(this.panel_assignBug);
            this.panel1.Controls.Add(this.btn_history);
            this.panel1.Controls.Add(this.btn_completeBug);
            this.panel1.Controls.Add(this.btn_assignBug);
            this.panel1.Controls.Add(this.btn_checkBugs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 558);
            this.panel1.TabIndex = 0;
            // 
            // developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 647);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "developer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "developer";
            this.panel_assignBug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel_completeBug.ResumeLayout(false);
            this.panel_completeBug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel_checkBugs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_checkBugs;
        private System.Windows.Forms.Button btn_assignBug;
        private System.Windows.Forms.Button btn_completeBug;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Panel panel_assignBug;
        private System.Windows.Forms.Button btn_selectToAssign;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel_completeBug;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel panel_checkBugs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_history;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox combo_audit;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel1;
    }
}