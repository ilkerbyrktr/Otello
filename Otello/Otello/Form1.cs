using Npgsql;

namespace Otello
{
    public partial class Form1 : Form
    {
        private const string ConString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";

        public Form1()
        {
            InitializeComponent();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(currentDirectory, "ico.ico");
            Icon formIcon = new Icon(iconPath);
            this.Icon = formIcon;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = tb_username.Text;
            string password = tb_password.Text;


            using (NpgsqlConnection connection = new NpgsqlConnection(ConString))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        string role = GetRole(username);
                        if (role == "manager")
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else if (role == "user")
                        {
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                        }
                        else if (role == "worker")
                        {
                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password ");
                    }
                }
            }
        }
        private string GetRole(string username)
        {
            {
                string role = "";

                string connString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";

                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string sql = "SELECT role FROM users WHERE username = @username";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            role = result.ToString();
                        }
                    }

                    conn.Close();
                }

                return role;
            }



        }

        public void thisClose() {
            
            this.Close();

        }
    }
}