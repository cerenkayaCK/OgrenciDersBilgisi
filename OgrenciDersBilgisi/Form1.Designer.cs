namespace OgrenciDersBilgisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwDersBilgileri = new DataGridView();
            txtDersAdi = new TextBox();
            DersId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKredi = new TextBox();
            txtDersHarfNotu = new TextBox();
            txtDersKodu = new TextBox();
            txtDersId = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnKaldir = new Button();
            btnOrtalamaHesapla = new Button();
            btnIstatistikleriGoster = new Button();
            lblGuncellemeBilgi = new Label();
            btnTemizle = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwDersBilgileri).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwDersBilgileri
            // 
            dgwDersBilgileri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDersBilgileri.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwDersBilgileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDersBilgileri.Location = new Point(352, 45);
            dgwDersBilgileri.Margin = new Padding(3, 4, 3, 4);
            dgwDersBilgileri.Name = "dgwDersBilgileri";
            dgwDersBilgileri.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwDersBilgileri.Size = new Size(657, 535);
            dgwDersBilgileri.TabIndex = 0;
            dgwDersBilgileri.RowHeaderMouseClick += dgwDersBilgileri_RowHeaderMouseClick;
            // 
            // txtDersAdi
            // 
            txtDersAdi.BorderStyle = BorderStyle.FixedSingle;
            txtDersAdi.Location = new Point(105, 125);
            txtDersAdi.Margin = new Padding(3, 4, 3, 4);
            txtDersAdi.Multiline = true;
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(166, 28);
            txtDersAdi.TabIndex = 3;
            // 
            // DersId
            // 
            DersId.AutoSize = true;
            DersId.Location = new Point(21, 53);
            DersId.Name = "DersId";
            DersId.Size = new Size(59, 20);
            DersId.TabIndex = 6;
            DersId.Text = "Ders Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 125);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Ders Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 197);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 8;
            label3.Text = "Ders Kodu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 269);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Harf Notu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 341);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "Kredisi:";
            // 
            // txtKredi
            // 
            txtKredi.BorderStyle = BorderStyle.FixedSingle;
            txtKredi.Location = new Point(104, 341);
            txtKredi.Margin = new Padding(3, 4, 3, 4);
            txtKredi.Multiline = true;
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(166, 28);
            txtKredi.TabIndex = 11;
            // 
            // txtDersHarfNotu
            // 
            txtDersHarfNotu.BorderStyle = BorderStyle.FixedSingle;
            txtDersHarfNotu.Location = new Point(104, 267);
            txtDersHarfNotu.Margin = new Padding(3, 4, 3, 4);
            txtDersHarfNotu.Multiline = true;
            txtDersHarfNotu.Name = "txtDersHarfNotu";
            txtDersHarfNotu.Size = new Size(166, 29);
            txtDersHarfNotu.TabIndex = 12;
            // 
            // txtDersKodu
            // 
            txtDersKodu.BorderStyle = BorderStyle.FixedSingle;
            txtDersKodu.Location = new Point(104, 197);
            txtDersKodu.Margin = new Padding(3, 4, 3, 4);
            txtDersKodu.Multiline = true;
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(166, 28);
            txtDersKodu.TabIndex = 13;
            // 
            // txtDersId
            // 
            txtDersId.BorderStyle = BorderStyle.FixedSingle;
            txtDersId.Location = new Point(105, 53);
            txtDersId.Margin = new Padding(3, 4, 3, 4);
            txtDersId.Multiline = true;
            txtDersId.Name = "txtDersId";
            txtDersId.Size = new Size(166, 28);
            txtDersId.TabIndex = 14;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.HighlightText;
            btnEkle.ForeColor = SystemColors.ControlText;
            btnEkle.Location = new Point(36, 480);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(146, 45);
            btnEkle.TabIndex = 15;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.HighlightText;
            btnGuncelle.ForeColor = SystemColors.ControlText;
            btnGuncelle.Location = new Point(188, 480);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(135, 45);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.BackColor = SystemColors.HighlightText;
            btnKaldir.ForeColor = SystemColors.ControlText;
            btnKaldir.Location = new Point(36, 533);
            btnKaldir.Margin = new Padding(3, 4, 3, 4);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(287, 47);
            btnKaldir.TabIndex = 17;
            btnKaldir.Text = "KALDIR";
            btnKaldir.UseVisualStyleBackColor = false;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // btnOrtalamaHesapla
            // 
            btnOrtalamaHesapla.Location = new Point(1034, 181);
            btnOrtalamaHesapla.Name = "btnOrtalamaHesapla";
            btnOrtalamaHesapla.Size = new Size(174, 86);
            btnOrtalamaHesapla.TabIndex = 18;
            btnOrtalamaHesapla.Text = "ORTALAMA HESAPLA";
            btnOrtalamaHesapla.UseVisualStyleBackColor = true;
            btnOrtalamaHesapla.Click += btnOrtalamaHesapla_Click;
            // 
            // btnIstatistikleriGoster
            // 
            btnIstatistikleriGoster.Location = new Point(1033, 305);
            btnIstatistikleriGoster.Name = "btnIstatistikleriGoster";
            btnIstatistikleriGoster.Size = new Size(175, 81);
            btnIstatistikleriGoster.TabIndex = 19;
            btnIstatistikleriGoster.Text = "İSTATİSTİKLERİ GÖSTER";
            btnIstatistikleriGoster.UseVisualStyleBackColor = true;
            btnIstatistikleriGoster.Click += btnIstatistikleriGoster_Click;
            // 
            // lblGuncellemeBilgi
            // 
            lblGuncellemeBilgi.AutoSize = true;
            lblGuncellemeBilgi.ForeColor = Color.Black;
            lblGuncellemeBilgi.Location = new Point(205, 458);
            lblGuncellemeBilgi.Name = "lblGuncellemeBilgi";
            lblGuncellemeBilgi.Size = new Size(0, 20);
            lblGuncellemeBilgi.TabIndex = 20;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI", 8F);
            btnTemizle.ForeColor = SystemColors.ControlDarkDark;
            btnTemizle.Location = new Point(218, 392);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(52, 27);
            btnTemizle.TabIndex = 21;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(DersId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDersHarfNotu);
            groupBox1.Controls.Add(txtDersId);
            groupBox1.Controls.Add(txtDersKodu);
            groupBox1.Controls.Add(txtKredi);
            groupBox1.Controls.Add(txtDersAdi);
            groupBox1.Location = new Point(36, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 422);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Bilgisi";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(1211, 590);
            label1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 630);
            Controls.Add(lblGuncellemeBilgi);
            Controls.Add(btnIstatistikleriGoster);
            Controls.Add(btnOrtalamaHesapla);
            Controls.Add(btnKaldir);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgwDersBilgileri);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDersBilgileri).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwDersBilgileri;
        private TextBox txtDersAdi;
        private Label DersId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtKredi;
        private TextBox txtDersHarfNotu;
        private TextBox txtDersKodu;
        private TextBox txtDersId;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnKaldir;
        private Button btnOrtalamaHesapla;
        private Button btnIstatistikleriGoster;
        private Label lblGuncellemeBilgi;
        private Button btnTemizle;
        private GroupBox groupBox1;
        private Label label1;
    }
}
