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
    public partial class Form2 : Form
    {
        private string connectionString = Form1.connectionString;
        public Form2()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();

        }
        private void LoadDataIntoDataGridView()
        {
            DataTable dataTable = new DataTable();
            DataTable dataTables = new DataTable();
            string query = "SELECT * FROM Rabotnik";
            string querys = "SELECT * FROM zakaz";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }

            }
            dataGridView2.DataSource = dataTable;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(querys, connection);

                try
                {
                    adapter.Fill(dataTables);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
                connection.Close();
            }
            dataGridView1.DataSource = dataTables;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 loginForm = new Form5();
            loginForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable modifiedDataTable = (DataTable)dataGridView1.DataSource;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM zakaz", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                try
                {
                    connection.Open();
                    adapter.Update(modifiedDataTable);

                    MessageBox.Show("Данные успешно обновлены в базе данных.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable modifiedDataTable = (DataTable)dataGridView2.DataSource;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Rabotnik", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                try
                {
                    connection.Open();
                    adapter.Update(modifiedDataTable);

                    MessageBox.Show("Данные успешно обновлены в базе данных.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string shiftValue = textBox1.Text;
            string shiftHours = textBox2.Text;


            UpdateShiftHours(shiftValue, shiftHours);
        }
        private void UpdateShiftHours(string shiftValue, string shiftHours)
        {

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // Получаем значение в столбце "Смена" текущей строки
                object shiftCellValue = row.Cells["Смена"].Value;

                if (shiftCellValue != null && shiftCellValue.ToString() == "1")
                {
                    row.Cells["ЧасыСмены"].Value = shiftValue;
                }
                if (shiftCellValue != null && shiftCellValue.ToString() == "2")
                {
                    row.Cells["ЧасыСмены"].Value = shiftHours;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
