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

namespace Otello
{
    public partial class Edit : Form
    {

        public Edit()
        {
            InitializeComponent();


            string[] mesai = new string[] { "08-17", "09-18", "10-19", "11-20", "12-21", "13-22" };
            for (int i = 1; i <= 21; i++)
            {
                ComboBox comboBox = Controls.Find("comboBox" + i.ToString(), true).FirstOrDefault() as ComboBox;
                if (comboBox != null)
                {
                    comboBox.Items.AddRange(mesai);
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilpts();
            ilsl();
            ilcrs();
            ilprs();
            ilcm();
            ilcts();
            ilpz();

            bypts();
            bysl();
            bycrs();
            byprs();
            bycm();
            bycts();
            bypz();

            mipts();
            misl();
            micrs();
            miprs();
            micm();
            micts();
            mipz();

            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void ilpts()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox1.SelectedItem.ToString();
            int userId = 1;
            string gun = "Pazartesi";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");

            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void ilsl()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox2.SelectedItem.ToString();
            int userId = 1;
            string gun = "Salı";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void ilcrs()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox3.SelectedItem.ToString();
            int userId = 1;
            string gun = "Çarşamba";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        private void ilprs()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox4.SelectedItem.ToString();
            int userId = 1;
            string gun = "Perşembe";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        private void ilcm()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox5.SelectedItem.ToString();
            int userId = 1;
            string gun = "Cuma";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }
        private void ilcts()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox6.SelectedItem.ToString();
            int userId = 1;
            string gun = "Cumartesi";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void ilpz()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox7.SelectedItem.ToString();
            int userId = 1;
            string gun = "Pazar";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void bypts()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox8.SelectedItem.ToString();
            int userId = 2;
            string gun = "Pazartesi";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");

            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void bysl()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox9.SelectedItem.ToString();
            int userId = 2;
            string gun = "Salı";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void bycrs()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox10.SelectedItem.ToString();
            int userId = 2;
            string gun = "Çarşamba";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        private void byprs()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox11.SelectedItem.ToString();
            int userId = 2;
            string gun = "Perşembe";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        private void bycm()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox12.SelectedItem.ToString();
            int userId = 2;
            string gun = "Cuma";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }
        private void bycts()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox13.SelectedItem.ToString();
            int userId = 2;
            string gun = "Cumartesi";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void bypz()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox14.SelectedItem.ToString();
            int userId = 2;
            string gun = "Pazar";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void mipts()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox15.SelectedItem.ToString();
            int userId = 3;
            string gun = "Pazartesi";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");

            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void misl()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox16.SelectedItem.ToString();
            int userId = 3;
            string gun = "Salı";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void micrs()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox17.SelectedItem.ToString();
            int userId = 3;
            string gun = "Çarşamba";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        private void miprs()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox18.SelectedItem.ToString();
            int userId = 3;
            string gun = "Perşembe";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        private void micm()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox19.SelectedItem.ToString();
            int userId = 3;
            string gun = "Cuma";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }
        private void micts()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox20.SelectedItem.ToString();
            int userId = 3;
            string gun = "Cumartesi";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void mipz()
        {
            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string selectedRange = comboBox21.SelectedItem.ToString();
            int userId = 3;
            string gun = "Pazar";

            string[] saatler = selectedRange.Split('-');
            TimeSpan baslangicSaat = TimeSpan.Parse(saatler[0] + ":00:00");
            TimeSpan bitisSaat = TimeSpan.Parse(saatler[1] + ":00:00");
            string updateQuery = "UPDATE MesaiSaati SET mesai_baslangic = @baslangicSaat, mesai_bitis = @bitisSaat WHERE user_id = @userId AND gun = @gun";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            updateCommand.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            updateCommand.Parameters.AddWithValue("@userId", userId);
            updateCommand.Parameters.AddWithValue("@gun", gun);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
