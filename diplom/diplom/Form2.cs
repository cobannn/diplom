using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace diplom
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=baha1;Username=root;Password=0911;";

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string username = UserNameBox.Text;
            string newPassword = PasswordBox.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(newPassword))
            {
                ChangeUserPassword(username, newPassword);
            }
            else
            {
                MessageBox.Show("Please enter both username and new password.");
            }
        }

        private void ChangeUserPassword(string username, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE users SET Password = @newPassword WHERE UserName = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password changed successfully.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User not found or password not changed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserNameBox.Text;
            string newPassword = PasswordBox.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(newPassword))
            {
                ChangeUserPassword(username, newPassword);
            }
            else
            {
                MessageBox.Show("Please enter both username and new password.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
