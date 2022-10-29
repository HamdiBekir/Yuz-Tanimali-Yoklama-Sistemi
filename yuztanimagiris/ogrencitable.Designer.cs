namespace yuztanimagiris
{
    partial class ogrencitable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.aramabttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.homebttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 355);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(12, 16);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 55);
            this.btnsil.TabIndex = 45;
            this.btnsil.Text = "Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 46;
            this.button2.Text = "Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(367, 34);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(100, 20);
            this.aramatxt.TabIndex = 47;
            this.aramatxt.TextChanged += new System.EventHandler(this.aramatxt_TextChanged);
            // 
            // aramabttn
            // 
            this.aramabttn.Location = new System.Drawing.Point(174, 17);
            this.aramabttn.Name = "aramabttn";
            this.aramabttn.Size = new System.Drawing.Size(72, 54);
            this.aramabttn.TabIndex = 48;
            this.aramabttn.Text = "İsime Göre Arama";
            this.aramabttn.UseVisualStyleBackColor = true;
            this.aramabttn.Click += new System.EventHandler(this.aramabttn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 52);
            this.button1.TabIndex = 49;
            this.button1.Text = "Öğrenci Numarasına Göre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homebttn
            // 
            this.homebttn.Location = new System.Drawing.Point(543, 12);
            this.homebttn.Name = "homebttn";
            this.homebttn.Size = new System.Drawing.Size(75, 55);
            this.homebttn.TabIndex = 50;
            this.homebttn.Text = "Ana Sayfaya Dön";
            this.homebttn.UseVisualStyleBackColor = true;
            this.homebttn.Click += new System.EventHandler(this.homebttn_Click);
            // 
            // ogrencitable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 475);
            this.Controls.Add(this.homebttn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aramabttn);
            this.Controls.Add(this.aramatxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrencitable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrencitable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox aramatxt;
        private System.Windows.Forms.Button aramabttn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homebttn;
    }
}