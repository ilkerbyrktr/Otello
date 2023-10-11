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
    public partial class Shift : Form
    {
        private NpgsqlConnection connection;
        private string secLevel;

        public string SecLevel
        {
            get { return secLevel; }
            set { secLevel = value; }

        }
        public Shift()
        {
            InitializeComponent();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(currentDirectory, "ico.ico");
            Icon formIcon = new Icon(iconPath);
            this.Icon = formIcon;
        }


        private void Shift_Load(object sender, EventArgs e)
        {

            string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=05131994";
            connection = new NpgsqlConnection(connectionString);

            labelsInvisible();
            getUser(secLevel);


        }

        private void getMesaiUser1()
        {
            try
            {
                connection.Open();
                string query = "SELECT gun, mesai_baslangic, mesai_bitis FROM MesaiSaati WHERE user_id = 1";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string gun = reader["gun"].ToString();
                    string mesaiBaslangic = reader["mesai_baslangic"].ToString();
                    string mesaiBitis = reader["mesai_bitis"].ToString();

                    DateTime baslangicDateTime = DateTime.Parse(mesaiBaslangic);
                    string baslangicSaat = baslangicDateTime.ToString("HH");

                    DateTime bitisDateTime = DateTime.Parse(mesaiBitis);
                    string bitisSaat = bitisDateTime.ToString("HH");


                    Label label = null;
                    switch (gun)
                    {
                        case "Pazartesi":
                            label = label11;
                            label.Visible = true;
                            break;
                        case "Salı":
                            label = label12;
                            label.Visible = true;
                            break;
                        case "Çarşamba":
                            label = label13;
                            label.Visible = true;
                            break;
                        case "Perşembe":
                            label = label14;
                            label.Visible = true;
                            break;
                        case "Cuma":
                            label = label15;
                            label.Visible = true;
                            break;
                        case "Cumartesi":
                            label = label16;
                            label.Visible = true;
                            break;
                        case "Pazar":
                            label = label17;
                            label.Visible = true;
                            break;
                        default:
                            break;
                    }

                    label8.Visible = true;
                    if (label != null)
                    {
                        label.Text = baslangicSaat + " - " + bitisSaat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void getUser(string secLevel)
        {

            switch (secLevel)
            {
                case "manager":
                    getMesaiUser1();
                    getMesaiUser2();
                    getMesaiUser3();
                    break;
                case "user":
                    getMesaiUser2();
                    break;
                case "worker":
                    getMesaiUser3();
                    break;
                default: break;
            }

        }


        private void getMesaiUser2()
        {
            try
            {
                connection.Open();
                string query = "SELECT gun, mesai_baslangic, mesai_bitis FROM MesaiSaati WHERE user_id = 2";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string gun = reader["gun"].ToString();
                    string mesaiBaslangic = reader["mesai_baslangic"].ToString();
                    string mesaiBitis = reader["mesai_bitis"].ToString();

                    DateTime baslangicDateTime = DateTime.Parse(mesaiBaslangic);
                    string baslangicSaat = baslangicDateTime.ToString("HH");

                    DateTime bitisDateTime = DateTime.Parse(mesaiBitis);
                    string bitisSaat = bitisDateTime.ToString("HH");


                    Label label = null;
                    switch (gun)
                    {
                        case "Pazartesi":
                            label = label18;
                            label.Visible = true;
                            break;
                        case "Salı":
                            label = label19;
                            label.Visible = true;
                            break;
                        case "Çarşamba":
                            label = label20;
                            label.Visible = true;
                            break;
                        case "Perşembe":
                            label = label21;
                            label.Visible = true;
                            break;
                        case "Cuma":
                            label = label22;
                            label.Visible = true;
                            break;
                        case "Cumartesi":
                            label = label23;
                            label.Visible = true;
                            break;
                        case "Pazar":
                            label = label24;
                            label.Visible = true;
                            break;
                        default:
                            break;
                    }

                    label9.Visible = true;


                    if (label != null)
                    {
                        label.Text = baslangicSaat + " - " + bitisSaat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void getMesaiUser3()
        {
            try
            {
                connection.Open();
                string query = "SELECT gun, mesai_baslangic, mesai_bitis FROM MesaiSaati WHERE user_id = 3";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string gun = reader["gun"].ToString();
                    string mesaiBaslangic = reader["mesai_baslangic"].ToString();
                    string mesaiBitis = reader["mesai_bitis"].ToString();

                    DateTime baslangicDateTime = DateTime.Parse(mesaiBaslangic);
                    string baslangicSaat = baslangicDateTime.ToString("HH");

                    DateTime bitisDateTime = DateTime.Parse(mesaiBitis);
                    string bitisSaat = bitisDateTime.ToString("HH");


                    Label label = null;
                    switch (gun)
                    {
                        case "Pazartesi":
                            label = label25;
                            label.Visible = true;
                            break;
                        case "Salı":
                            label = label26;
                            label.Visible = true;
                            break;
                        case "Çarşamba":
                            label = label27;
                            label.Visible = true;
                            break;
                        case "Perşembe":
                            label = label28;
                            label.Visible = true;
                            break;
                        case "Cuma":
                            label = label29;
                            label.Visible = true;
                            break;
                        case "Cumartesi":
                            label = label30;
                            label.Visible = true;
                            break;
                        case "Pazar":
                            label = label31;
                            label.Visible = true;
                            break;
                        default:
                            break;
                    }

                    label10.Visible = true;
                    if (label != null)
                    {
                        label.Text = baslangicSaat + " - " + bitisSaat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelsVisible()
        {
            for (int i = 11; i <= 31; i++)
            {
                string labelName = "label" + i.ToString();
                Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Visible = true;
                }
            }

        }

        private void labelsInvisible()
        {
            for (int i = 8; i <= 31; i++)
            {
                string labelName = "label" + i.ToString();
                Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Visible = false;
                }
            }

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            if (secLevel == "manager")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else if (secLevel == "user")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
            else if (secLevel == "worker")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();


            }
        }
    }

}

