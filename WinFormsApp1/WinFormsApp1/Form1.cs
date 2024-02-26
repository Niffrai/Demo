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

            // Проверка наличия значения в полях
            if (string.IsNullOrWhiteSpace(log) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return; // Прекращаем выполнение метода, так как не все поля заполнены
            }

            // Проверка длины пароля
            if (pass.Length < 6 || pass.Length > 8)
            {
                MessageBox.Show("Пароль должен содержать от 6 до 8 символов.");
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
                MessageBox.Show("Пароль должен содержать хотя бы одну заглавную букву и не только цифры.");
                return;
            }

            string query = "SELECT Роль FROM Rabotnik WHERE Логин = @Login AND Пароль = @Password";

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
                        if (result.ToString() == "Повар")
                        {
                            Form3 loginForm = new Form3();
                            loginForm.ShowDialog();
                        }
                        else if (result.ToString() == "Админ")
                        {
                            Form2 loginForm = new Form2();
                            loginForm.ShowDialog();
                        }
                        else if (result.ToString() == "Оффициант")
                        {
                            Form6 loginForm = new Form6();
                            loginForm.ShowDialog();
                        }
                        Console.WriteLine("Роль пользователя: " + result.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Пользователь с указанными логином и паролем не найден");
                        MessageBox.Show("Неверный логин или пароль.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                    MessageBox.Show("Ошибка при входе: " + ex.Message);
                }
            }
        }
    }
}