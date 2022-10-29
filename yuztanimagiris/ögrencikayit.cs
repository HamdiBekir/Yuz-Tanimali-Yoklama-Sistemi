using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   namespace yuztanimagiris {      public partial class ögrencikayit : Form     {         public ögrencikayit()         {
            Control.CheckForIllegalCrossThreadCalls = false;             InitializeComponent();         }

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
        }          private void fakultecombo_SelectedIndexChanged(object sender, EventArgs e)         {             switch (fakultecombo.SelectedIndex)             {                 case 0:                      {                         bolumcombo.Items.Clear();                         bolumcombo.Items.Add("Matematik");                         bolumcombo.Items.Add("Psikoloji");                         bolumcombo.Items.Add("Türk Dili Ve Edebiyatı");                         bolumcombo.Items.Add("Tarih");                     }                     break;                 case 1:                     {                         bolumcombo.Items.Clear();                         bolumcombo.Items.Add("Hemşirelik");                         bolumcombo.Items.Add("Ebelik");                         bolumcombo.Items.Add("İş Sağlığı Ve Güvenliği");                         bolumcombo.Items.Add("Beslenme Ve Diyetetik");                     }                     break;                 case 2:                     {                         bolumcombo.Items.Clear();                         bolumcombo.Items.Add("Bilgisayar Mühendisliği");                         bolumcombo.Items.Add("İnşaat Mühendisliği");                         bolumcombo.Items.Add("Makine Mühendisliği");                         bolumcombo.Items.Add("Kimya Mühendisliği");                         bolumcombo.Items.Add("Elektrik Elektronik Mühendisliği");                     }                     break;                 case 3:                     {                         bolumcombo.Items.Clear();                         bolumcombo.Items.Add("Bilgisayar Programcılığı");                         bolumcombo.Items.Add("İnşaat Bölümü");                         bolumcombo.Items.Add("Gıda İşleme Bölümü");                         bolumcombo.Items.Add("Elektrik Ve Enerji Bölümü");                     }                     break;
                case 4:
                    {
                        bolumcombo.Items.Clear();
                        bolumcombo.Items.Add("Grafik Tasarım Bölümü");
                        bolumcombo.Items.Add("Mimarlık Bölümü");
                        bolumcombo.Items.Add("Şehir Ve Bölge Planlama Bölümü");
                        bolumcombo.Items.Add("Peyzaj Mimarlığı Bölümü");

                    }
                    break;             }         }

        private async void btnEgit_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!recognition.SaveTrainingData(pictureBox2.Image, txtFaceName.Text)) MessageBox.Show("Hata", "Profil alınırken beklenmeyen bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(100);
                    lblEgitilenAdet.Text = (i + 1) + " adet profil kaydedildi.";
                }

                recognition = null;
                train = null;

                recognition = new BusinessRecognition();

                recognition = new BusinessRecognition("C:\\", "Faces", "yuz.xml");
                train = new Classifier_Train("C:\\", "Faces", "yuz.xml");
            });


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ogrenci_tablo (isim,soyisim,tc,ogrenci_no,fakulteid,bolumid,status) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFaceName.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt64(txtkimlik.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt64(txtögrencino.Text));
            komut.Parameters.AddWithValue("@p5", fakultecombo.SelectedIndex.ToString());
            komut.Parameters.AddWithValue("@p6", bolumcombo.SelectedIndex.ToString());
            komut.Parameters.AddWithValue("@p7", aktifcombo.SelectedIndex.ToString());

            komut.ExecuteNonQuery();
            AlanlariTemizle();
            verilerigoruntule();
            MessageBox.Show("Kayıt Ekleme Başarılı.");
            baglanti.Close();
        }
        BusinessRecognition recognition = new BusinessRecognition("C:\\", "Faces", "yuz.xml");
        Classifier_Train train = new Classifier_Train(":\\", "Faces", "yuz.xml");

        private void ögrencikayit_Load(object sender, EventArgs e)
        {
            verilerigoruntule();
            Capture capture = new Capture();
            {
                capture.Start();
                capture.ImageGrabbed += (a, b) =>
                {
                    var image = capture.RetrieveBgrFrame();
                    var grayimage = image.Convert<Gray, byte>();
                    HaarCascade haaryuz = new HaarCascade("haarcascade_frontalface_alt2.xml");
                    MCvAvgComp[][] Yuzler = grayimage.DetectHaarCascade(haaryuz, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                    foreach (MCvAvgComp yuz in Yuzler[0])
                    {
                        var sadeyuz = grayimage.Copy(yuz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                        //Resimler aynı boyutta olmalıdır. O yüzden Resize ile yeniden boyutlandırma yapılmıştır. Aksi taktirde Classifier_Train sınıfının 245. satırında hata alınacaktır.
                        pictureBox2.Image = sadeyuz.ToBitmap();
                        if (train != null)
                            if (train.IsTrained)
                            {
                                string name = train.Recognise(sadeyuz);
                                int match_value = (int)train.Get_Eigen_Distance;
                                image.Draw(name + " ", ref font, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.LightGreen));
                            }
                        image.Draw(yuz.rect, new Bgr(Color.Red), 2);
                    }
                    pictureBox1.Image = image.ToBitmap();
                };
            }
        }

        private void btnEgitimSil_Click(object sender, EventArgs e)
        {
            recognition.DeleteTrains();
        }

        private void AlanlariTemizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ogrenci_tablo (isim,soyisim,tc,ogrenci_no,fakulteid,bolumid,status) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFaceName.Text); 
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt64(txtkimlik.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt64(txtögrencino.Text));
            komut.Parameters.AddWithValue("@p5", fakultecombo.SelectedIndex.ToString());
            komut.Parameters.AddWithValue("@p6", bolumcombo.SelectedIndex.ToString());
            komut.Parameters.AddWithValue("@p7", aktifcombo.SelectedIndex.ToString());

            komut.ExecuteNonQuery();
            AlanlariTemizle();
            verilerigoruntule();
            MessageBox.Show("Kayıt Ekleme Başarılı.");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglanti;
                string sorgu = "Select * From ogrenci_tablosu";
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


        private void btnsil_Click(object sender, EventArgs e)
        {
            if (secilenkisi == -1)
            {
                MessageBox.Show("silinecek adam seç");
            }
            else
            {
                //baglanti.Open();
                string sorgucumlesi = @"delete from ogrenci_tablo where id='"+secilenkisi+"' ";
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenkisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ogrenci_tablo", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminpanel fr = new adminpanel();
            fr.Show();
            this.Close();
        }             } } 