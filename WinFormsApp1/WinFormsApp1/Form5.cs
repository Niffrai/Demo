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
        private string connectionString = Form1.connectionString;

        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string role = textBox3.Text;
            string login = textBox1.Text;
            string password = textBox2.Text;
            string fullName = textBox4.Text;

            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (password.Length < 6 || password.Length > 8)
            {
                MessageBox.Show("Пароль должен содержать от 6 до 8 символов.");
                return;
            }

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну букву верхнего регистра.");
                return;
            }

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

    }
}
