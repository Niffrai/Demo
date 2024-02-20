using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\as31l\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pass = textBox2.Text;
            string query = "SELECT ���� FROM Rabotnik WHERE ����� = @Login AND ������ = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", log);
                command.Parameters.AddWithValue("@Password", pass);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result.ToString() == "�����")
                    {
                        Form3 loginForm = new Form3();
                        loginForm.ShowDialog(); 
                    }
                    if (result.ToString() == "�����")
                    {
                        Form2 loginForm = new Form2();
                        loginForm.ShowDialog();
                    }
                    if (result.ToString() == "���������")
                    {
                        Form6 loginForm = new Form6();
                        loginForm.ShowDialog();
                    }
                    if (result != null)
                    {
                        Console.WriteLine("���� ������������: " + result.ToString());
                    }
                    else
                    {
                        Console.WriteLine("������������ � ���������� ������� � ������� �� ������");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("������: " + ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}