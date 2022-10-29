namespace yuztanimagiris
{
    partial class dersliktablo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goruntulebttn = new System.Windows.Forms.Button();
            this.eklebttn = new System.Windows.Forms.Button();
            this.silbttn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guncellebttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Derslik Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durum";
            // 
            // goruntulebttn
            // 
            this.goruntulebttn.Location = new System.Drawing.Point(17, 55);
            this.goruntulebttn.Name = "goruntulebttn";
            this.goruntulebttn.Size = new System.Drawing.Size(63, 48);
            this.goruntulebttn.TabIndex = 6;
            this.goruntulebttn.Text = "Görüntüle";
            this.goruntulebttn.UseVisualStyleBackColor = true;
            this.goruntulebttn.Click += new System.EventHandler(this.goruntulebttn_Click);
            // 
            // eklebttn
            // 
            this.eklebttn.Location = new System.Drawing.Point(101, 55);
            this.eklebttn.Name = "eklebttn";
            this.eklebttn.Size = new System.Drawing.Size(63, 48);
            this.eklebttn.TabIndex = 7;
            this.eklebttn.Text = "Ekle";
            this.eklebttn.UseVisualStyleBackColor = true;
            this.eklebttn.Click += new System.EventHandler(this.eklebttn_Click);
            // 
            // silbttn
            // 
            this.silbttn.Location = new System.Drawing.Point(194, 55);
            this.silbttn.Name = "silbttn";
            this.silbttn.Size = new System.Drawing.Size(63, 48);
            this.silbttn.TabIndex = 8;
            this.silbttn.Text = "Sil";
            this.silbttn.UseVisualStyleBackColor = true;
            this.silbttn.Click += new System.EventHandler(this.silbttn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.comboBox1.Location = new System.Drawing.Point(248, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // guncellebttn
            // 
            this.guncellebttn.Location = new System.Drawing.Point(275, 55);
            this.guncellebttn.Name = "guncellebttn";
            this.guncellebttn.Size = new System.Drawing.Size(63, 48);
            this.guncellebttn.TabIndex = 11;
            this.guncellebttn.Text = "Güncelle";
            this.guncellebttn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 354);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 37);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ana Sayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dersliktablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncellebttn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.silbttn);
            this.Controls.Add(this.eklebttn);
            this.Controls.Add(this.goruntulebttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "dersliktablo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dersliktablo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goruntulebttn;
        private System.Windows.Forms.Button eklebttn;
        private System.Windows.Forms.Button silbttn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button guncellebttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}