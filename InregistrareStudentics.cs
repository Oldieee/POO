using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unilog
{
    public partial class InregistrareStudentics : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\olada\OneDrive\Documente\loginData.mdf;Integrated Security=True;Connect Timeout=30");

        public InregistrareStudentics()
        {
            InitializeComponent();
            LoadDataIntoGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(reg_nume.Text) ||
                string.IsNullOrWhiteSpace(reg_prenume.Text) ||
                string.IsNullOrWhiteSpace(reg_pwd.Text) ||
                string.IsNullOrWhiteSpace(reg_email.Text) ||
                string.IsNullOrWhiteSpace(reg_data.Text) ||
                string.IsNullOrWhiteSpace(reg_telefon.Text))
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
                        string checkEmail = "SELECT COUNT(*) FROM reg WHERE email = @Email";
                        using (SqlCommand checkUser = new SqlCommand(checkEmail, connect))
                        {
                            checkUser.Parameters.AddWithValue("@Email", reg_email.Text.Trim());
                            int userCount = (int)checkUser.ExecuteScalar();
                            if (userCount > 0)
                            {
                                MessageBox.Show(reg_email.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO reg(nume, prenume, telefon, email, pwd,  data_created) " +
                                                    "VALUES(@nume, @prenume, @telefon, @email, @pwd,  @date)";
                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@nume", reg_nume.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prenume", reg_prenume.Text.Trim());
                                    cmd.Parameters.AddWithValue("@telefon", reg_telefon.Text.Trim());
                                    cmd.Parameters.AddWithValue("email", reg_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pwd", reg_pwd.Text.Trim());

                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDataIntoGrid();
                                    InregistrareStudentics reg = new InregistrareStudentics();
                                    
                                    reg.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }
        public void LoadDataIntoGrid()
        {
            // Define the connection string (update with your actual connection string)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\olada\OneDrive\Documente\loginData.mdf;Integrated Security=True;Connect Timeout=30";

            // Define the query to retrieve data from your table (update with your actual query)
            string query = "SELECT * FROM reg";  // Replace 'your_table_name' with your actual table name

            // Create a new SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fill the DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the query
                        adapter.Fill(dataTable);

                        // Set the DataGridView's DataSource to the DataTable
                        dataView_students.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InregistrareStudentics_Load(object sender, EventArgs e)
        {

        }
        private void ShowTable()
        {
            string query = "SELECT * FROM your_table_name";  // Replace 'your_table_name' with your actual table name

            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataView_students.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
