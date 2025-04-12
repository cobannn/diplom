using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace diplom
{
    public partial class sotrudnici: UserControl
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=baha1;Username=root;Password=0911;";
        private DataTable dataTable;
        public sotrudnici()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadVacationData();
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadVacationData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT idVacasion, TheBeginninVacation, EndVacation, Users_idUsers FROM vacasion";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataTable.Columns.Add("EmployeeName", typeof(string));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        row["EmployeeName"] = GetUserName(conn, Convert.ToInt32(row["Users_idUsers"]));
                    }

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["idVacasion"].HeaderText = "ID";
                    dataGridView1.Columns["TheBeginninVacation"].HeaderText = "Начало";
                    dataGridView1.Columns["EndVacation"].HeaderText = "Конец";
                    dataGridView1.Columns["Users_idUsers"].HeaderText = "ID пользователя";
                    dataGridView1.Columns["EmployeeName"].HeaderText = "Сотрудник";
                    dataGridView1.Columns["EmployeeName"].ReadOnly = true;
                    
                    dataGridView1.Columns["TheBeginninVacation"].DefaultCellStyle.Format = "dd.MM.yyyy";
                    dataGridView1.Columns["EndVacation"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUserName(MySqlConnection conn, int userId)
        {
            string query = "SELECT UserName FROM users WHERE idUsers = @userId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            return cmd.ExecuteScalar()?.ToString() ?? "Неизвестно";
        }
    }
}
