using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otello
{
    public partial class Rezervasyon : Form
    {

        string connString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";


        public Rezervasyon()
        {
            InitializeComponent();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(currentDirectory, "ico.ico");
            Icon formIcon = new Icon(iconPath);
            this.Icon = formIcon;
            comboBox1.Items.Add("Family");
            comboBox1.Items.Add("Luxurious");
            comboBox1.Items.Add("Royalty");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();
            if (selectedCategory == "Family")
            {
                comboBox2.Items.Add("101");
                comboBox2.Items.Add("102");
                comboBox2.Items.Add("103");
                comboBox2.Items.Add("104");
                comboBox2.Items.Add("105");
            }
            else if (selectedCategory == "Luxurious")
            {
                comboBox2.Items.Add("201");
                comboBox2.Items.Add("202");
                comboBox2.Items.Add("203");
            }
            else if (selectedCategory == "Royalty")
            {
                comboBox2.Items.Add("301");
                comboBox2.Items.Add("302");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (CheckReservationAvailability(startDate, endDate))
            {

                int roomId = Convert.ToInt32(comboBox2.SelectedValue);
                InsertReservation(roomId, startDate, endDate);
                MessageBox.Show("Rezervasyon başarıyla yapıldı.");
            }
            else
            {

                MessageBox.Show("Seçilen tarihlerde oda dolu. Lütfen farklı bir tarih aralığı seçin.");
            }
        }

        private void InsertReservation(int roomId, DateTime startDate, DateTime endDate)
        {
            string query = "INSERT INTO reservations (room_id, start_date, end_date) VALUES (@roomId, @startDate, @endDate)";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    command.ExecuteNonQuery();
                }
            }

        }
        private bool CheckReservationAvailability(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT COUNT(*) FROM reservations WHERE room_id = @roomId AND (start_date <= @endDate AND end_date >= @startDate)";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    int roomId = Convert.ToInt32(comboBox2.SelectedValue);
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count == 0;
                }
            }
        }
    }
}
