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
    public partial class ogrencitable : Form
    {
        public ogrencitable()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=VEYSEL\SQLEXPRESS;Initial Catalog=pollingsystem;Integrated Security=True");

        private void verilerigoruntule()
        {
            //baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From ogrenci_tablo");

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //baglanti.Close();
        }


        private void aramabttn_Click(object sender, EventArgs e)
        {
            if (aramatxt.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Arama Yapmak İçin İsim Giriniz...");
            }
            else
            {
                baglanti.Open();
                string sorgucumlesi = @"Select * From ogrenci_tablo Where isim like '"+aramatxt.Text+"'";
                SqlCommand komut = new SqlCommand(sorgucumlesi, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (secilenkisi == -1)
            {
                MessageBox.Show("silinecek adam seç");
            }
            else
            {
                //baglanti.Open();
                string sorgucumlesi = @"delete from ogrenci_tablo where id='" + secilenkisi + "' ";
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


        private int secilenkisi = -1;


        private void aramatxt_TextChanged(object sender, EventArgs e)
        {
            if (aramatxt.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Arama Yapmak İçin İsim Giriniz...");
            }
            else
            {
                baglanti.Open();
                string sorgucumlesi = @"Select * From ogrenci_tablo Where id like '" + aramatxt.Text + "'";
                SqlCommand komut = new SqlCommand(sorgucumlesi, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aramatxt.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Arama Yapmak İçin İsim Giriniz...");
            }
            else
            {
                baglanti.Open();
                string sorgucumlesi = @"Select * From ogrenci_tablo Where id like '" + aramatxt.Text + "'";
                SqlCommand komut = new SqlCommand(sorgucumlesi, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void homebttn_Click(object sender, EventArgs e)
        {
            adminpanel fr = new adminpanel();
            fr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenkisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

        }





    }
}
      


