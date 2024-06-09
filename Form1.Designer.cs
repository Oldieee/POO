namespace Unilog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            login_signupHere = new Label();
            label4 = new Label();
            login_showPwd = new CheckBox();
            login_btn = new Button();
            login_pwd = new TextBox();
            login_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(login_signupHere);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_showPwd);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_pwd);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 549);
            panel1.TabIndex = 0;
            // 
            // login_signupHere
            // 
            login_signupHere.AutoSize = true;
            login_signupHere.Location = new Point(493, 511);
            login_signupHere.Name = "login_signupHere";
            login_signupHere.Size = new Size(96, 20);
            login_signupHere.TabIndex = 9;
            login_signupHere.Text = "Register here";
            login_signupHere.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(336, 511);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 8;
            label4.Text = "Don't have an account?";
            // 
            // login_showPwd
            // 
            login_showPwd.AutoSize = true;
            login_showPwd.Location = new Point(587, 353);
            login_showPwd.Margin = new Padding(3, 4, 3, 4);
            login_showPwd.Name = "login_showPwd";
            login_showPwd.Size = new Size(134, 24);
            login_showPwd.TabIndex = 7;
            login_showPwd.Text = "Show password";
            login_showPwd.UseVisualStyleBackColor = true;
            login_showPwd.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(106, 176, 160);
            login_btn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(321, 372);
            login_btn.Margin = new Padding(3, 4, 3, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(110, 47);
            login_btn.TabIndex = 6;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_pwd
            // 
            login_pwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_pwd.Location = new Point(331, 301);
            login_pwd.Margin = new Padding(3, 4, 3, 4);
            login_pwd.Multiline = true;
            login_pwd.Name = "login_pwd";
            login_pwd.PasswordChar = '*';
            login_pwd.Size = new Size(379, 43);
            login_pwd.TabIndex = 5;
            login_pwd.TextChanged += textBox2_TextChanged;
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(331, 207);
            login_username.Margin = new Padding(3, 4, 3, 4);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(379, 39);
            login_username.TabIndex = 4;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(321, 271);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(321, 176);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 95);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 1;
            label1.Text = "Welcome back!";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(106, 176, 160);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 549);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(70, 187);
            label6.Name = "label6";
            label6.Size = new Size(155, 54);
            label6.TabIndex = 0;
            label6.Text = "UniLog";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 548);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox login_pwd;
        private TextBox login_username;
        private CheckBox login_showPwd;
        private Button login_btn;
        private Label login_signupHere;
        private Label label4;
        private Label label6;
    }
}
