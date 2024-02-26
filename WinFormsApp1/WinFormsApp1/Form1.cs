using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\as31l\\source\\repos\\kek\\Demo\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pass = textBox2.Text;

            // �������� ������� �������� � �����
            if (string.IsNullOrWhiteSpace(log) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("����������, ������� ����� � ������.");
                return; // ���������� ���������� ������, ��� ��� �� ��� ���� ���������
            }

            // �������� ����� ������
            if (pass.Length < 6 || pass.Length > 8)
            {
                MessageBox.Show("������ ������ ��������� �� 6 �� 8 ��������.");
                return;
            }

            bool hasUpperCase = false;
            bool hasDigit = false;

            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }

            if (!hasUpperCase || !hasDigit)
            {
                MessageBox.Show("������ ������ ��������� ���� �� ���� ��������� ����� � �� ������ �����.");
                return;
            }

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

                    if (result != null)
                    {
                        if (result.ToString() == "�����")
                        {
                            Form3 loginForm = new Form3();
                            loginForm.ShowDialog();
                        }
                        else if (result.ToString() == "�����")
                        {
                            Form2 loginForm = new Form2();
                            loginForm.ShowDialog();
                        }
                        else if (result.ToString() == "���������")
                        {
                            Form6 loginForm = new Form6();
                            loginForm.ShowDialog();
                        }
                        Console.WriteLine("���� ������������: " + result.ToString());
                    }
                    else
                    {
                        Console.WriteLine("������������ � ���������� ������� � ������� �� ������");
                        MessageBox.Show("�������� ����� ��� ������.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("������: " + ex.Message);
                    MessageBox.Show("������ ��� �����: " + ex.Message);
                }
            }
        }
    }
}