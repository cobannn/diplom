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
    public partial class vacasion: UserControl
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=baha1;Username=root;Password=0911;";
        private DataTable dataTable;
        private const int DefaultUserId = 1;
        public vacasion()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadPhoneBookData();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = false;
        }

        private void LoadPhoneBookData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT idPhoneDook, FIO, PhoneNumber, LandlinePhoneNumbers, Post, Department 
                                    FROM phonedook 
                                    WHERE Users_idUsers = @userId";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", DefaultUserId);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataTable.Columns.Add("Users_idUsers", typeof(int)).DefaultValue = DefaultUserId;

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["idPhoneDook"].HeaderText = "ID";
                    dataGridView1.Columns["FIO"].HeaderText = "ФИО";
                    dataGridView1.Columns["PhoneNumber"].HeaderText = "Мобильный телефон";
                    dataGridView1.Columns["LandlinePhoneNumbers"].HeaderText = "Рабочий телефон";
                    dataGridView1.Columns["Post"].HeaderText = "Должность";
                    dataGridView1.Columns["Department"].HeaderText = "Отдел";

                    // Скрываем технический столбец
                    dataGridView1.Columns["Users_idUsers"].Visible = false;

                    // Настройка ширины столбцов
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
