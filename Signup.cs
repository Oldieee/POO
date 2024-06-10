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

namespace Unilog
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\olada\OneDrive\Documente\loginData.mdf;Integrated Security=True;Connect Timeout=30");
        public Signup()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPwd.Checked)
            {
                signup_pwd.PasswordChar = '\0';
            }
            else
            {
                signup_pwd.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_email.Text == "" || signup_username.Text == "" || signup_pwd.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '" + signup_username.Text.Trim() + "'";
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + "is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO admin(email,username,pwd,data_created)" +
                                    "VALUES(@email,@username,@pwd,@date)";
                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pwd", signup_pwd.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 lForm = new Form1();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }


                }
            }
        }

        private void signup_pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
