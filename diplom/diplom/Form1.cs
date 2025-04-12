using MySql.Data.MySqlClient;

namespace diplom
{

    public partial class Form1 : Form
    { 
        private Dictionary<string, int> loginAttempts = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent(); 
            
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = UserNameBox.Text;
            string password = PasswordBox.Text;
            string connectionString = "Server=127.0.0.1;Port=3306;Database=baha1;Username=root;Password=0911;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // ���������, �� ������������ �� ������������
                    string checkBlockedQuery = "SELECT Blocked FROM users WHERE UserName = @UserName";
                    MySqlCommand checkBlockedCmd = new MySqlCommand(checkBlockedQuery, conn);
                    checkBlockedCmd.Parameters.AddWithValue("@UserName", login);

                    object blockedStatus = checkBlockedCmd.ExecuteScalar();

                    if (blockedStatus != null && Convert.ToBoolean(blockedStatus))
                    {
                        MessageBox.Show("��� ������� ������������. ���������� � ��������������.");
                        return;
                    }

                    // ��������� ����� � ������
                    string authQuery = "SELECT COUNT(*) FROM users WHERE UserName = @UserName AND password = @password";
                    MySqlCommand authCmd = new MySqlCommand(authQuery, conn);
                    authCmd.Parameters.AddWithValue("@UserName", login);
                    authCmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(authCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // ����� �������� ��� �������� �����
                        if (loginAttempts.ContainsKey(login))
                        {
                            loginAttempts.Remove(login);
                        }

                        MainWindow mainForm = new MainWindow();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (!loginAttempts.ContainsKey(login))
                        {
                            loginAttempts.Add(login, 1);
                        }
                        else
                        {
                            loginAttempts[login]++;
                        }

                        int attemptsLeft = 3 - loginAttempts[login];

                        if (attemptsLeft > 0)
                        {
                            MessageBox.Show($"�������� ��� ������������ ��� ������. �������� �������: {attemptsLeft}");
                        }
                        else
                        {
                            // ��������� ������������ � ��
                            string blockQuery = "UPDATE users SET is_blocked = TRUE WHERE UserName = @UserName";
                            MySqlCommand blockCmd = new MySqlCommand(blockQuery, conn);
                            blockCmd.Parameters.AddWithValue("@UserName", login);
                            blockCmd.ExecuteNonQuery();

                            MessageBox.Show("��������� ���������� ������� �����. ��� ������� ������������.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
