using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yuztanimagiris
{
    public partial class adminpanelgiris : Form
    {
        public adminpanelgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=VEYSEL\SQLEXPRESS;Initial Catalog=pollingsystem;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
               
                string sql = "Select * From parola where Ad=@adi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    adminpanel fr = new adminpanel();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Hatalı Giriş");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris fr = new giris();
            fr.Show();
            this.Close();
        }
    }
}
