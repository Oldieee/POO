namespace Unilog
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_grupe = new Button();
            btn_cadre = new Button();
            btn_studenti = new Button();
            panel7 = new Panel();
            btn_programe = new Button();
            panel_grupe = new Panel();
            grupe_view = new Label();
            grupe_edit = new Label();
            panel_cadre = new Panel();
            cadre_reg = new Label();
            cadre_note = new Label();
            cadre_edit = new Label();
            panel_studenti = new Panel();
            studeni_reg = new Label();
            studeni_note = new Label();
            studeni_edit = new Label();
            panel_programe = new Panel();
            programe_ciclu = new Label();
            programe_ani = new Label();
            programe_studii = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel_grupe.SuspendLayout();
            panel_cadre.SuspendLayout();
            panel_studenti.SuspendLayout();
            panel_programe.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 652);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(773, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(106, 176, 160);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(264, 536);
            panel5.Name = "panel5";
            panel5.Size = new Size(783, 117);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(468, 36);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 9;
            label5.Text = "Select Class:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(602, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 28);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 36);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 7;
            label4.Text = "Total Students:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(106, 176, 160);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(264, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(782, 90);
            panel4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(145, 54);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 9;
            label7.Text = "Admin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(145, 22);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 8;
            label6.Text = "Untibv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 50);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 7;
            label3.Text = "Role:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 17);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 6;
            label2.Text = "Welcome:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(274, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 82);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(106, 176, 160);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(369, 32);
            label1.TabIndex = 8;
            label1.Text = "Universitatea Transilvania";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(106, 176, 160);
            panel2.Controls.Add(btn_grupe);
            panel2.Controls.Add(btn_cadre);
            panel2.Controls.Add(btn_studenti);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel_grupe);
            panel2.Controls.Add(panel_cadre);
            panel2.Controls.Add(panel_studenti);
            panel2.Controls.Add(panel_programe);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 652);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // btn_grupe
            // 
            btn_grupe.FlatAppearance.BorderSize = 0;
            btn_grupe.FlatStyle = FlatStyle.Flat;
            btn_grupe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_grupe.ForeColor = Color.White;
            btn_grupe.Location = new Point(24, 491);
            btn_grupe.Name = "btn_grupe";
            btn_grupe.Size = new Size(124, 39);
            btn_grupe.TabIndex = 21;
            btn_grupe.Text = "Grupe";
            btn_grupe.UseVisualStyleBackColor = true;
            btn_grupe.Click += button4_Click;
            // 
            // btn_cadre
            // 
            btn_cadre.FlatAppearance.BorderSize = 0;
            btn_cadre.FlatStyle = FlatStyle.Flat;
            btn_cadre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadre.ForeColor = Color.White;
            btn_cadre.Location = new Point(24, 326);
            btn_cadre.Name = "btn_cadre";
            btn_cadre.Size = new Size(167, 39);
            btn_cadre.TabIndex = 20;
            btn_cadre.Text = "Cadre didactice";
            btn_cadre.UseVisualStyleBackColor = true;
            // 
            // btn_studenti
            // 
            btn_studenti.FlatAppearance.BorderSize = 0;
            btn_studenti.FlatStyle = FlatStyle.Flat;
            btn_studenti.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_studenti.ForeColor = Color.White;
            btn_studenti.Location = new Point(24, 173);
            btn_studenti.Name = "btn_studenti";
            btn_studenti.Size = new Size(124, 35);
            btn_studenti.TabIndex = 1;
            btn_studenti.Text = "Studenți";
            btn_studenti.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_programe);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(273, 62);
            panel7.TabIndex = 19;
            // 
            // btn_programe
            // 
            btn_programe.FlatAppearance.BorderSize = 0;
            btn_programe.FlatStyle = FlatStyle.Flat;
            btn_programe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_programe.ForeColor = Color.White;
            btn_programe.Location = new Point(24, 6);
            btn_programe.Name = "btn_programe";
            btn_programe.Size = new Size(124, 39);
            btn_programe.TabIndex = 0;
            btn_programe.Text = "Programe";
            btn_programe.UseVisualStyleBackColor = true;
            // 
            // panel_grupe
            // 
            panel_grupe.Controls.Add(grupe_view);
            panel_grupe.Controls.Add(grupe_edit);
            panel_grupe.Location = new Point(2, 536);
            panel_grupe.Name = "panel_grupe";
            panel_grupe.Size = new Size(271, 113);
            panel_grupe.TabIndex = 18;
            // 
            // grupe_view
            // 
            grupe_view.AutoSize = true;
            grupe_view.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grupe_view.ForeColor = Color.White;
            grupe_view.Location = new Point(43, 16);
            grupe_view.Name = "grupe_view";
            grupe_view.Size = new Size(92, 20);
            grupe_view.TabIndex = 13;
            grupe_view.Text = "Vizualizare";
            grupe_view.Click += label14_Click;
            // 
            // grupe_edit
            // 
            grupe_edit.AutoSize = true;
            grupe_edit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grupe_edit.ForeColor = Color.White;
            grupe_edit.Location = new Point(43, 56);
            grupe_edit.Name = "grupe_edit";
            grupe_edit.Size = new Size(62, 20);
            grupe_edit.TabIndex = 14;
            grupe_edit.Text = "Editare";
            // 
            // panel_cadre
            // 
            panel_cadre.Controls.Add(cadre_reg);
            panel_cadre.Controls.Add(cadre_note);
            panel_cadre.Controls.Add(cadre_edit);
            panel_cadre.Location = new Point(2, 371);
            panel_cadre.Name = "panel_cadre";
            panel_cadre.Size = new Size(271, 111);
            panel_cadre.TabIndex = 17;
            // 
            // cadre_reg
            // 
            cadre_reg.AutoSize = true;
            cadre_reg.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadre_reg.ForeColor = Color.White;
            cadre_reg.Location = new Point(43, 12);
            cadre_reg.Name = "cadre_reg";
            cadre_reg.Size = new Size(94, 20);
            cadre_reg.TabIndex = 10;
            cadre_reg.Text = "Înregistrare";
            // 
            // cadre_note
            // 
            cadre_note.AutoSize = true;
            cadre_note.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadre_note.ForeColor = Color.White;
            cadre_note.Location = new Point(43, 81);
            cadre_note.Name = "cadre_note";
            cadre_note.Size = new Size(44, 20);
            cadre_note.TabIndex = 12;
            cadre_note.Text = "Note";
            // 
            // cadre_edit
            // 
            cadre_edit.AutoSize = true;
            cadre_edit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadre_edit.ForeColor = Color.White;
            cadre_edit.Location = new Point(43, 46);
            cadre_edit.Name = "cadre_edit";
            cadre_edit.Size = new Size(62, 20);
            cadre_edit.TabIndex = 11;
            cadre_edit.Text = "Editare";
            // 
            // panel_studenti
            // 
            panel_studenti.Controls.Add(studeni_reg);
            panel_studenti.Controls.Add(studeni_note);
            panel_studenti.Controls.Add(studeni_edit);
            panel_studenti.Location = new Point(1, 214);
            panel_studenti.Name = "panel_studenti";
            panel_studenti.Size = new Size(273, 112);
            panel_studenti.TabIndex = 16;
            // 
            // studeni_reg
            // 
            studeni_reg.AutoSize = true;
            studeni_reg.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studeni_reg.ForeColor = Color.White;
            studeni_reg.Location = new Point(41, 10);
            studeni_reg.Name = "studeni_reg";
            studeni_reg.Size = new Size(94, 20);
            studeni_reg.TabIndex = 7;
            studeni_reg.Text = "Înregistrare";
            // 
            // studeni_note
            // 
            studeni_note.AutoSize = true;
            studeni_note.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studeni_note.ForeColor = Color.White;
            studeni_note.Location = new Point(41, 77);
            studeni_note.Name = "studeni_note";
            studeni_note.Size = new Size(44, 20);
            studeni_note.TabIndex = 9;
            studeni_note.Text = "Note";
            // 
            // studeni_edit
            // 
            studeni_edit.AutoSize = true;
            studeni_edit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studeni_edit.ForeColor = Color.White;
            studeni_edit.Location = new Point(41, 44);
            studeni_edit.Name = "studeni_edit";
            studeni_edit.Size = new Size(62, 20);
            studeni_edit.TabIndex = 8;
            studeni_edit.Text = "Editare";
            // 
            // panel_programe
            // 
            panel_programe.Controls.Add(programe_ciclu);
            panel_programe.Controls.Add(programe_ani);
            panel_programe.Controls.Add(programe_studii);
            panel_programe.Location = new Point(1, 51);
            panel_programe.Name = "panel_programe";
            panel_programe.Size = new Size(273, 116);
            panel_programe.TabIndex = 15;
            // 
            // programe_ciclu
            // 
            programe_ciclu.AutoSize = true;
            programe_ciclu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programe_ciclu.ForeColor = Color.White;
            programe_ciclu.Location = new Point(41, 11);
            programe_ciclu.Name = "programe_ciclu";
            programe_ciclu.Size = new Size(167, 20);
            programe_ciclu.TabIndex = 4;
            programe_ciclu.Text = "Cicluri de învățământ";
            // 
            // programe_ani
            // 
            programe_ani.AutoSize = true;
            programe_ani.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programe_ani.ForeColor = Color.White;
            programe_ani.Location = new Point(41, 81);
            programe_ani.Name = "programe_ani";
            programe_ani.Size = new Size(106, 20);
            programe_ani.TabIndex = 6;
            programe_ani.Text = "Ani de studiu";
            programe_ani.Click += label7_Click;
            // 
            // programe_studii
            // 
            programe_studii.AutoSize = true;
            programe_studii.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programe_studii.ForeColor = Color.White;
            programe_studii.Location = new Point(41, 48);
            programe_studii.Name = "programe_studii";
            programe_studii.Size = new Size(141, 20);
            programe_studii.TabIndex = 5;
            programe_studii.Text = "Program de studii";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1043, 653);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel_grupe.ResumeLayout(false);
            panel_grupe.PerformLayout();
            panel_cadre.ResumeLayout(false);
            panel_cadre.PerformLayout();
            panel_studenti.ResumeLayout(false);
            panel_studenti.PerformLayout();
            panel_programe.ResumeLayout(false);
            panel_programe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label programe_ani;
        private Label programe_studii;
        private Label programe_ciclu;
        private Label grupe_edit;
        private Label grupe_view;
        private Label cadre_note;
        private Label cadre_edit;
        private Label cadre_reg;
        private Label studeni_note;
        private Label studeni_edit;
        private Label studeni_reg;
        private Panel panel_programe;
        private Panel panel_grupe;
        private Panel panel_cadre;
        private Panel panel_studenti;
        private Panel panel7;
        private Button btn_programe;
        private Button btn_grupe;
        private Button btn_cadre;
        private Button btn_studenti;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
    }
}