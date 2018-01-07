namespace Bug_Tracker
{
    partial class tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tester));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_testerAll = new System.Windows.Forms.Button();
            this.btn_testerMy = new System.Windows.Forms.Button();
            this.btn_testerAddBug = new System.Windows.Forms.Button();
            this.panel_testerAdd = new System.Windows.Forms.Panel();
            this.label_testState = new System.Windows.Forms.Label();
            this.txt_cause = new System.Windows.Forms.TextBox();
            this.txt_bugSummary = new System.Windows.Forms.TextBox();
            this.cmb_priority = new System.Windows.Forms.ComboBox();
            this.txt_bugTitle = new System.Windows.Forms.TextBox();
            this.txt_project = new System.Windows.Forms.TextBox();
            this.btn_testerNew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_allTestedBug = new System.Windows.Forms.Panel();
            this.datagv_allTestedBug = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_myTestedBug = new System.Windows.Forms.Panel();
            this.datagv_myTestedBug = new System.Windows.Forms.DataGridView();
            this.panel_tester = new System.Windows.Forms.Panel();
            this.panel_reminder = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel_testerAdd.SuspendLayout();
            this.panel_allTestedBug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_allTestedBug)).BeginInit();
            this.panel_myTestedBug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_myTestedBug)).BeginInit();
            this.panel_tester.SuspendLayout();
            this.panel_reminder.SuspendLayout();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Tracker-";
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
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(369, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tester";
            // 
            // btn_testerAll
            // 
            this.btn_testerAll.BackColor = System.Drawing.Color.Silver;
            this.btn_testerAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testerAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_testerAll.Location = new System.Drawing.Point(12, 4);
            this.btn_testerAll.Name = "btn_testerAll";
            this.btn_testerAll.Size = new System.Drawing.Size(180, 90);
            this.btn_testerAll.TabIndex = 0;
            this.btn_testerAll.Text = "All Tested Bug";
            this.btn_testerAll.UseVisualStyleBackColor = false;
            this.btn_testerAll.Click += new System.EventHandler(this.btn_testerAll_Click);
            // 
            // btn_testerMy
            // 
            this.btn_testerMy.BackColor = System.Drawing.Color.Silver;
            this.btn_testerMy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testerMy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_testerMy.Location = new System.Drawing.Point(239, 4);
            this.btn_testerMy.Name = "btn_testerMy";
            this.btn_testerMy.Size = new System.Drawing.Size(180, 90);
            this.btn_testerMy.TabIndex = 0;
            this.btn_testerMy.Text = "My Tested Bug";
            this.btn_testerMy.UseVisualStyleBackColor = false;
            this.btn_testerMy.Click += new System.EventHandler(this.btn_testerMy_Click);
            // 
            // btn_testerAddBug
            // 
            this.btn_testerAddBug.BackColor = System.Drawing.Color.Silver;
            this.btn_testerAddBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testerAddBug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_testerAddBug.ForeColor = System.Drawing.Color.Black;
            this.btn_testerAddBug.Location = new System.Drawing.Point(464, 4);
            this.btn_testerAddBug.Name = "btn_testerAddBug";
            this.btn_testerAddBug.Size = new System.Drawing.Size(180, 90);
            this.btn_testerAddBug.TabIndex = 2;
            this.btn_testerAddBug.Text = "Add Bug";
            this.btn_testerAddBug.UseVisualStyleBackColor = false;
            this.btn_testerAddBug.Click += new System.EventHandler(this.btn_testerAddBug_Click);
            // 
            // panel_testerAdd
            // 
            this.panel_testerAdd.BackColor = System.Drawing.Color.White;
            this.panel_testerAdd.Controls.Add(this.label_testState);
            this.panel_testerAdd.Controls.Add(this.txt_cause);
            this.panel_testerAdd.Controls.Add(this.txt_bugSummary);
            this.panel_testerAdd.Controls.Add(this.cmb_priority);
            this.panel_testerAdd.Controls.Add(this.txt_bugTitle);
            this.panel_testerAdd.Controls.Add(this.txt_project);
            this.panel_testerAdd.Controls.Add(this.btn_testerNew);
            this.panel_testerAdd.Controls.Add(this.label9);
            this.panel_testerAdd.Controls.Add(this.label8);
            this.panel_testerAdd.Controls.Add(this.label7);
            this.panel_testerAdd.Controls.Add(this.label5);
            this.panel_testerAdd.Controls.Add(this.label4);
            this.panel_testerAdd.Controls.Add(this.label3);
            this.panel_testerAdd.Location = new System.Drawing.Point(12, 91);
            this.panel_testerAdd.Name = "panel_testerAdd";
            this.panel_testerAdd.Size = new System.Drawing.Size(937, 453);
            this.panel_testerAdd.TabIndex = 3;
            // 
            // label_testState
            // 
            this.label_testState.AutoSize = true;
            this.label_testState.Location = new System.Drawing.Point(701, 142);
            this.label_testState.Name = "label_testState";
            this.label_testState.Size = new System.Drawing.Size(80, 18);
            this.label_testState.TabIndex = 15;
            this.label_testState.Text = "Uploaded";
            // 
            // txt_cause
            // 
            this.txt_cause.Location = new System.Drawing.Point(704, 226);
            this.txt_cause.Multiline = true;
            this.txt_cause.Name = "txt_cause";
            this.txt_cause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_cause.Size = new System.Drawing.Size(192, 84);
            this.txt_cause.TabIndex = 14;
            // 
            // txt_bugSummary
            // 
            this.txt_bugSummary.Location = new System.Drawing.Point(180, 226);
            this.txt_bugSummary.Multiline = true;
            this.txt_bugSummary.Name = "txt_bugSummary";
            this.txt_bugSummary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bugSummary.Size = new System.Drawing.Size(212, 84);
            this.txt_bugSummary.TabIndex = 13;
            // 
            // cmb_priority
            // 
            this.cmb_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_priority.FormattingEnabled = true;
            this.cmb_priority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmb_priority.Location = new System.Drawing.Point(704, 33);
            this.cmb_priority.Name = "cmb_priority";
            this.cmb_priority.Size = new System.Drawing.Size(192, 26);
            this.cmb_priority.TabIndex = 11;
            // 
            // txt_bugTitle
            // 
            this.txt_bugTitle.Location = new System.Drawing.Point(180, 139);
            this.txt_bugTitle.Name = "txt_bugTitle";
            this.txt_bugTitle.Size = new System.Drawing.Size(212, 28);
            this.txt_bugTitle.TabIndex = 10;
            // 
            // txt_project
            // 
            this.txt_project.Location = new System.Drawing.Point(180, 33);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(212, 28);
            this.txt_project.TabIndex = 8;
            // 
            // btn_testerNew
            // 
            this.btn_testerNew.Location = new System.Drawing.Point(409, 350);
            this.btn_testerNew.Name = "btn_testerNew";
            this.btn_testerNew.Size = new System.Drawing.Size(185, 78);
            this.btn_testerNew.TabIndex = 7;
            this.btn_testerNew.Text = "Add";
            this.btn_testerNew.UseVisualStyleBackColor = true;
            this.btn_testerNew.Click += new System.EventHandler(this.btn_testerNew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bug Summary *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Priority *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "State *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cause *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bug Title *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project *";
            // 
            // panel_allTestedBug
            // 
            this.panel_allTestedBug.BackColor = System.Drawing.Color.White;
            this.panel_allTestedBug.Controls.Add(this.datagv_allTestedBug);
            this.panel_allTestedBug.Location = new System.Drawing.Point(12, 91);
            this.panel_allTestedBug.Name = "panel_allTestedBug";
            this.panel_allTestedBug.Size = new System.Drawing.Size(937, 453);
            this.panel_allTestedBug.TabIndex = 4;
            // 
            // datagv_allTestedBug
            // 
            this.datagv_allTestedBug.AllowUserToAddRows = false;
            this.datagv_allTestedBug.AllowUserToDeleteRows = false;
            this.datagv_allTestedBug.BackgroundColor = System.Drawing.Color.White;
            this.datagv_allTestedBug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagv_allTestedBug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagv_allTestedBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_allTestedBug.EnableHeadersVisualStyles = false;
            this.datagv_allTestedBug.Location = new System.Drawing.Point(13, 3);
            this.datagv_allTestedBug.Name = "datagv_allTestedBug";
            this.datagv_allTestedBug.RowHeadersVisible = false;
            this.datagv_allTestedBug.RowTemplate.Height = 30;
            this.datagv_allTestedBug.Size = new System.Drawing.Size(912, 447);
            this.datagv_allTestedBug.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label6.Location = new System.Drawing.Point(768, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tester:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label_username.ForeColor = System.Drawing.SystemColors.Info;
            this.label_username.Location = new System.Drawing.Point(768, 48);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(73, 33);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "name";
            // 
            // panel_myTestedBug
            // 
            this.panel_myTestedBug.BackColor = System.Drawing.Color.White;
            this.panel_myTestedBug.Controls.Add(this.datagv_myTestedBug);
            this.panel_myTestedBug.Location = new System.Drawing.Point(12, 91);
            this.panel_myTestedBug.Name = "panel_myTestedBug";
            this.panel_myTestedBug.Size = new System.Drawing.Size(937, 453);
            this.panel_myTestedBug.TabIndex = 5;
            // 
            // datagv_myTestedBug
            // 
            this.datagv_myTestedBug.AllowUserToAddRows = false;
            this.datagv_myTestedBug.AllowUserToDeleteRows = false;
            this.datagv_myTestedBug.BackgroundColor = System.Drawing.Color.White;
            this.datagv_myTestedBug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagv_myTestedBug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagv_myTestedBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_myTestedBug.EnableHeadersVisualStyles = false;
            this.datagv_myTestedBug.Location = new System.Drawing.Point(13, 6);
            this.datagv_myTestedBug.Name = "datagv_myTestedBug";
            this.datagv_myTestedBug.RowHeadersVisible = false;
            this.datagv_myTestedBug.RowTemplate.Height = 30;
            this.datagv_myTestedBug.Size = new System.Drawing.Size(912, 444);
            this.datagv_myTestedBug.TabIndex = 0;
            // 
            // panel_tester
            // 
            this.panel_tester.BackColor = System.Drawing.Color.Gray;
            this.panel_tester.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_tester.BackgroundImage")));
            this.panel_tester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_tester.Controls.Add(this.panel_reminder);
            this.panel_tester.Controls.Add(this.panel_myTestedBug);
            this.panel_tester.Controls.Add(this.label_username);
            this.panel_tester.Controls.Add(this.label6);
            this.panel_tester.Controls.Add(this.panel_allTestedBug);
            this.panel_tester.Controls.Add(this.panel_testerAdd);
            this.panel_tester.Controls.Add(this.btn_testerAddBug);
            this.panel_tester.Controls.Add(this.btn_testerMy);
            this.panel_tester.Controls.Add(this.btn_testerAll);
            this.panel_tester.Location = new System.Drawing.Point(0, 92);
            this.panel_tester.Name = "panel_tester";
            this.panel_tester.Size = new System.Drawing.Size(955, 558);
            this.panel_tester.TabIndex = 5;
            // 
            // panel_reminder
            // 
            this.panel_reminder.BackColor = System.Drawing.Color.White;
            this.panel_reminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_reminder.Controls.Add(this.label25);
            this.panel_reminder.Controls.Add(this.button2);
            this.panel_reminder.Controls.Add(this.label29);
            this.panel_reminder.Controls.Add(this.button3);
            this.panel_reminder.Controls.Add(this.label28);
            this.panel_reminder.Controls.Add(this.label27);
            this.panel_reminder.Controls.Add(this.label26);
            this.panel_reminder.Location = new System.Drawing.Point(650, 314);
            this.panel_reminder.Name = "panel_reminder";
            this.panel_reminder.Size = new System.Drawing.Size(288, 226);
            this.panel_reminder.TabIndex = 26;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Unicode MS", 10F);
            this.label25.ForeColor = System.Drawing.Color.Olive;
            this.label25.Location = new System.Drawing.Point(11, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 26);
            this.label25.TabIndex = 8;
            this.label25.Text = "Reminder";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(243, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 33);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(-4, 19);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(557, 18);
            this.label29.TabIndex = 6;
            this.label29.Text = "                                                             ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(90, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "Check it out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label28.Location = new System.Drawing.Point(97, 138);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 24);
            this.label28.TabIndex = 4;
            this.label28.Text = "label28";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(65, 99);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(179, 18);
            this.label27.TabIndex = 3;
            this.label27.Text = "Completed Your Bug.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 11F);
            this.label26.ForeColor = System.Drawing.Color.Firebrick;
            this.label26.Location = new System.Drawing.Point(10, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 22);
            this.label26.TabIndex = 2;
            // 
            // tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_tester);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Name = "tester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker System-Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tester_FormClosing);
            this.panel_testerAdd.ResumeLayout(false);
            this.panel_testerAdd.PerformLayout();
            this.panel_allTestedBug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_allTestedBug)).EndInit();
            this.panel_myTestedBug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_myTestedBug)).EndInit();
            this.panel_tester.ResumeLayout(false);
            this.panel_tester.PerformLayout();
            this.panel_reminder.ResumeLayout(false);
            this.panel_reminder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_testerAll;
        private System.Windows.Forms.Button btn_testerMy;
        private System.Windows.Forms.Button btn_testerAddBug;
        private System.Windows.Forms.Panel panel_testerAdd;
        private System.Windows.Forms.Label label_testState;
        private System.Windows.Forms.TextBox txt_cause;
        private System.Windows.Forms.TextBox txt_bugSummary;
        private System.Windows.Forms.ComboBox cmb_priority;
        private System.Windows.Forms.TextBox txt_bugTitle;
        private System.Windows.Forms.TextBox txt_project;
        private System.Windows.Forms.Button btn_testerNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_allTestedBug;
        private System.Windows.Forms.DataGridView datagv_allTestedBug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Panel panel_myTestedBug;
        private System.Windows.Forms.DataGridView datagv_myTestedBug;
        private System.Windows.Forms.Panel panel_tester;
        private System.Windows.Forms.Panel panel_reminder;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
    }
}