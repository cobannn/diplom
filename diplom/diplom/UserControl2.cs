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
    public partial class UserControl2 : UserControl
    {
        private MySqlConnection connection;
        private string connectionString;
        private DataTable dataTable;

        public UserControl2()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Port=3306;Database=baha1;Username=root;Password=0911;";
            this.Load += UserControl2_Load;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT idTasks, Ttask, BeginningTtask, EndTask, TaskStatus FROM tasks";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    if (dataGridView1.Columns.Contains("Ttask"))
                        dataGridView1.Columns["Ttask"].HeaderText = "Задача";
                    if (dataGridView1.Columns.Contains("BeginningTtask"))
                        dataGridView1.Columns["BeginningTtask"].HeaderText = "Начало";
                    if (dataGridView1.Columns.Contains("EndTask"))
                        dataGridView1.Columns["EndTask"].HeaderText = "Окончание";
                    if (dataGridView1.Columns.Contains("TaskStatus"))
                        dataGridView1.Columns["TaskStatus"].HeaderText = "Статус";
                    dataGridView1.Columns["idTasks"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void SaveChanges()
        {
            if (dataTable == null)
            {
                MessageBox.Show("Таблица данных не инициализирована.");
                return;
            }

            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    adapter.UpdateCommand = new MySqlCommand(
                        "UPDATE tasks SET Ttask = @Task, BeginningTtask = @BeginningTtask, EndTask = @EndTask, TaskStatus = @TaskStatus WHERE idTasks = @idTasks",
                        connection);
                    adapter.UpdateCommand.Parameters.Add("@Task", MySqlDbType.VarChar, 255, "Ttask");
                    adapter.UpdateCommand.Parameters.Add("@BeginningTtask", MySqlDbType.DateTime, 0, "BeginningTtask");
                    adapter.UpdateCommand.Parameters.Add("@EndTask", MySqlDbType.DateTime, 0, "EndTask");
                    adapter.UpdateCommand.Parameters.Add("@TaskStatus", MySqlDbType.VarChar, 50, "TaskStatus");

                    var parameter = adapter.UpdateCommand.Parameters.Add("@OriginalTask", MySqlDbType.VarChar, 255, "Task");
                    parameter.SourceVersion = DataRowVersion.Original;

                    adapter.InsertCommand = new MySqlCommand(
                       "INSERT INTO tasks (Ttask, BeginningTtask, EndTask, TaskStatus) VALUES (@Task, @BeginningTtask, @EndTask, @TaskStatus)",
                       connection);
                    adapter.InsertCommand.Parameters.Add("@Task", MySqlDbType.VarChar, 255, "Ttask");
                    adapter.InsertCommand.Parameters.Add("@BeginningTtask", MySqlDbType.DateTime, 0, "BeginningTtask");
                    adapter.InsertCommand.Parameters.Add("@EndTask", MySqlDbType.DateTime, 0, "EndTask");
                    adapter.InsertCommand.Parameters.Add("@TaskStatus", MySqlDbType.VarChar, 50, "TaskStatus");

                    adapter.Update(dataTable);
                    MessageBox.Show("Изменения сохранены!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
