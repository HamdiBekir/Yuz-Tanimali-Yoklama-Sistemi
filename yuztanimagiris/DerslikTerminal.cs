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
    public partial class DerslikTerminal : Form
    {
        public DerslikTerminal()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=VEYSEL\SQLEXPRESS;Initial Catalog=pollingsystem;Integrated Security=True");


        private void verilerigoruntule()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * from derslik_terminal_tablo");

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private int secilen = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secilen == -1)
            {
                MessageBox.Show("Silinecek Kişiyi Seçin");
            }
            else
            {
                string sorgu = @"delete from derslik_terminal_tablo where id='" + secilen + "' ";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                secilen = -1;
                verilerigoruntule();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into derslik_terminal_tablo (derslik_id,terminal_id) values (@p1, @p2)", baglanti);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminpanel fr = new adminpanel();
            fr.Show();

        }

        



    }
}
