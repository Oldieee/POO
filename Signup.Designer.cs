namespace Unilog
{
    partial class Signup
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
            panel1 = new Panel();
            signup_pwd = new TextBox();
            label7 = new Label();
            signup_loginHere = new Label();
            label4 = new Label();
            signup_showPwd = new CheckBox();
            signup_btn = new Button();
            signup_username = new TextBox();
            signup_email = new TextBox();
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
            panel1.Controls.Add(signup_pwd);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(signup_loginHere);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signup_showPwd);
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(signup_username);
            panel1.Controls.Add(signup_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-19, -28);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 412);
            panel1.TabIndex = 1;
            // 
            // signup_pwd
            // 
            signup_pwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_pwd.Location = new Point(290, 254);
            signup_pwd.Multiline = true;
            signup_pwd.Name = "signup_pwd";
            signup_pwd.PasswordChar = '*';
            signup_pwd.Size = new Size(332, 33);
            signup_pwd.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(286, 231);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 10;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // signup_loginHere
            // 
            signup_loginHere.AutoSize = true;
            signup_loginHere.Location = new Point(434, 377);
            signup_loginHere.Name = "signup_loginHere";
            signup_loginHere.Size = new Size(66, 15);
            signup_loginHere.TabIndex = 9;
            signup_loginHere.Text = "Login here ";
            signup_loginHere.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(290, 377);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 8;
            label4.Text = "Already have an account?";
            label4.Click += label4_Click;
            // 
            // signup_showPwd
            // 
            signup_showPwd.AutoSize = true;
            signup_showPwd.Location = new Point(517, 293);
            signup_showPwd.Name = "signup_showPwd";
            signup_showPwd.Size = new Size(108, 19);
            signup_showPwd.TabIndex = 7;
            signup_showPwd.Text = "Show password";
            signup_showPwd.UseVisualStyleBackColor = true;
            signup_showPwd.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(106, 176, 160);
            signup_btn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_btn.Location = new Point(281, 304);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(96, 35);
            signup_btn.TabIndex = 6;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_username.Location = new Point(290, 185);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(332, 33);
            signup_username.TabIndex = 5;
            // 
            // signup_email
            // 
            signup_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_email.Location = new Point(290, 116);
            signup_email.Multiline = true;
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(332, 30);
            signup_email.TabIndex = 4;
            signup_email.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 160);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 93);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 50);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 1;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(106, 176, 160);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 412);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(61, 140);
            label6.Name = "label6";
            label6.Size = new Size(127, 45);
            label6.TabIndex = 0;
            label6.Text = "UniLog";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 373);
            Controls.Add(panel1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label signup_loginHere;
        private Label label4;
        private CheckBox signup_showPwd;
        private Button signup_btn;
        private TextBox signup_username;
        private TextBox signup_email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label6;
        private TextBox signup_pwd;
        private Label label7;
    }
}