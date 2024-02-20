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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\as31l\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO zakaz (Блюдо, Человек, Стол, СтатусОплаты) VALUES (@Value1, @Value2, @Value3, @Value4)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавляем параметры к запросу
                    command.Parameters.AddWithValue("@Value1", comboBox1.Text);
                    command.Parameters.AddWithValue("@Value2", textBox1.Text);
                    command.Parameters.AddWithValue("@Value3", textBox2.Text);
                    command.Parameters.AddWithValue("@Value4", comboBox2.Text);

                    // Открываем соединение и выполняем запрос
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
