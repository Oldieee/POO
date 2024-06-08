using System.Data;
using System.Data.SqlClient;
namespace Unilog
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\olada\OneDrive\Documente\loginData.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPwd.Checked)
            {
                login_pwd.PasswordChar = '\0';
            }
            else
            {
                login_pwd.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_pwd.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State!= ConnectionState.Open)
                {
                    try { 
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username= @username AND pwd=@pwd";
                        using(SqlCommand cmd=new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("username", login_username.Text);
                            cmd.Parameters.AddWithValue ("pwd", login_pwd.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mForm= new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch(Exception ex) {
                        MessageBox.Show("Error Connecting:"+ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }
                }
            }
        }
    }
}

