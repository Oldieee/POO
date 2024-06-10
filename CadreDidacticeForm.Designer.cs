namespace Unilog
{
    partial class CadreDidacticeForm
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
            label_post = new Label();
            comboBoxTitlu = new ComboBox();
            label_titlu = new Label();
            label_marca_angajat = new Label();
            reg_nume = new TextBox();
            label_nume = new Label();
            reg_prenume = new TextBox();
            label_prenume = new Label();
            dataView_cadre = new DataGridView();
            panel2 = new Panel();
            comboBox_post = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView_cadre).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox_post);
            panel1.Controls.Add(label_post);
            panel1.Controls.Add(comboBoxTitlu);
            panel1.Controls.Add(label_titlu);
            panel1.Controls.Add(label_marca_angajat);
            panel1.Controls.Add(reg_nume);
            panel1.Controls.Add(label_nume);
            panel1.Controls.Add(reg_prenume);
            panel1.Controls.Add(label_prenume);
            panel1.Controls.Add(dataView_cadre);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -32);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 495);
            panel1.TabIndex = 0;
            // 
            // label_post
            // 
            label_post.AutoSize = true;
            label_post.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_post.ForeColor = Color.FromArgb(106, 176, 160);
            label_post.Location = new Point(61, 414);
            label_post.Name = "label_post";
            label_post.Size = new Size(49, 20);
            label_post.TabIndex = 32;
            label_post.Text = "Post: ";
            label_post.Click += label2_Click;
            // 
            // comboBoxTitlu
            // 
            comboBoxTitlu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTitlu.FormattingEnabled = true;
            comboBoxTitlu.Items.AddRange(new object[] { "dr. ", "dr. ing. " });
            comboBoxTitlu.Location = new Point(144, 361);
            comboBoxTitlu.Name = "comboBoxTitlu";
            comboBoxTitlu.Size = new Size(181, 23);
            comboBoxTitlu.TabIndex = 31;
            comboBoxTitlu.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label_titlu
            // 
            label_titlu.AutoSize = true;
            label_titlu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_titlu.ForeColor = Color.FromArgb(106, 176, 160);
            label_titlu.Location = new Point(61, 364);
            label_titlu.Name = "label_titlu";
            label_titlu.Size = new Size(46, 20);
            label_titlu.TabIndex = 30;
            label_titlu.Text = "Titlu: ";
            label_titlu.Click += titlu_Click;
            // 
            // label_marca_angajat
            // 
            label_marca_angajat.AutoSize = true;
            label_marca_angajat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_marca_angajat.ForeColor = Color.FromArgb(106, 176, 160);
            label_marca_angajat.Location = new Point(431, 364);
            label_marca_angajat.Name = "label_marca_angajat";
            label_marca_angajat.Size = new Size(118, 20);
            label_marca_angajat.TabIndex = 29;
            label_marca_angajat.Text = "Marcă angajat: ";
            // 
            // reg_nume
            // 
            reg_nume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_nume.Location = new Point(144, 302);
            reg_nume.Multiline = true;
            reg_nume.Name = "reg_nume";
            reg_nume.Size = new Size(181, 24);
            reg_nume.TabIndex = 28;
            reg_nume.TextChanged += reg_nume_TextChanged;
            // 
            // label_nume
            // 
            label_nume.AutoSize = true;
            label_nume.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nume.ForeColor = Color.FromArgb(106, 176, 160);
            label_nume.Location = new Point(61, 302);
            label_nume.Name = "label_nume";
            label_nume.Size = new Size(59, 20);
            label_nume.TabIndex = 27;
            label_nume.Text = "Nume: ";
            // 
            // reg_prenume
            // 
            reg_prenume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_prenume.Location = new Point(562, 302);
            reg_prenume.Multiline = true;
            reg_prenume.Name = "reg_prenume";
            reg_prenume.Size = new Size(178, 24);
            reg_prenume.TabIndex = 26;
            reg_prenume.TextChanged += reg_prenume_TextChanged;
            // 
            // label_prenume
            // 
            label_prenume.AutoSize = true;
            label_prenume.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_prenume.ForeColor = Color.FromArgb(106, 176, 160);
            label_prenume.Location = new Point(468, 302);
            label_prenume.Name = "label_prenume";
            label_prenume.Size = new Size(81, 20);
            label_prenume.TabIndex = 25;
            label_prenume.Text = "Prenume :";
            // 
            // dataView_cadre
            // 
            dataView_cadre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView_cadre.Location = new Point(3, 85);
            dataView_cadre.Margin = new Padding(0);
            dataView_cadre.Name = "dataView_cadre";
            dataView_cadre.Size = new Size(856, 202);
            dataView_cadre.TabIndex = 24;
            dataView_cadre.CellContentClick += dataView_students_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(106, 176, 160);
            panel2.Location = new Point(3, 32);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 53);
            panel2.TabIndex = 21;
            // 
            // comboBox_post
            // 
            comboBox_post.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_post.FormattingEnabled = true;
            comboBox_post.Items.AddRange(new object[] { "Asistent universitar", "Lector", "Conferentiar universitar ", "Profesor universitar", "CDA" });
            comboBox_post.Location = new Point(144, 414);
            comboBox_post.Name = "comboBox_post";
            comboBox_post.Size = new Size(181, 23);
            comboBox_post.TabIndex = 33;
            // 
            // CadreDidacticeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 454);
            Controls.Add(panel1);
            Name = "CadreDidacticeForm";
            Text = "CadreDidacticeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataView_cadre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataView_cadre;
        private TextBox reg_nume;
        private Label label_nume;
        private TextBox reg_prenume;
        private Label label_prenume;
        private Label label_marca_angajat;
        private Label label_titlu;
        private ComboBox comboBoxTitlu;
        private Label label_post;
        private ComboBox comboBox_post;
    }
}