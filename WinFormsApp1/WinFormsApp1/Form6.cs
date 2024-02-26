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
        private string connectionString = Form1.connectionString;

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 loginForm = new Form4();
            loginForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }

            string selectedItemsString = string.Join(", ", selectedItems);
            // Проверка, что поля не пустые перед вставкой в таблицу zakaz
            if (!string.IsNullOrEmpty(selectedItemsString) && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                string query = "INSERT INTO zakaz (Блюдо, Человек, Стол, СтатусОплаты) VALUES (@Value1, @Value2, @Value3, @Value4)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", selectedItemsString);
                        command.Parameters.AddWithValue("@Value2", textBox1.Text);
                        command.Parameters.AddWithValue("@Value3", textBox2.Text);
                        command.Parameters.AddWithValue("@Value4", comboBox2.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                string querys = "INSERT INTO zakaz_vrem (Блюдо, Человек, Стол, СтатусОплаты) VALUES (@Value1, @Value2, @Value3, @Value4)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(querys, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", selectedItemsString);
                        command.Parameters.AddWithValue("@Value2", textBox1.Text);
                        command.Parameters.AddWithValue("@Value3", textBox2.Text);
                        command.Parameters.AddWithValue("@Value4", comboBox2.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                selectedItems.Clear();
                checkedListBox1.ClearSelected();
                textBox1.Clear();
                textBox2.Clear();

                MessageBox.Show("Данные успешно добавлены в базу данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
