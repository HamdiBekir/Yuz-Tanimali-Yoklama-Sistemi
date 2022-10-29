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
    public partial class terminal_tablo : Form
    {
        public terminal_tablo()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=VEYSEL\SQLEXPRESS;Initial Catalog=pollingsystem;Integrated Security=True");

        private void verilerigoruntule()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("select * from terminal_tablo");

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void ekle_bttn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into terminal_tablo (terminal_adi, ip_adres, status) values (@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3",comboBox1.SelectedIndex.ToString());

            komut.ExecuteNonQuery();
            verilerigoruntule();
            MessageBox.Show("kayıt ekleme işlemi başarılı");
            baglanti.Close();
        }
    }
}
