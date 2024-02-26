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

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\as31l\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string role = textBox3.Text;
            string login = textBox1.Text;
            string password = textBox2.Text;
            string fullName = textBox4.Text;

            // Проверка наличия значений в полях
            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return; // Прекращаем выполнение метода, так как не все поля заполнены
            }

            // Создание SQL-запроса для вставки новой записи
            string query = "INSERT INTO Rabotnik (Роль, Логин, Пароль, ФИ) VALUES (@Role, @Login, @Password, @FullName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FullName", fullName);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Новая запись успешно добавлена в базу данных.");
                        // Очистка полей формы после успешного добавления записи
                        textBox3.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Добавление новой записи не удалось.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении новой записи: " + ex.Message);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
