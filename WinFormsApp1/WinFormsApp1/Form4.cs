using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private DateTime dailyTime;
        public Form4()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            dailyTime = GetDailyTimeFromDatabase();

            // Запускаем таймер
            Timer timer = new Timer();
            timer.Interval = 60000; // Проверка каждую минуту (60000 миллисекунд)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\as31l\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataIntoDataGridView()
        {
            DataTable dataTables = new DataTable();
            string querys = "SELECT * FROM zakaz_vrem";

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
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Получаем текущее время
            DateTime currentTime = DateTime.Now;

            // Сравниваем текущее время с суточным временем
            if (currentTime.Hour >= dailyTime.Hour && currentTime.Minute >= dailyTime.Minute)
            {
                // Очищаем базу данных
                ClearDatabase();
            }
        }

        private DateTime GetDailyTimeFromDatabase()
        {
            DateTime time = DateTime.MinValue;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ЧасыСмены FROM Rabotnik", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string timeString = reader.GetString(0); // Получаем строку с временем
                    time = DateTime.ParseExact(timeString, "HH:mm", CultureInfo.InvariantCulture); // Преобразуем строку в DateTime
                }
                reader.Close();
            }
            return time;
        }

        private void ClearDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM zakaz_vrem", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
