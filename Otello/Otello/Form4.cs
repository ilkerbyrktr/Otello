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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(currentDirectory, "ico.ico");
            Icon formIcon = new Icon(iconPath);
            this.Icon = formIcon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift();
            shift.SecLevel = "worker";
            shift.Show();
            this.Close();
        }
    }
}
