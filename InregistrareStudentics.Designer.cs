
namespace Unilog
{
    partial class InregistrareStudentics
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
            label2 = new Label();
            reg_prenume = new TextBox();
            label1 = new Label();
            label3 = new Label();
            reg_data = new DateTimePicker();
            reg_nume = new TextBox();
            reg_email = new TextBox();
            label4 = new Label();
            reg_telefon = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            reg_pwd = new TextBox();
            label7 = new Label();
            dataView_students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataView_students).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(106, 176, 160);
            label2.Location = new Point(32, 376);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Email :";
            label2.Click += label2_Click;
            // 
            // reg_prenume
            // 
            reg_prenume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_prenume.Location = new Point(529, 263);
            reg_prenume.Multiline = true;
            reg_prenume.Name = "reg_prenume";
            reg_prenume.Size = new Size(178, 24);
            reg_prenume.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(106, 176, 160);
            label1.Location = new Point(435, 263);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 7;
            label1.Text = "Prenume :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(106, 176, 160);
            label3.Location = new Point(28, 263);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 9;
            label3.Text = "Nume: ";
            // 
            // reg_data
            // 
            reg_data.Location = new Point(545, 376);
            reg_data.Margin = new Padding(3, 2, 3, 2);
            reg_data.Name = "reg_data";
            reg_data.Size = new Size(175, 23);
            reg_data.TabIndex = 11;
            // 
            // reg_nume
            // 
            reg_nume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_nume.Location = new Point(111, 263);
            reg_nume.Multiline = true;
            reg_nume.Name = "reg_nume";
            reg_nume.Size = new Size(181, 24);
            reg_nume.TabIndex = 12;
            // 
            // reg_email
            // 
            reg_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_email.Location = new Point(111, 374);
            reg_email.Multiline = true;
            reg_email.Name = "reg_email";
            reg_email.Size = new Size(181, 24);
            reg_email.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(106, 176, 160);
            label4.Location = new Point(435, 376);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 14;
            label4.Text = "Anul nașterii :";
            label4.Click += label4_Click;
            // 
            // reg_telefon
            // 
            reg_telefon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_telefon.Location = new Point(111, 320);
            reg_telefon.Multiline = true;
            reg_telefon.Name = "reg_telefon";
            reg_telefon.Size = new Size(181, 24);
            reg_telefon.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(106, 176, 160);
            label5.Location = new Point(28, 320);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 15;
            label5.Text = "Telefon :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(106, 176, 160);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(733, 413);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 32);
            button1.TabIndex = 19;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(106, 176, 160);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 53);
            panel2.TabIndex = 20;
            // 
            // reg_pwd
            // 
            reg_pwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_pwd.Location = new Point(529, 316);
            reg_pwd.Multiline = true;
            reg_pwd.Name = "reg_pwd";
            reg_pwd.Size = new Size(181, 24);
            reg_pwd.TabIndex = 22;
            reg_pwd.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(106, 176, 160);
            label7.Location = new Point(435, 316);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 21;
            label7.Text = "Parola:";
            // 
            // dataView_students
            // 
            dataView_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView_students.Location = new Point(0, 51);
            dataView_students.Name = "dataView_students";
            dataView_students.Size = new Size(844, 202);
            dataView_students.TabIndex = 23;
            dataView_students.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InregistrareStudentics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 454);
            Controls.Add(dataView_students);
            Controls.Add(reg_pwd);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(reg_telefon);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(reg_email);
            Controls.Add(reg_nume);
            Controls.Add(reg_data);
            Controls.Add(label3);
            Controls.Add(reg_prenume);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InregistrareStudentics";
            Text = "InregistrareStudentics";
            Load += InregistrareStudentics_Load;
            ((System.ComponentModel.ISupportInitialize)dataView_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

#endregion
        private Label label2;
        private TextBox reg_prenume;
        private Label label1;
        private Label label3;
        private DateTimePicker reg_data;
        private TextBox reg_nume;
        private TextBox reg_email;
        private Label label4;
        private TextBox reg_telefon;
        private Label label5;
        private Button button1;
        private Panel panel2;
        private TextBox reg_pwd;
        private Label label7;
        private DataGridView dataView_students;
    }
}