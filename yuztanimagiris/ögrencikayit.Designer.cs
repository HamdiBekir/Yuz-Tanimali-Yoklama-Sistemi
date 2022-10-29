namespace yuztanimagiris
{
    partial class ögrencikayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEgitimSil = new System.Windows.Forms.Button();
            this.txtFaceName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEgitilenAdet = new System.Windows.Forms.Label();
            this.btnEgit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fakultecombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bolumcombo = new System.Windows.Forms.ComboBox();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtögrencino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.aktifcombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEgitimSil
            // 
            this.btnEgitimSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEgitimSil.Location = new System.Drawing.Point(846, 490);
            this.btnEgitimSil.Name = "btnEgitimSil";
            this.btnEgitimSil.Size = new System.Drawing.Size(66, 40);
            this.btnEgitimSil.TabIndex = 19;
            this.btnEgitimSil.Text = "Tüm Eğitimleri Sil";
            this.btnEgitimSil.UseVisualStyleBackColor = false;
            this.btnEgitimSil.Click += new System.EventHandler(this.btnEgitimSil_Click);
            // 
            // txtFaceName
            // 
            this.txtFaceName.Location = new System.Drawing.Point(679, 38);
            this.txtFaceName.Name = "txtFaceName";
            this.txtFaceName.Size = new System.Drawing.Size(100, 20);
            this.txtFaceName.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(678, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblEgitilenAdet
            // 
            this.lblEgitilenAdet.AutoSize = true;
            this.lblEgitilenAdet.Location = new System.Drawing.Point(843, 462);
            this.lblEgitilenAdet.Name = "lblEgitilenAdet";
            this.lblEgitilenAdet.Size = new System.Drawing.Size(29, 13);
            this.lblEgitilenAdet.TabIndex = 16;
            this.lblEgitilenAdet.Text = "Adet";
            // 
            // btnEgit
            // 
            this.btnEgit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEgit.Location = new System.Drawing.Point(678, 161);
            this.btnEgit.Name = "btnEgit";
            this.btnEgit.Size = new System.Drawing.Size(75, 55);
            this.btnEgit.TabIndex = 15;
            this.btnEgit.Text = "Öğrenciyi Kaydet";
            this.btnEgit.UseVisualStyleBackColor = false;
            this.btnEgit.Click += new System.EventHandler(this.btnEgit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // fakultecombo
            // 
            this.fakultecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fakultecombo.FormattingEnabled = true;
            this.fakultecombo.Items.AddRange(new object[] {
            "Fen - Edebiyat Fakültesi",
            "Sağlık Bilimleri Fakültesi",
            "Mühendislik Fakültesi",
            "Teknik Bilimler Meslek Yüksekokulu",
            "Güzel Sanatlar Ve Tasarım Fakültesi"});
            this.fakultecombo.Location = new System.Drawing.Point(932, 34);
            this.fakultecombo.Name = "fakultecombo";
            this.fakultecombo.Size = new System.Drawing.Size(204, 21);
            this.fakultecombo.TabIndex = 21;
            this.fakultecombo.SelectedIndexChanged += new System.EventHandler(this.fakultecombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kaydedilecek İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(928, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fakülte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(928, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bölüm";
            // 
            // bolumcombo
            // 
            this.bolumcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bolumcombo.FormattingEnabled = true;
            this.bolumcombo.Location = new System.Drawing.Point(932, 112);
            this.bolumcombo.Name = "bolumcombo";
            this.bolumcombo.Size = new System.Drawing.Size(204, 21);
            this.bolumcombo.TabIndex = 24;
            // 
            // txtkimlik
            // 
            this.txtkimlik.Location = new System.Drawing.Point(678, 112);
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.Size = new System.Drawing.Size(100, 20);
            this.txtkimlik.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(675, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "T.C. Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(809, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Öğrenci No";
            // 
            // txtögrencino
            // 
            this.txtögrencino.Location = new System.Drawing.Point(812, 112);
            this.txtögrencino.Name = "txtögrencino";
            this.txtögrencino.Size = new System.Drawing.Size(100, 20);
            this.txtögrencino.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(809, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Soyad";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(812, 38);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(675, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(236, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "Öğrenci Kayıt Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(678, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 159);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 42;
            this.button2.Text = "Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(841, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 43;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(922, 161);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 55);
            this.btnsil.TabIndex = 44;
            this.btnsil.Text = "Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // aktifcombo
            // 
            this.aktifcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aktifcombo.FormattingEnabled = true;
            this.aktifcombo.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.aktifcombo.Location = new System.Drawing.Point(1055, 179);
            this.aktifcombo.Name = "aktifcombo";
            this.aktifcombo.Size = new System.Drawing.Size(81, 21);
            this.aktifcombo.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1032, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Öğrenci Durumu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1170, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 57);
            this.button4.TabIndex = 47;
            this.button4.Text = "Ana Sayafaya Dön";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ögrencikayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1247, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aktifcombo);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtögrencino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkimlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bolumcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fakultecombo);
            this.Controls.Add(this.btnEgitimSil);
            this.Controls.Add(this.txtFaceName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEgitilenAdet);
            this.Controls.Add(this.btnEgit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ögrencikayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.Load += new System.EventHandler(this.ögrencikayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEgitimSil;
        private System.Windows.Forms.TextBox txtFaceName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEgitilenAdet;
        private System.Windows.Forms.Button btnEgit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox fakultecombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bolumcombo;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtögrencino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ComboBox aktifcombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
    }
}