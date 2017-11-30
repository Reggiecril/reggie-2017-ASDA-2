namespace Bug_Tracker
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_user_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_developer_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_user_login
            // 
            this.btn_user_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_user_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_user_login.Location = new System.Drawing.Point(315, 367);
            this.btn_user_login.Name = "btn_user_login";
            this.btn_user_login.Size = new System.Drawing.Size(260, 59);
            this.btn_user_login.TabIndex = 0;
            this.btn_user_login.Text = "Tester Login";
            this.btn_user_login.UseVisualStyleBackColor = false;
            this.btn_user_login.Click += new System.EventHandler(this.btn_user_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 16F);
            this.label1.Location = new System.Drawing.Point(105, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Castellar", 16F);
            this.label2.Location = new System.Drawing.Point(41, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox1.Location = new System.Drawing.Point(289, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 53);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox2.Location = new System.Drawing.Point(289, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(243, 53);
            this.textBox2.TabIndex = 4;
            // 
            // btn_developer_login
            // 
            this.btn_developer_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_developer_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_developer_login.Location = new System.Drawing.Point(12, 368);
            this.btn_developer_login.Name = "btn_developer_login";
            this.btn_developer_login.Size = new System.Drawing.Size(267, 58);
            this.btn_developer_login.TabIndex = 6;
            this.btn_developer_login.Text = "Developer Login";
            this.btn_developer_login.UseVisualStyleBackColor = false;
            this.btn_developer_login.Click += new System.EventHandler(this.btn_developer_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 60F);
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 137);
            this.label3.TabIndex = 7;
            this.label3.Text = "login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_developer_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_user_login);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker System-Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_user_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_developer_login;
        private System.Windows.Forms.Label label3;
    }
}

