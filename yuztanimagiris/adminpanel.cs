using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuztanimagiris
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            giris fr = new giris();
            fr.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admintablo fr = new admintablo();
            fr.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ögrencikayit fr = new ögrencikayit();
            fr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrencitable fr = new ogrencitable();
            fr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dersliktablo fr = new dersliktablo();
            fr.Show();
            this.Close();
        }
    }
}
