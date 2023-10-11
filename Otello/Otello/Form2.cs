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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(currentDirectory, "ico.ico");
            Icon formIcon = new Icon(iconPath);
            this.Icon = formIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.SecLevel = "manager";
            odalar.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Shift shift = new Shift();
            shift.SecLevel = "manager";
            shift.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
