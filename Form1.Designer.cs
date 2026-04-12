namespace KutuphaneYonetimSistemi
{
    partial class Form1
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabKitaplar = new System.Windows.Forms.TabPage();
            this.grpKitapIstatistik = new System.Windows.Forms.GroupBox();
            this.lblOduncteKitap = new System.Windows.Forms.Label();
            this.lblMevcutKitap = new System.Windows.Forms.Label();
            this.lblToplamKitap = new System.Windows.Forms.Label();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.grpKitapArama = new System.Windows.Forms.GroupBox();
            this.btnKitapAra = new System.Windows.Forms.Button();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpKitapBilgileri = new System.Windows.Forms.GroupBox();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKitapTemizle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUyeler = new System.Windows.Forms.TabPage();
            this.grpUyeIstatistik = new System.Windows.Forms.GroupBox();
            this.lblToplamUye = new System.Windows.Forms.Label();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.grpUyeArama = new System.Windows.Forms.GroupBox();
            this.btnUyeAra = new System.Windows.Forms.Button();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUyeTemizle = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUyeAdSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabOdunc = new System.Windows.Forms.TabPage();
            this.grpOduncVerme = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbUyeSecim = new System.Windows.Forms.ComboBox();
            this.btnUyeYenile = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbKitapSecim = new System.Windows.Forms.ComboBox();
            this.btnKitapYenile = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpOduncTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.grpIadeAlma = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIslemID = new System.Windows.Forms.TextBox();
            this.btnIadeAl = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.grpOduncListe = new System.Windows.Forms.GroupBox();
            this.dgvOduncKitaplar = new System.Windows.Forms.DataGridView();
            this.tab.SuspendLayout();
            this.tabKitaplar.SuspendLayout();
            this.grpKitapIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.grpKitapArama.SuspendLayout();
            this.grpKitapBilgileri.SuspendLayout();
            this.tabUyeler.SuspendLayout();
            this.grpUyeIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.grpUyeArama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOdunc.SuspendLayout();
            this.grpOduncVerme.SuspendLayout();
            this.grpIadeAlma.SuspendLayout();
            this.grpOduncListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabKitaplar);
            this.tab.Controls.Add(this.tabUyeler);
            this.tab.Controls.Add(this.tabOdunc);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1184, 661);
            this.tab.TabIndex = 0;
            // 
            // tabKitaplar
            // 
            this.tabKitaplar.Controls.Add(this.grpKitapIstatistik);
            this.tabKitaplar.Controls.Add(this.dgvKitaplar);
            this.tabKitaplar.Controls.Add(this.grpKitapArama);
            this.tabKitaplar.Controls.Add(this.grpKitapBilgileri);
            this.tabKitaplar.Location = new System.Drawing.Point(4, 26);
            this.tabKitaplar.Name = "tabKitaplar";
            this.tabKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabKitaplar.Size = new System.Drawing.Size(1176, 631);
            this.tabKitaplar.TabIndex = 0;
            this.tabKitaplar.Text = "Kitap İşlemleri";
            this.tabKitaplar.UseVisualStyleBackColor = true;
            // 
            // grpKitapIstatistik
            // 
            this.grpKitapIstatistik.Controls.Add(this.lblOduncteKitap);
            this.grpKitapIstatistik.Controls.Add(this.lblMevcutKitap);
            this.grpKitapIstatistik.Controls.Add(this.lblToplamKitap);
            this.grpKitapIstatistik.Location = new System.Drawing.Point(440, 480);
            this.grpKitapIstatistik.Name = "grpKitapIstatistik";
            this.grpKitapIstatistik.Size = new System.Drawing.Size(720, 80);
            this.grpKitapIstatistik.TabIndex = 3;
            this.grpKitapIstatistik.TabStop = false;
            this.grpKitapIstatistik.Text = "İstatistikler";
            // 
            // lblOduncteKitap
            // 
            this.lblOduncteKitap.AutoSize = true;
            this.lblOduncteKitap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOduncteKitap.Location = new System.Drawing.Point(490, 30);
            this.lblOduncteKitap.Name = "lblOduncteKitap";
            this.lblOduncteKitap.Size = new System.Drawing.Size(71, 17);
            this.lblOduncteKitap.TabIndex = 4;
            this.lblOduncteKitap.Text = "Ödünçte:0";
            // 
            // lblMevcutKitap
            // 
            this.lblMevcutKitap.AutoSize = true;
            this.lblMevcutKitap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutKitap.Location = new System.Drawing.Point(260, 30);
            this.lblMevcutKitap.Name = "lblMevcutKitap";
            this.lblMevcutKitap.Size = new System.Drawing.Size(64, 17);
            this.lblMevcutKitap.TabIndex = 1;
            this.lblMevcutKitap.Text = "Mevcut:0";
            // 
            // lblToplamKitap
            // 
            this.lblToplamKitap.AutoSize = true;
            this.lblToplamKitap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKitap.Location = new System.Drawing.Point(35, 25);
            this.lblToplamKitap.Name = "lblToplamKitap";
            this.lblToplamKitap.Size = new System.Drawing.Size(101, 17);
            this.lblToplamKitap.TabIndex = 0;
            this.lblToplamKitap.Text = "Toplam Kitap:0";
            this.lblToplamKitap.Click += new System.EventHandler(this.lblToplamKitap_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(440, 110);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(720, 360);
            this.dgvKitaplar.TabIndex = 2;
            this.dgvKitaplar.SelectionChanged += new System.EventHandler(this.dgvKitaplar_SelectionChanged);
            // 
            // grpKitapArama
            // 
            this.grpKitapArama.Controls.Add(this.btnKitapAra);
            this.grpKitapArama.Controls.Add(this.txtKitapAra);
            this.grpKitapArama.Controls.Add(this.label8);
            this.grpKitapArama.Location = new System.Drawing.Point(440, 20);
            this.grpKitapArama.Name = "grpKitapArama";
            this.grpKitapArama.Size = new System.Drawing.Size(720, 80);
            this.grpKitapArama.TabIndex = 1;
            this.grpKitapArama.TabStop = false;
            this.grpKitapArama.Text = "Arama";
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Location = new System.Drawing.Point(610, 25);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(90, 30);
            this.btnKitapAra.TabIndex = 2;
            this.btnKitapAra.Text = "Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(100, 27);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(500, 25);
            this.txtKitapAra.TabIndex = 1;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            this.txtKitapAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapAra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kitap Ara:";
            // 
            // grpKitapBilgileri
            // 
            this.grpKitapBilgileri.Controls.Add(this.txtKitapId);
            this.grpKitapBilgileri.Controls.Add(this.label9);
            this.grpKitapBilgileri.Controls.Add(this.btnKitapTemizle);
            this.grpKitapBilgileri.Controls.Add(this.btnKitapSil);
            this.grpKitapBilgileri.Controls.Add(this.btnKitapGuncelle);
            this.grpKitapBilgileri.Controls.Add(this.btnKitapEkle);
            this.grpKitapBilgileri.Controls.Add(this.cmbDurum);
            this.grpKitapBilgileri.Controls.Add(this.label7);
            this.grpKitapBilgileri.Controls.Add(this.cmbKategori);
            this.grpKitapBilgileri.Controls.Add(this.label4);
            this.grpKitapBilgileri.Controls.Add(this.txtSayfaSayisi);
            this.grpKitapBilgileri.Controls.Add(this.label5);
            this.grpKitapBilgileri.Controls.Add(this.txtYayinevi);
            this.grpKitapBilgileri.Controls.Add(this.label6);
            this.grpKitapBilgileri.Controls.Add(this.txtYazar);
            this.grpKitapBilgileri.Controls.Add(this.label3);
            this.grpKitapBilgileri.Controls.Add(this.txtKitapAdi);
            this.grpKitapBilgileri.Controls.Add(this.label2);
            this.grpKitapBilgileri.Controls.Add(this.txtISBN);
            this.grpKitapBilgileri.Controls.Add(this.label1);
            this.grpKitapBilgileri.Location = new System.Drawing.Point(20, 20);
            this.grpKitapBilgileri.Name = "grpKitapBilgileri";
            this.grpKitapBilgileri.Size = new System.Drawing.Size(400, 540);
            this.grpKitapBilgileri.TabIndex = 0;
            this.grpKitapBilgileri.TabStop = false;
            this.grpKitapBilgileri.Text = "Kitap Bilgileri";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(150, 307);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.ReadOnly = true;
            this.txtKitapId.Size = new System.Drawing.Size(220, 25);
            this.txtKitapId.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "ID:";
            // 
            // btnKitapTemizle
            // 
            this.btnKitapTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnKitapTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapTemizle.ForeColor = System.Drawing.Color.White;
            this.btnKitapTemizle.Location = new System.Drawing.Point(24, 423);
            this.btnKitapTemizle.Name = "btnKitapTemizle";
            this.btnKitapTemizle.Size = new System.Drawing.Size(350, 40);
            this.btnKitapTemizle.TabIndex = 17;
            this.btnKitapTemizle.Text = "Temizle";
            this.btnKitapTemizle.UseVisualStyleBackColor = false;
            this.btnKitapTemizle.Click += new System.EventHandler(this.btnKitapTemizle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnKitapSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapSil.ForeColor = System.Drawing.Color.White;
            this.btnKitapSil.Location = new System.Drawing.Point(264, 373);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(110, 40);
            this.btnKitapSil.TabIndex = 16;
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.UseVisualStyleBackColor = false;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnKitapGuncelle.Location = new System.Drawing.Point(144, 373);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(110, 40);
            this.btnKitapGuncelle.TabIndex = 15;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = false;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnKitapEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.Color.White;
            this.btnKitapEkle.Location = new System.Drawing.Point(24, 373);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(110, 40);
            this.btnKitapEkle.TabIndex = 14;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Ödünç",
            "Mevcut"});
            this.cmbDurum.Location = new System.Drawing.Point(150, 267);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(220, 25);
            this.cmbDurum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Durum:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "- Roman",
            "- Bilim Kurgu",
            "- Fantastik",
            "- Tarih",
            "- Felsefe",
            "- Psikoloji",
            "- Edebiyat (Şiir, Deneme, Hikâye)",
            "- Çocuk Kitapları",
            "- Araştırma / Akademik",
            "- Din / Mitoloji"});
            this.cmbKategori.Location = new System.Drawing.Point(150, 227);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(220, 25);
            this.cmbKategori.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategori:";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(150, 187);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(220, 25);
            this.txtSayfaSayisi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(150, 147);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(220, 25);
            this.txtYayinevi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yayınevi:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(150, 107);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(220, 25);
            this.txtYazar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(150, 67);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(220, 25);
            this.txtKitapAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(150, 27);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(220, 25);
            this.txtISBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // tabUyeler
            // 
            this.tabUyeler.Controls.Add(this.grpUyeIstatistik);
            this.tabUyeler.Controls.Add(this.dgvUyeler);
            this.tabUyeler.Controls.Add(this.grpUyeArama);
            this.tabUyeler.Controls.Add(this.groupBox1);
            this.tabUyeler.Location = new System.Drawing.Point(4, 26);
            this.tabUyeler.Name = "tabUyeler";
            this.tabUyeler.Padding = new System.Windows.Forms.Padding(3);
            this.tabUyeler.Size = new System.Drawing.Size(1176, 631);
            this.tabUyeler.TabIndex = 1;
            this.tabUyeler.Text = "Üye İşlemleri";
            this.tabUyeler.UseVisualStyleBackColor = true;
            // 
            // grpUyeIstatistik
            // 
            this.grpUyeIstatistik.Controls.Add(this.lblToplamUye);
            this.grpUyeIstatistik.Location = new System.Drawing.Point(440, 480);
            this.grpUyeIstatistik.Name = "grpUyeIstatistik";
            this.grpUyeIstatistik.Size = new System.Drawing.Size(720, 80);
            this.grpUyeIstatistik.TabIndex = 3;
            this.grpUyeIstatistik.TabStop = false;
            this.grpUyeIstatistik.Text = "İstatistikler";
            // 
            // lblToplamUye
            // 
            this.lblToplamUye.AutoSize = true;
            this.lblToplamUye.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUye.Location = new System.Drawing.Point(30, 30);
            this.lblToplamUye.Name = "lblToplamUye";
            this.lblToplamUye.Size = new System.Drawing.Size(96, 17);
            this.lblToplamUye.TabIndex = 0;
            this.lblToplamUye.Text = "Toplam Üye: 0";
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.AllowUserToAddRows = false;
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(440, 110);
            this.dgvUyeler.MultiSelect = false;
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(720, 360);
            this.dgvUyeler.TabIndex = 2;
            this.dgvUyeler.SelectionChanged += new System.EventHandler(this.dgvUyeler_SelectionChanged);
            // 
            // grpUyeArama
            // 
            this.grpUyeArama.Controls.Add(this.btnUyeAra);
            this.grpUyeArama.Controls.Add(this.txtUyeAra);
            this.grpUyeArama.Controls.Add(this.label14);
            this.grpUyeArama.Location = new System.Drawing.Point(440, 20);
            this.grpUyeArama.Name = "grpUyeArama";
            this.grpUyeArama.Size = new System.Drawing.Size(720, 80);
            this.grpUyeArama.TabIndex = 1;
            this.grpUyeArama.TabStop = false;
            this.grpUyeArama.Text = "Arama";
            // 
            // btnUyeAra
            // 
            this.btnUyeAra.Location = new System.Drawing.Point(610, 25);
            this.btnUyeAra.Name = "btnUyeAra";
            this.btnUyeAra.Size = new System.Drawing.Size(90, 30);
            this.btnUyeAra.TabIndex = 2;
            this.btnUyeAra.Text = "Ara";
            this.btnUyeAra.UseVisualStyleBackColor = true;
            this.btnUyeAra.Click += new System.EventHandler(this.btnUyeAra_Click);
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(100, 27);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(500, 25);
            this.txtUyeAra.TabIndex = 1;
            this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Üye Ara:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUyeId);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnUyeTemizle);
            this.groupBox1.Controls.Add(this.btnUyeSil);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtUyeAdSoyad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTCNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(150, 187);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.ReadOnly = true;
            this.txtUyeId.Size = new System.Drawing.Size(220, 25);
            this.txtUyeId.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "ID:";
            // 
            // btnUyeTemizle
            // 
            this.btnUyeTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnUyeTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeTemizle.ForeColor = System.Drawing.Color.White;
            this.btnUyeTemizle.Location = new System.Drawing.Point(20, 278);
            this.btnUyeTemizle.Name = "btnUyeTemizle";
            this.btnUyeTemizle.Size = new System.Drawing.Size(350, 40);
            this.btnUyeTemizle.TabIndex = 10;
            this.btnUyeTemizle.Text = "Temizle";
            this.btnUyeTemizle.UseVisualStyleBackColor = false;
            this.btnUyeTemizle.Click += new System.EventHandler(this.btnUyeTemizle_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnUyeSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeSil.ForeColor = System.Drawing.Color.White;
            this.btnUyeSil.Location = new System.Drawing.Point(260, 228);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(110, 40);
            this.btnUyeSil.TabIndex = 9;
            this.btnUyeSil.Text = "Sil";
            this.btnUyeSil.UseVisualStyleBackColor = false;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnUyeEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.ForeColor = System.Drawing.Color.White;
            this.btnUyeEkle.Location = new System.Drawing.Point(20, 228);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(110, 40);
            this.btnUyeEkle.TabIndex = 8;
            this.btnUyeEkle.Text = "Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(150, 147);
            this.txtEposta.MaxLength = 60;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(220, 25);
            this.txtEposta.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "E-Posta:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(150, 107);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 25);
            this.txtTelefon.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Telefon:";
            // 
            // txtUyeAdSoyad
            // 
            this.txtUyeAdSoyad.Location = new System.Drawing.Point(150, 67);
            this.txtUyeAdSoyad.MaxLength = 55;
            this.txtUyeAdSoyad.Name = "txtUyeAdSoyad";
            this.txtUyeAdSoyad.Size = new System.Drawing.Size(220, 25);
            this.txtUyeAdSoyad.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ad Soyad:";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(150, 27);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(220, 25);
            this.txtTCNo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "TC No:";
            // 
            // tabOdunc
            // 
            this.tabOdunc.Controls.Add(this.grpOduncListe);
            this.tabOdunc.Controls.Add(this.grpIadeAlma);
            this.tabOdunc.Controls.Add(this.grpOduncVerme);
            this.tabOdunc.Location = new System.Drawing.Point(4, 26);
            this.tabOdunc.Name = "tabOdunc";
            this.tabOdunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdunc.Size = new System.Drawing.Size(1176, 631);
            this.tabOdunc.TabIndex = 2;
            this.tabOdunc.Text = "Ödünç İşlemleri";
            this.tabOdunc.UseVisualStyleBackColor = true;
            // 
            // grpOduncVerme
            // 
            this.grpOduncVerme.Controls.Add(this.btnOduncVer);
            this.grpOduncVerme.Controls.Add(this.dtpOduncTarihi);
            this.grpOduncVerme.Controls.Add(this.label18);
            this.grpOduncVerme.Controls.Add(this.btnKitapYenile);
            this.grpOduncVerme.Controls.Add(this.cmbKitapSecim);
            this.grpOduncVerme.Controls.Add(this.label17);
            this.grpOduncVerme.Controls.Add(this.btnUyeYenile);
            this.grpOduncVerme.Controls.Add(this.cmbUyeSecim);
            this.grpOduncVerme.Controls.Add(this.label16);
            this.grpOduncVerme.Location = new System.Drawing.Point(20, 20);
            this.grpOduncVerme.Name = "grpOduncVerme";
            this.grpOduncVerme.Size = new System.Drawing.Size(1140, 180);
            this.grpOduncVerme.TabIndex = 0;
            this.grpOduncVerme.TabStop = false;
            this.grpOduncVerme.Text = "Ödünç Kitap Ver";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Üye Seç:";
            // 
            // cmbUyeSecim
            // 
            this.cmbUyeSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyeSecim.FormattingEnabled = true;
            this.cmbUyeSecim.Location = new System.Drawing.Point(150, 37);
            this.cmbUyeSecim.Name = "cmbUyeSecim";
            this.cmbUyeSecim.Size = new System.Drawing.Size(400, 25);
            this.cmbUyeSecim.TabIndex = 1;
            // 
            // btnUyeYenile
            // 
            this.btnUyeYenile.Location = new System.Drawing.Point(560, 35);
            this.btnUyeYenile.Name = "btnUyeYenile";
            this.btnUyeYenile.Size = new System.Drawing.Size(40, 30);
            this.btnUyeYenile.TabIndex = 2;
            this.btnUyeYenile.Text = "🔄";
            this.btnUyeYenile.UseVisualStyleBackColor = true;
            this.btnUyeYenile.Click += new System.EventHandler(this.btnUyeYenile_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Kitap Seç:";
            // 
            // cmbKitapSecim
            // 
            this.cmbKitapSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitapSecim.FormattingEnabled = true;
            this.cmbKitapSecim.Location = new System.Drawing.Point(150, 87);
            this.cmbKitapSecim.Name = "cmbKitapSecim";
            this.cmbKitapSecim.Size = new System.Drawing.Size(400, 25);
            this.cmbKitapSecim.TabIndex = 4;
            // 
            // btnKitapYenile
            // 
            this.btnKitapYenile.Location = new System.Drawing.Point(560, 87);
            this.btnKitapYenile.Name = "btnKitapYenile";
            this.btnKitapYenile.Size = new System.Drawing.Size(40, 30);
            this.btnKitapYenile.TabIndex = 5;
            this.btnKitapYenile.Text = "🔄";
            this.btnKitapYenile.UseVisualStyleBackColor = true;
            this.btnKitapYenile.Click += new System.EventHandler(this.btnKitapYenile_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(650, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "Ödünç Tarihi:";
            // 
            // dtpOduncTarihi
            // 
            this.dtpOduncTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOduncTarihi.Location = new System.Drawing.Point(780, 37);
            this.dtpOduncTarihi.Name = "dtpOduncTarihi";
            this.dtpOduncTarihi.Size = new System.Drawing.Size(250, 25);
            this.dtpOduncTarihi.TabIndex = 7;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnOduncVer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOduncVer.ForeColor = System.Drawing.Color.White;
            this.btnOduncVer.Location = new System.Drawing.Point(650, 85);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(380, 50);
            this.btnOduncVer.TabIndex = 8;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.UseVisualStyleBackColor = false;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // grpIadeAlma
            // 
            this.grpIadeAlma.Controls.Add(this.label20);
            this.grpIadeAlma.Controls.Add(this.btnIadeAl);
            this.grpIadeAlma.Controls.Add(this.txtIslemID);
            this.grpIadeAlma.Controls.Add(this.label19);
            this.grpIadeAlma.Location = new System.Drawing.Point(20, 220);
            this.grpIadeAlma.Name = "grpIadeAlma";
            this.grpIadeAlma.Size = new System.Drawing.Size(1140, 100);
            this.grpIadeAlma.TabIndex = 1;
            this.grpIadeAlma.TabStop = false;
            this.grpIadeAlma.Text = "Kitap İade Al";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "İade Edilecek İşlem ID:";
            // 
            // txtIslemID
            // 
            this.txtIslemID.Location = new System.Drawing.Point(200, 37);
            this.txtIslemID.Name = "txtIslemID";
            this.txtIslemID.ReadOnly = true;
            this.txtIslemID.Size = new System.Drawing.Size(150, 25);
            this.txtIslemID.TabIndex = 1;
            // 
            // btnIadeAl
            // 
            this.btnIadeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIadeAl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIadeAl.ForeColor = System.Drawing.Color.White;
            this.btnIadeAl.Location = new System.Drawing.Point(400, 30);
            this.btnIadeAl.Name = "btnIadeAl";
            this.btnIadeAl.Size = new System.Drawing.Size(200, 50);
            this.btnIadeAl.TabIndex = 2;
            this.btnIadeAl.Text = "İade Al";
            this.btnIadeAl.UseVisualStyleBackColor = false;
            this.btnIadeAl.Click += new System.EventHandler(this.btnIadeAl_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(650, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(248, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "* Aşağıdaki listeden iade alınacak kitabı seçin";
            // 
            // grpOduncListe
            // 
            this.grpOduncListe.Controls.Add(this.dgvOduncKitaplar);
            this.grpOduncListe.Location = new System.Drawing.Point(20, 340);
            this.grpOduncListe.Name = "grpOduncListe";
            this.grpOduncListe.Size = new System.Drawing.Size(1140, 220);
            this.grpOduncListe.TabIndex = 2;
            this.grpOduncListe.TabStop = false;
            this.grpOduncListe.Text = "Ödünç Kitaplar Listesi";
            // 
            // dgvOduncKitaplar
            // 
            this.dgvOduncKitaplar.AllowUserToAddRows = false;
            this.dgvOduncKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOduncKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncKitaplar.Location = new System.Drawing.Point(20, 30);
            this.dgvOduncKitaplar.MultiSelect = false;
            this.dgvOduncKitaplar.Name = "dgvOduncKitaplar";
            this.dgvOduncKitaplar.ReadOnly = true;
            this.dgvOduncKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOduncKitaplar.Size = new System.Drawing.Size(1100, 170);
            this.dgvOduncKitaplar.TabIndex = 0;
            this.dgvOduncKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOduncKitaplar_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Yönetim Sistemi";
            this.tab.ResumeLayout(false);
            this.tabKitaplar.ResumeLayout(false);
            this.grpKitapIstatistik.ResumeLayout(false);
            this.grpKitapIstatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.grpKitapArama.ResumeLayout(false);
            this.grpKitapArama.PerformLayout();
            this.grpKitapBilgileri.ResumeLayout(false);
            this.grpKitapBilgileri.PerformLayout();
            this.tabUyeler.ResumeLayout(false);
            this.grpUyeIstatistik.ResumeLayout(false);
            this.grpUyeIstatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.grpUyeArama.ResumeLayout(false);
            this.grpUyeArama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOdunc.ResumeLayout(false);
            this.grpOduncVerme.ResumeLayout(false);
            this.grpOduncVerme.PerformLayout();
            this.grpIadeAlma.ResumeLayout(false);
            this.grpIadeAlma.PerformLayout();
            this.grpOduncListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabKitaplar;
        private System.Windows.Forms.GroupBox grpKitapBilgileri;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabUyeler;
        private System.Windows.Forms.TabPage tabOdunc;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpKitapArama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKitapTemizle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.GroupBox grpKitapIstatistik;
        private System.Windows.Forms.Label lblOduncteKitap;
        private System.Windows.Forms.Label lblMevcutKitap;
        private System.Windows.Forms.Label lblToplamKitap;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Button btnUyeTemizle;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUyeAdSoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpUyeIstatistik;
        private System.Windows.Forms.Label lblToplamUye;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.GroupBox grpUyeArama;
        private System.Windows.Forms.Button btnUyeAra;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUyeId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpOduncVerme;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpOduncTarihi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnKitapYenile;
        private System.Windows.Forms.ComboBox cmbKitapSecim;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnUyeYenile;
        private System.Windows.Forms.ComboBox cmbUyeSecim;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.GroupBox grpIadeAlma;
        private System.Windows.Forms.TextBox txtIslemID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grpOduncListe;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnIadeAl;
        private System.Windows.Forms.DataGridView dgvOduncKitaplar;
    }
}

