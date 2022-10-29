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
    public partial class dersliktablo : Form
    {
        public dersliktablo()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=VEYSEL\SQLEXPRESS;Initial Catalog=pollingsystem;Integrated Security=True");

        private void verilerigoruntule()
        {
            //baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From derslik_tablo");

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //baglanti.Close();
        }

        private void goruntulebttn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglanti;
                string sorgu = "select * from derslik_tablo";
                komut1.CommandText = sorgu;
                SqlDataAdapter da = new SqlDataAdapter(komut1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void eklebttn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into derslik_tablo (derslik_adi,status) values (@p1, @p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox1.SelectedIndex.ToString());
            
            komut.ExecuteNonQuery();
            verilerigoruntule();
            MessageBox.Show("Kayıt ekleme başarılı...");
            baglanti.Close();
        }

        private int secilenkisi = -1;
        private void silbttn_Click(object sender, EventArgs e)
        {
            if (secilenkisi == -1)
            {
                MessageBox.Show("silinecek adam seç");
            }
            else
            {
                //baglanti.Open();
                string sorgucumlesi = @"delete from derslik_tablo where derslik_id='" + secilenkisi + "' ";
                SqlCommand komut = new SqlCommand(sorgucumlesi, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //baglanti.Close();
                dataGridView1.DataSource = dt;
                secilenkisi = -1;
                verilerigoruntule();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenkisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminpanel fr = new adminpanel();
            fr.Show();
            this.Close();
        }

    }
}
