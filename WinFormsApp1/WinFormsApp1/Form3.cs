using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }
        private string connectionString = Form1.connectionString;

        private void LoadDataIntoDataGridView()
        {
            DataTable dataTables = new DataTable();
            string querys = "SELECT Блюдо, Человек, Стол, СтатусГотовки FROM zakaz";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable modifiedDataTable = (DataTable)dataGridView1.DataSource;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Блюдо, Человек, Стол, СтатусГотовки FROM zakaz", connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
