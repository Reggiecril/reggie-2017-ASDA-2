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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_completeBug = new System.Windows.Forms.Button();
            this.btn_assignBug = new System.Windows.Forms.Button();
            this.btn_checkBugs = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel_checkBugs = new System.Windows.Forms.Panel();
            this.panel_assignBug = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btn_selectToAssign = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_checkBugs.SuspendLayout();
            this.panel_assignBug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel_assignBug);
            this.panel1.Controls.Add(this.panel_checkBugs);
            this.panel1.Controls.Add(this.btn_completeBug);
            this.panel1.Controls.Add(this.btn_assignBug);
            this.panel1.Controls.Add(this.btn_checkBugs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 557);
            this.panel1.TabIndex = 0;
            // 
            // btn_completeBug
            // 
            this.btn_completeBug.BackColor = System.Drawing.SystemColors.Info;
            this.btn_completeBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_completeBug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_completeBug.Location = new System.Drawing.Point(430, 3);
            this.btn_completeBug.Name = "btn_completeBug";
            this.btn_completeBug.Size = new System.Drawing.Size(181, 90);
            this.btn_completeBug.TabIndex = 11;
            this.btn_completeBug.Text = "Complete a Bug";
            this.btn_completeBug.UseVisualStyleBackColor = false;
            // 
            // btn_assignBug
            // 
            this.btn_assignBug.BackColor = System.Drawing.SystemColors.Info;
            this.btn_assignBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_assignBug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_assignBug.Location = new System.Drawing.Point(224, 3);
            this.btn_assignBug.Name = "btn_assignBug";
            this.btn_assignBug.Size = new System.Drawing.Size(181, 90);
            this.btn_assignBug.TabIndex = 10;
            this.btn_assignBug.Text = "Assign a Bug";
            this.btn_assignBug.UseVisualStyleBackColor = false;
            this.btn_assignBug.Click += new System.EventHandler(this.btn_assignBug_Click);
            // 
            // btn_checkBugs
            // 
            this.btn_checkBugs.BackColor = System.Drawing.SystemColors.Info;
            this.btn_checkBugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkBugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkBugs.Location = new System.Drawing.Point(15, 3);
            this.btn_checkBugs.Name = "btn_checkBugs";
            this.btn_checkBugs.Size = new System.Drawing.Size(181, 90);
            this.btn_checkBugs.TabIndex = 9;
            this.btn_checkBugs.Text = "Check Bugs";
            this.btn_checkBugs.UseVisualStyleBackColor = false;
            this.btn_checkBugs.Click += new System.EventHandler(this.btn_checkBugs_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(903, 375);
            this.dataGridView1.TabIndex = 5;
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
            // panel_checkBugs
            // 
            this.panel_checkBugs.Controls.Add(this.dataGridView1);
            this.panel_checkBugs.Controls.Add(this.comboBox1);
            this.panel_checkBugs.Controls.Add(this.comboBox2);
            this.panel_checkBugs.Controls.Add(this.button1);
            this.panel_checkBugs.Location = new System.Drawing.Point(15, 84);
            this.panel_checkBugs.Name = "panel_checkBugs";
            this.panel_checkBugs.Size = new System.Drawing.Size(927, 459);
            this.panel_checkBugs.TabIndex = 12;
            // 
            // panel_assignBug
            // 
            this.panel_assignBug.Controls.Add(this.btn_selectToAssign);
            this.panel_assignBug.Controls.Add(this.comboBox3);
            this.panel_assignBug.Controls.Add(this.dataGridView2);
            this.panel_assignBug.Location = new System.Drawing.Point(15, 84);
            this.panel_assignBug.Name = "panel_assignBug";
            this.panel_assignBug.Size = new System.Drawing.Size(927, 459);
            this.panel_assignBug.TabIndex = 13;
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
            this.comboBox3.Size = new System.Drawing.Size(149, 46);
            this.comboBox3.TabIndex = 1;
            // 
            // btn_selectToAssign
            // 
            this.btn_selectToAssign.Location = new System.Drawing.Point(248, 15);
            this.btn_selectToAssign.Name = "btn_selectToAssign";
            this.btn_selectToAssign.Size = new System.Drawing.Size(108, 46);
            this.btn_selectToAssign.TabIndex = 2;
            this.btn_selectToAssign.Text = "Assign it";
            this.btn_selectToAssign.UseVisualStyleBackColor = true;
            this.btn_selectToAssign.Click += new System.EventHandler(this.btn_selectToAssign_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_checkBugs.ResumeLayout(false);
            this.panel_assignBug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_checkBugs;
        private System.Windows.Forms.Button btn_completeBug;
        private System.Windows.Forms.Button btn_assignBug;
        private System.Windows.Forms.Panel panel_checkBugs;
        private System.Windows.Forms.Panel panel_assignBug;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_selectToAssign;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}